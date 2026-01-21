using GestaoVacinas.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GestaoVacinas.Data;
public class AppDbContext : IdentityDbContext<Users> {
	public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {
	}
	public DbSet<Membros> Membros { get; set; }
	public DbSet<Vacina> Vacinas { get; set; }	
	public DbSet<DetalhesVacina> DetalhesVacinas { get; set; }
	public DbSet<Caderneta> Cadernetas { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder) {
		base.OnModelCreating(modelBuilder);

		modelBuilder.Entity<Caderneta>()
				.HasOne(c => c.Membro)
				.WithOne(m => m.Caderneta)
				.HasForeignKey<Caderneta>(c => c.MembroId);

		modelBuilder.Entity<DetalhesVacina>()
			.HasOne(d => d.Vacina)
			.WithMany(v => v.Detalhes)
			.HasForeignKey(d => d.VacinaId);

		modelBuilder.Entity<DetalhesVacina>()
			.HasOne(d => d.Caderneta)
			.WithMany(c => c.DetalhesVacinas)
			.HasForeignKey(d => d.CadernetaId);

        modelBuilder.Entity<Caderneta>()
            .HasMany(c => c.Vacinas)
            .WithMany(v => v.Cadernetas)
            .UsingEntity<Dictionary<string, object>>(
                "CadernetaVacina",
                j => j.HasOne<Vacina>().WithMany().HasForeignKey("VacinaId"),
                j => j.HasOne<Caderneta>().WithMany().HasForeignKey("CadernetaId"));

		modelBuilder.Entity<Membros>()
			.HasOne(m => m.Usuario)
			.WithMany()
			.HasForeignKey(m => m.UserId)
			.OnDelete(DeleteBehavior.Cascade);
	}
}