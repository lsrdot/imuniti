using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoVacinas.Data;
using GestaoVacinas.Models;
using iText.IO.Font.Constants;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;

namespace GestaoVacinas.Controllers {
    public class CadernetasController : Controller {
        private readonly AppDbContext _context;

        public CadernetasController(AppDbContext context) {
            _context = context;
        }

        // GET: Cadernetas
        public async Task<IActionResult> Index() {
            var appDbContext = _context.Cadernetas.Include(c => c.Membro);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Cadernetas/Details/5
        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return NotFound();
            }

            var caderneta = await _context.Cadernetas
                .Include(c => c.Membro)
                .Include(c => c.Vacinas)
                    .ThenInclude(v => v.Detalhes)
                .FirstOrDefaultAsync(m => m.Id == id);
            
            if (caderneta == null) {
                return NotFound();
            }

            var detalhes = await _context.DetalhesVacinas.Where(d => d.CadernetaId == caderneta.Id).ToListAsync();

            foreach (var detalhe in detalhes) {
                detalhe.AtualizarStatus();
            }

            await _context.SaveChangesAsync();

            ViewBag.VacinasPadrao = await _context.Vacinas
                .Where(v => v.IsVacinaPadrao)
                .Include(v => v.Detalhes)
                .ToListAsync();

            ViewBag.VacinasDisponiveis = await _context.Vacinas
                .Where(v => !v.IsVacinaPadrao)
                .Include(v => v.Detalhes)
                .ToListAsync();

            ViewBag.DetalhesVacinasPadrao = await _context.DetalhesVacinas
                .Include(d => d.Vacina)
                .Where(d => d.CadernetaId == id && d.Vacina.IsVacinaPadrao)
                .ToListAsync();

            ViewBag.DetalhesVacinasComplementares = await _context.DetalhesVacinas
                .Include(d => d.Vacina)
                .Where(d => d.CadernetaId == id && !d.Vacina.IsVacinaPadrao)
                .ToListAsync();

            return View(caderneta);
        }

        // GET: Cadernetas/Create
        public IActionResult Create() {
            ViewData["MembroId"] = new SelectList(_context.Membros, "Id", "Apelido");
            return View();
        }

