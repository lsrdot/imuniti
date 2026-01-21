using GestaoVacinas.Data;
using GestaoVacinas.Models;
using GestaoVacinas.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace GestaoVacinas.Controllers
{
    public class MembrosController : Controller
    {
        private readonly AppDbContext context;

        public MembrosController(AppDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public  IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddMembrosViewModel model)
        {
	        if (!ModelState.IsValid) 
	        {
		        return View(model);  
	        }
	        
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

			var membro = new Membros
            {
                Apelido = model.Apelido,
                NomeCompleto = model.NomeCompleto,
                DataNascimento = model.DataNascimento,
                Cpf = model.Cpf,
                Cns = model.Cns,
				UserId = userId
			};


            await context.Membros.AddAsync(membro);
            await context.SaveChangesAsync();

            var caderneta = new Caderneta {
                MembroId = membro.Id
            };

            await context.Cadernetas.AddAsync(caderneta);
            await context.SaveChangesAsync();

            var vacinasPadrao = await context.Vacinas
                .Where(v => v.IsVacinaPadrao)
              .ToListAsync();

            var detalhesVacinas = vacinasPadrao.Select(vacina =>
            {
                var detalheVacina = new DetalhesVacina {
                    CadernetaId = caderneta.Id,
                    VacinaId = vacina.Id
                };

                if (membro.DataNascimento.HasValue) {
                    var dataNascimento = membro.DataNascimento.Value;

                    if (vacina.IsVacinaPadrao && vacina.IdadeEmMeses.HasValue) {
                        detalheVacina.DataRecomendada = dataNascimento.AddMonths(vacina.IdadeEmMeses.Value);
                    }
                };

                return detalheVacina;
            }).ToList();

            await context.DetalhesVacinas.AddRangeAsync(detalhesVacinas);

            await context.SaveChangesAsync();

            return RedirectToAction("List");

			//return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
			
            if (!User.Identity.IsAuthenticated) {
				Console.WriteLine("Usuário não autenticado.");
				return RedirectToAction("Login", "Account");
			}

			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			Console.WriteLine($"User ID logado: {userId}");

			var membros = await context.Membros
				.Where(m => m.UserId == userId)
				.ToListAsync();

			return View(membros);
		}

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var membro = await context.Membros
				.Where(m => m.Id == id && m.UserId == userId)
				.FirstOrDefaultAsync();

			if (membro is null) {
				return NotFound();
			}

			return View(membro);

		}

        [HttpPost]
        public async Task<IActionResult> Edit(Membros viewModel)
        {
            var membro = await context.Membros.FindAsync(viewModel.Id);
            if (membro is not null)
            {
                membro.Apelido = viewModel.Apelido;
                membro.NomeCompleto = viewModel.NomeCompleto;
                membro.Cpf = viewModel.Cpf;
                membro.Cns = viewModel.Cns;

                await context.SaveChangesAsync();

                var caderneta = await context.Cadernetas
                    .FirstOrDefaultAsync(c => c.MembroId == membro.Id);

                if (caderneta != null) {
                    return RedirectToAction("Details", "Cadernetas", new { id = caderneta.Id });
                }
            }

            return RedirectToAction("List", "Membros");

        }

        public async Task<IActionResult> Delete(Membros viewModel)
        {
			var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
			var membro = await context.Membros
				.Where(m => m.Id == viewModel.Id && m.UserId == userId)
		        .FirstOrDefaultAsync();

			if (membro is not null) {
				context.Membros.Remove(membro);
				await context.SaveChangesAsync();
			}

			return RedirectToAction("List");
		}

    }
}
