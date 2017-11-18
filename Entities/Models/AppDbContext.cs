using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace project2.Entities.Models
{
    public partial class AppDbContext : DbContext
    {
        public virtual DbSet<Ivertinimai> Ivertinimai { get; set; }
        public virtual DbSet<Komentarai> Komentarai { get; set; }
        public virtual DbSet<KomentaroBusenos> KomentaroBusenos { get; set; }
        public virtual DbSet<KrepselioPrekes> KrepselioPrekes { get; set; }
        public virtual DbSet<Mokejimai> Mokejimai { get; set; }
        public virtual DbSet<MokejimoBusenos> MokejimoBusenos { get; set; }
        public virtual DbSet<Preke> Preke { get; set; }
        public virtual DbSet<PrekesAprasymoLaukai> PrekesAprasymoLaukai { get; set; }
        public virtual DbSet<PrekesBusenos> PrekesBusenos { get; set; }
        public virtual DbSet<PrekesTipai> PrekesTipai { get; set; }
        public virtual DbSet<Statymai> Statymai { get; set; }
        public virtual DbSet<StatymoBusenos> StatymoBusenos { get; set; }
        public virtual DbSet<StebimosPrekes> StebimosPrekes { get; set; }
        public virtual DbSet<Uzsakymai> Uzsakymai { get; set; }
        public virtual DbSet<UzsakymoBusenos> UzsakymoBusenos { get; set; }
        public virtual DbSet<UzsakymoPrekes> UzsakymoPrekes { get; set; }
        public virtual DbSet<Vartotojai> Vartotojai { get; set; }
        public virtual DbSet<VartotojoTipai> VartotojoTipai { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-8BFF2FV\SQLEXPRESS;Initial Catalog=is_projektas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ivertinimai>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aprasymas)
                    .IsRequired()
                    .HasColumnName("aprasymas")
                    .HasColumnType("text");

                entity.Property(e => e.Balas).HasColumnName("balas");

                entity.Property(e => e.FkPirkejas).HasColumnName("fk_pirkejas");

                entity.Property(e => e.FkTiekejas).HasColumnName("fk_tiekejas");

                entity.Property(e => e.Pavadinimas)
                    .IsRequired()
                    .HasColumnName("pavadinimas")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkPirkejasNavigation)
                    .WithMany(p => p.IvertinimaiFkPirkejasNavigation)
                    .HasForeignKey(d => d.FkPirkejas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ivertinim__fk_pi__47DBAE45");

                entity.HasOne(d => d.FkTiekejasNavigation)
                    .WithMany(p => p.IvertinimaiFkTiekejasNavigation)
                    .HasForeignKey(d => d.FkTiekejas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ivertinim__fk_ti__48CFD27E");
            });

            modelBuilder.Entity<Komentarai>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Busena).HasColumnName("busena");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkPreke).HasColumnName("fk_preke");

                entity.Property(e => e.FkVartotojas).HasColumnName("fk_vartotojas");

                entity.Property(e => e.Pavadinimas)
                    .IsRequired()
                    .HasColumnName("pavadinimas")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tekstas)
                    .IsRequired()
                    .HasColumnName("tekstas")
                    .HasColumnType("text");

                entity.HasOne(d => d.BusenaNavigation)
                    .WithMany(p => p.Komentarai)
                    .HasForeignKey(d => d.Busena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Komentara__busen__5441852A");

                entity.HasOne(d => d.FkPrekeNavigation)
                    .WithMany(p => p.Komentarai)
                    .HasForeignKey(d => d.FkPreke)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Komentara__fk_pr__5629CD9C");

                entity.HasOne(d => d.FkVartotojasNavigation)
                    .WithMany(p => p.Komentarai)
                    .HasForeignKey(d => d.FkVartotojas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Komentara__fk_va__5535A963");
            });

            modelBuilder.Entity<KomentaroBusenos>(entity =>
            {
                entity.ToTable("Komentaro_busenos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<KrepselioPrekes>(entity =>
            {
                entity.ToTable("Krepselio_prekes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FkPirkejas).HasColumnName("fk_pirkejas");

                entity.Property(e => e.FkPreke).HasColumnName("fk_preke");

                entity.Property(e => e.IkelimoData)
                    .HasColumnName("ikelimo_data")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.FkPirkejasNavigation)
                    .WithMany(p => p.KrepselioPrekes)
                    .HasForeignKey(d => d.FkPirkejas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Krepselio__fk_pi__656C112C");

                entity.HasOne(d => d.FkPrekeNavigation)
                    .WithMany(p => p.KrepselioPrekes)
                    .HasForeignKey(d => d.FkPreke)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Krepselio__fk_pr__66603565");
            });

            modelBuilder.Entity<Mokejimai>(entity =>
            {
                entity.HasIndex(e => e.FkUzsakymas)
                    .HasName("UQ__Mokejima__A4D84B9F0267F94B")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Busena).HasColumnName("busena");

                entity.Property(e => e.Data)
                    .HasColumnName("data")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkUzsakymas).HasColumnName("fk_uzsakymas");

                entity.HasOne(d => d.BusenaNavigation)
                    .WithMany(p => p.Mokejimai)
                    .HasForeignKey(d => d.Busena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mokejimai__busen__6A30C649");

                entity.HasOne(d => d.FkUzsakymasNavigation)
                    .WithOne(p => p.Mokejimai)
                    .HasForeignKey<Mokejimai>(d => d.FkUzsakymas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Mokejimai__fk_uz__6B24EA82");
            });

            modelBuilder.Entity<MokejimoBusenos>(entity =>
            {
                entity.ToTable("Mokejimo_busenos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Preke>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Busena).HasColumnName("busena");

                entity.Property(e => e.FkTiekejas).HasColumnName("fk_tiekejas");

                entity.Property(e => e.IkelimoData)
                    .HasColumnName("ikelimo_data")
                    .HasColumnType("date");

                entity.Property(e => e.Kaina)
                    .HasColumnName("kaina")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nuolaida).HasColumnName("nuolaida");

                entity.Property(e => e.Nuotrauka)
                    .IsRequired()
                    .HasColumnName("nuotrauka")
                    .HasColumnType("text");

                entity.Property(e => e.Pavadinimas)
                    .IsRequired()
                    .HasColumnName("pavadinimas")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Tipas).HasColumnName("tipas");

                entity.HasOne(d => d.BusenaNavigation)
                    .WithMany(p => p.Preke)
                    .HasForeignKey(d => d.Busena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Preke__busena__4CA06362");

                entity.HasOne(d => d.FkTiekejasNavigation)
                    .WithMany(p => p.Preke)
                    .HasForeignKey(d => d.FkTiekejas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Preke__fk_tiekej__4D94879B");

                entity.HasOne(d => d.TipasNavigation)
                    .WithMany(p => p.Preke)
                    .HasForeignKey(d => d.Tipas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Preke__tipas__4BAC3F29");
            });

            modelBuilder.Entity<PrekesAprasymoLaukai>(entity =>
            {
                entity.ToTable("Prekes_aprasymo_laukai");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Aprasymas)
                    .IsRequired()
                    .HasColumnName("aprasymas")
                    .HasColumnType("text");

                entity.Property(e => e.FkPreke).HasColumnName("fk_preke");

                entity.Property(e => e.Laukas)
                    .IsRequired()
                    .HasColumnName("laukas")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkPrekeNavigation)
                    .WithMany(p => p.PrekesAprasymoLaukai)
                    .HasForeignKey(d => d.FkPreke)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Prekes_ap__fk_pr__6E01572D");
            });

            modelBuilder.Entity<PrekesBusenos>(entity =>
            {
                entity.ToTable("Prekes_busenos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PrekesTipai>(entity =>
            {
                entity.ToTable("Prekes_tipai");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Statymai>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Busena).HasColumnName("busena");

                entity.Property(e => e.FkPirkejasid).HasColumnName("fk_Pirkejasid");

                entity.Property(e => e.FkPrekeid).HasColumnName("fk_Prekeid");

                entity.Property(e => e.StatymoData)
                    .HasColumnName("statymo_data")
                    .HasColumnType("datetime");

                entity.Property(e => e.Suma)
                    .HasColumnName("suma")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UzdarymoData)
                    .HasColumnName("uzdarymo_data")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.BusenaNavigation)
                    .WithMany(p => p.Statymai)
                    .HasForeignKey(d => d.Busena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Statymai__busena__59063A47");

                entity.HasOne(d => d.FkPirkejas)
                    .WithMany(p => p.Statymai)
                    .HasForeignKey(d => d.FkPirkejasid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Statymai__fk_Pir__59FA5E80");

                entity.HasOne(d => d.FkPreke)
                    .WithMany(p => p.Statymai)
                    .HasForeignKey(d => d.FkPrekeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Statymai__fk_Pre__5AEE82B9");
            });

            modelBuilder.Entity<StatymoBusenos>(entity =>
            {
                entity.ToTable("Statymo_busenos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StebimosPrekes>(entity =>
            {
                entity.ToTable("Stebimos_prekes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FkPreke).HasColumnName("fk_preke");

                entity.Property(e => e.FkPrikejas).HasColumnName("fk_prikejas");

                entity.Property(e => e.IkelimoData)
                    .HasColumnName("ikelimo_data")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.FkPrekeNavigation)
                    .WithMany(p => p.StebimosPrekes)
                    .HasForeignKey(d => d.FkPreke)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Stebimos___fk_pr__5EBF139D");

                entity.HasOne(d => d.FkPrikejasNavigation)
                    .WithMany(p => p.StebimosPrekes)
                    .HasForeignKey(d => d.FkPrikejas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Stebimos___fk_pr__5DCAEF64");
            });

            modelBuilder.Entity<Uzsakymai>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Busena).HasColumnName("busena");

                entity.Property(e => e.FkPirkejas).HasColumnName("fk_pirkejas");

                entity.Property(e => e.Kaina)
                    .HasColumnName("kaina")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.PateikimoData)
                    .HasColumnName("pateikimo_data")
                    .HasColumnType("datetime");

                entity.Property(e => e.UzdarymoData)
                    .HasColumnName("uzdarymo_data")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.BusenaNavigation)
                    .WithMany(p => p.Uzsakymai)
                    .HasForeignKey(d => d.Busena)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Uzsakymai__busen__5070F446");

                entity.HasOne(d => d.FkPirkejasNavigation)
                    .WithMany(p => p.Uzsakymai)
                    .HasForeignKey(d => d.FkPirkejas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Uzsakymai__fk_pi__5165187F");
            });

            modelBuilder.Entity<UzsakymoBusenos>(entity =>
            {
                entity.ToTable("Uzsakymo_busenos");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UzsakymoPrekes>(entity =>
            {
                entity.ToTable("Uzsakymo_prekes");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.FkPreke).HasColumnName("fk_preke");

                entity.Property(e => e.FkUzsakymas).HasColumnName("fk_uzsakymas");

                entity.HasOne(d => d.FkPrekeNavigation)
                    .WithMany(p => p.UzsakymoPrekes)
                    .HasForeignKey(d => d.FkPreke)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Uzsakymo___fk_pr__619B8048");

                entity.HasOne(d => d.FkUzsakymasNavigation)
                    .WithMany(p => p.UzsakymoPrekes)
                    .HasForeignKey(d => d.FkUzsakymas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Uzsakymo___fk_uz__628FA481");
            });

            modelBuilder.Entity<Vartotojai>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Adresas)
                    .HasColumnName("adresas")
                    .HasColumnType("text");

                entity.Property(e => e.ArAktyvus).HasColumnName("ar_aktyvus");

                entity.Property(e => e.ElPastas)
                    .IsRequired()
                    .HasColumnName("el_pastas")
                    .HasColumnType("text");

                entity.Property(e => e.Pavarde)
                    .IsRequired()
                    .HasColumnName("pavarde")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Slaptazodis)
                    .IsRequired()
                    .HasColumnName("slaptazodis")
                    .HasColumnType("text");

                entity.Property(e => e.SukurimoData)
                    .HasColumnName("sukurimo_data")
                    .HasColumnType("datetime");

                entity.Property(e => e.Telefonas)
                    .HasColumnName("telefonas")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Tipas).HasColumnName("tipas");

                entity.Property(e => e.Vardas)
                    .IsRequired()
                    .HasColumnName("vardas")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.TipasNavigation)
                    .WithMany(p => p.Vartotojai)
                    .HasForeignKey(d => d.Tipas)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Vartotoja__tipas__44FF419A");
            });

            modelBuilder.Entity<VartotojoTipai>(entity =>
            {
                entity.ToTable("Vartotojo_tipai");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