        // POST: Cadernetas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,MembroId")] Caderneta caderneta) {
            if (ModelState.IsValid) {
                _context.Add(caderneta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["MembroId"] = new SelectList(_context.Membros, "Id", "Apelido", caderneta.MembroId);
            return View(caderneta);
        }

        // GET: Cadernetas/Edit/5
        public async Task<IActionResult> Edit(int? id) {
            if (id == null) {
                return NotFound();
            }

            var caderneta = await _context.Cadernetas.FindAsync(id);
            if (caderneta == null) {
                return NotFound();
            }
            ViewData["MembroId"] = new SelectList(_context.Membros, "Id", "Apelido", caderneta.MembroId);
            return View(caderneta);
        }

        // POST: Cadernetas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,MembroId")] Caderneta caderneta) {
            if (id != caderneta.Id) {
                return NotFound();
            }

            if (ModelState.IsValid) {
                try {
                    _context.Update(caderneta);
                    await _context.SaveChangesAsync();
                } catch (DbUpdateConcurrencyException) {
                    if (!CadernetaExists(caderneta.Id)) {
                        return NotFound();
                    } else {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["MembroId"] = new SelectList(_context.Membros, "Id", "Apelido", caderneta.MembroId);
            return View(caderneta);
        }

        // GET: Cadernetas/Delete/5
        public async Task<IActionResult> Delete(int? id) {
            if (id == null) {
                return NotFound();
            }

            var caderneta = await _context.Cadernetas
                .Include(c => c.Membro)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caderneta == null) {
                return NotFound();
            }

            return View(caderneta);
        }

        // POST: Cadernetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) {
            var caderneta = await _context.Cadernetas
        .Include(c => c.Membro)
        .Include(c => c.DetalhesVacinas)
        .FirstOrDefaultAsync(c => c.Id == id);

            if (caderneta == null) {
                TempData["Error"] = "Caderneta não encontrada.";
                return RedirectToAction(nameof(Index));
            }

            var detalhesVacinas = caderneta.DetalhesVacinas.ToList();
            _context.DetalhesVacinas.RemoveRange(detalhesVacinas);

            _context.Cadernetas.Remove(caderneta);

            if (caderneta.Membro != null) {
                _context.Membros.Remove(caderneta.Membro);
            }

            await _context.SaveChangesAsync();

            TempData["Success"] = "Este membro e sua caderneta de vacinas foram excluídos com sucesso.";
            return RedirectToAction("Index", "Home");
		}

        // Método AdicionarVacinaComplementar
        public async Task<IActionResult> AdicionarVacinaComplementar(int id, int vacinaId) {

            var caderneta = await _context.Cadernetas.FindAsync(id);
            if (caderneta == null) return NotFound("Caderneta não encontrada.");

            var vacina = await _context.Vacinas.FindAsync(vacinaId);
            if (vacina == null || vacina.IsVacinaPadrao)
                return BadRequest("Vacina inválida.");

            var novaDose = new DetalhesVacina {
                CadernetaId = caderneta.Id,
                VacinaId = vacina.Id,
                Status = StatusVacina.Futura
            };

            _context.DetalhesVacinas.Add(novaDose);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id });
        }

        // Método SalvarDetalhesVacina
        [HttpPost]
        public async Task<IActionResult> SalvarDetalhesVacina(DetalhesVacina modelo) {
            if (!ModelState.IsValid) {
                Console.WriteLine("Erro no ModelState");
                return RedirectToAction("Details", new { id = modelo.CadernetaId });
            }

            var vacina = await _context.Vacinas.FirstOrDefaultAsync(v => v.Id == modelo.VacinaId);
            var caderneta = await _context.Cadernetas.FirstOrDefaultAsync(c => c.Id == modelo.CadernetaId);

            if (vacina == null || caderneta == null) {
                Console.WriteLine("Vacina ou Caderneta não encontrada.");
                return RedirectToAction("Details", new { id = modelo.CadernetaId });
            }

            modelo.AtualizarStatus();

            var detalhesVacina = await _context.DetalhesVacinas.FirstOrDefaultAsync(d => d.Id == modelo.Id);

            if (detalhesVacina != null) {
                detalhesVacina.DataAplicacao = modelo.DataAplicacao;
                detalhesVacina.NomeVacinador = modelo.NomeVacinador;
                detalhesVacina.Lote = modelo.Lote;
                detalhesVacina.DataValidade = modelo.DataValidade;
                detalhesVacina.Cnes = modelo.Cnes;
                detalhesVacina.Observacoes = modelo.Observacoes;
                detalhesVacina.Status = modelo.Status;
            } else {
                _context.DetalhesVacinas.Add(modelo);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Details", new { id = modelo.CadernetaId });
        }

        // **Método CadernetaExists**
        private bool CadernetaExists(int id) {
            return _context.Cadernetas.Any(e => e.Id == id);
        }

        // Redefinir Vacina Padrão
        [HttpPost]
        public async Task<IActionResult> RedefinirVacinaPadrao(int detalheId) {
            var detalhe = await _context.DetalhesVacinas
                .Include(d => d.Vacina)
                .FirstOrDefaultAsync(d => d.Id == detalheId);

            if (detalhe == null || !detalhe.Vacina.IsVacinaPadrao) {
                return NotFound("Detalhe ou vacina padrão não encontrado.");
            }

            detalhe.DataAplicacao = null;
            detalhe.NomeVacinador = null;
            detalhe.Lote = null;
            detalhe.DataValidade = null;
            detalhe.Cnes = null;
            detalhe.Observacoes = null;

            await _context.SaveChangesAsync();
            return RedirectToAction("Details", new { id = detalhe.CadernetaId });
        }

		// Excluir Vacina Complementar
		[HttpPost]
		public async Task<IActionResult> ExcluirVacinaComplementar(int detalheId) {
			var detalhe = await _context.DetalhesVacinas
				.Include(d => d.Vacina)
				.FirstOrDefaultAsync(d => d.Id == detalheId);

			if (detalhe == null || detalhe.Vacina.IsVacinaPadrao) {
				return NotFound("Detalhe ou vacina complementar não encontrado.");
			}

			// Apenas removemos os detalhes associados à vacina
			_context.DetalhesVacinas.Remove(detalhe);

			await _context.SaveChangesAsync();

			return RedirectToAction("Details", new { id = detalhe.CadernetaId });
		}

        // Imprimir Vacina
		[HttpGet]
		public async Task<IActionResult> ImprimirVacinas(int id) {
			var caderneta = await _context.Cadernetas
	            .Include(c => c.Membro)
	            .Include(c => c.DetalhesVacinas)
		            .ThenInclude(d => d.Vacina)
	            .FirstOrDefaultAsync(c => c.Id == id);

			if (caderneta == null) {
				return NotFound("Caderneta não encontrada.");
			}

			var vacinasExibidas = caderneta.DetalhesVacinas.ToList();
			//var vacinasAplicadas = caderneta.DetalhesVacinas
			//	.Where(d => d.Status == StatusVacina.Aplicada)
			//	.ToList();

			using (var stream = new MemoryStream()) {
				var writer = new PdfWriter(stream);
				var pdf = new PdfDocument(writer);
				var document = new Document(pdf);
				
				var boldFont = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

				var logo = ImageDataFactory.Create("wwwroot/images/logo-impressao.png");
				var logoImage = new iText.Layout.Element.Image(logo).SetWidth(100).SetHorizontalAlignment(HorizontalAlignment.CENTER);
				document.Add(logoImage);

				document.Add(new Paragraph("Caderneta de vacina digital")
					.SetTextAlignment(TextAlignment.CENTER)
					.SetFontSize(18)
					.SetFont(boldFont));

				var tabelaMembro = new Table(UnitValue.CreatePercentArray(new float[] { 1 })).UseAllAvailableWidth();
				tabelaMembro.AddCell(new Cell()
					.Add(new Paragraph($"Nome: {caderneta.Membro.NomeCompleto}\n" +
									   $"Data de Nascimento: {caderneta.Membro.DataNascimento?.ToString("dd/MM/yyyy")}\n" +
									   $"CPF: {caderneta.Membro.Cpf}\n" +
									   $"CNS: {caderneta.Membro.Cns}"))
					.SetTextAlignment(TextAlignment.LEFT)
					.SetFontSize(10));
				document.Add(tabelaMembro);

				var table = new iText.Layout.Element.Table(4).UseAllAvailableWidth();
				table.AddHeaderCell("Vacina");
				table.AddHeaderCell("Data de Aplicação");
				table.AddHeaderCell("Lote");
				table.AddHeaderCell("CNES");

				foreach (var detalhe in vacinasExibidas) {
					table.AddCell(detalhe.Vacina.Nome);
					table.AddCell(detalhe.DataAplicacao?.ToString("dd/MM/yyyy") ?? "");
					table.AddCell(detalhe.Lote ?? "");
					table.AddCell(detalhe.Cnes ?? "");
				}

				document.Add(table);

				document.Close();

				Response.Headers.Append("Content-Disposition", "inline; filename=CadernetaDeVacinaDigital.pdf");
				return File(stream.ToArray(), "application/pdf");
			}
		}
	}
}
