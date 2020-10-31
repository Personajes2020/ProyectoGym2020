using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ProyectoFinal2020v2.Models
{
    public partial class GymContext : DbContext
    {
        public GymContext()
        {
        }

        public GymContext(DbContextOptions<GymContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actividad> Actividad { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<ClaseGuarderia> ClaseGuarderia { get; set; }
        public virtual DbSet<ClaseGuarderiaEmpleado> ClaseGuarderiaEmpleado { get; set; }
        public virtual DbSet<ClaseGym> ClaseGym { get; set; }
        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Casillero> Casillero { get; set; }
        public virtual DbSet<DetallesPedido> DetallesPedido { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Hijo> Hijo { get; set; }
        public virtual DbSet<HijoCliente> HijoCliente { get; set; }
        public virtual DbSet<MatriculaClaseGym> MatriculaClaseGym { get; set; }
        public virtual DbSet<MatriculaGuarderia> MatriculaGuarderia { get; set; }
        public virtual DbSet<Monedero> Monedero { get; set; }
        public virtual DbSet<MovimientoMonedero> MovimientoMonedero { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Proveedor> Proveedor { get; set; }
        public virtual DbSet<Sala> Sala { get; set; }
        public virtual DbSet<Tarifa> Tarifa { get; set; }
        public virtual DbSet<TipoMovimiento> TipoMovimiento { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
//                optionsBuilder.UseSqlServer("Server= LAPTOP-NCM6N6CV\\SQLEXPRESS; Database= Gym;Trusted_Connection=True;");
//            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actividad>(entity =>
            {
                entity.HasKey(e => e.IdActividad);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                //entity.Property(e => e.Duracion)
                //    .IsRequired()
                //    .HasMaxLength(25)
                //    .IsUnicode(false);
                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Categoria>(entity =>
            {
                entity.HasKey(e => e.IdCategoria);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaseGuarderia>(entity =>
            {
                entity.HasKey(e => e.IdClaseGuarderia);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.Property(e => e.HoraFin)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HoraInicio)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ClaseGuarderiaEmpleado>(entity =>
            {
                entity.HasKey(e => e.IdClaseGuarderiaEmpleado);

                entity.ToTable("ClaseGuarderia_Empleado");

                entity.Property(e => e.IdClaseGuarderiaEmpleado).HasColumnName("IdClaseGuarderia_Empleado");

                entity.HasOne(d => d.IdClaseGuarderiaNavigation)
                    .WithMany(p => p.ClaseGuarderiaEmpleado)
                    .HasForeignKey(d => d.IdClaseGuarderia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaseGuarderia_Empleado_ClaseGuarderia");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.ClaseGuarderiaEmpleado)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaseGuarderia_Empleado_Empleado");
            });

            modelBuilder.Entity<ClaseGym>(entity =>
            {
                entity.HasKey(e => e.IdClaseGym);

                entity.HasIndex(e => new { e.IdSala, e.HoraInicio, e.Fecha })
                    .HasName("Fk_ClaseGym")
                    .IsUnique();

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
                //entity.Property(e => e.IdClaseGym).ValueGeneratedNever();

                entity.Property(e => e.Fecha).HasColumnType("date");

                //entity.Property(e => e.IdSala).ValueGeneratedOnAdd();

                entity.Property(e => e.HoraFinal)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.HoraInicio)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdActividadNavigation)
                    .WithMany(p => p.ClaseGym)
                    .HasForeignKey(d => d.IdActividad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaseGym_Actividad1");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                   .WithMany(p => p.ClaseGym)
                   .HasForeignKey(d => d.IdEmpleado)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_ClaseGym_Empleado");

                entity.HasOne(d => d.IdSalaNavigation)
                    .WithMany(p => p.ClaseGym)
                    .HasForeignKey(d => d.IdSala)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ClaseGym_Sala");
            });

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.IdCliente)
                    .HasName("PK_tblCliente");

                entity.HasIndex(e => e.Identificacion)
                    .HasName("Fk_Identificacion")
                    .IsUnique();

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FechaNac)
                    .HasColumnName("Fecha_Nac")
                    .HasColumnType("datetime")
                    .IsUnicode(false); ;

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(15)
                    .IsUnicode(false);
                entity.HasOne(d => d.IdCasilleroNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdCasillero)
                    .HasConstraintName("FK_Cliente_Casillero");

                entity.HasOne(d => d.IdTarifaNavigation)
                    .WithMany(p => p.Cliente)
                    .HasForeignKey(d => d.IdTarifa)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Cliente_Tarifa");
            });
            modelBuilder.Entity<Casillero>(entity =>
            {
                entity.HasKey(e => e.IdCasillero);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DetallesPedido>(entity =>
            {
                entity.HasKey(e => e.IdDetalles);

                entity.HasOne(d => d.IdPedidoNavigation)
                    .WithMany(p => p.DetallesPedido)
                    .HasForeignKey(d => d.IdPedido)
                    .HasConstraintName("FK_DetallesPedido_Pedido1");
            });

            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado)
                    .HasName("PK_tblEmpleado");

                entity.HasIndex(e => new { e.Nombre, e.Apellido1, e.Apellido2 })
                    .HasName("fk_Empleado")
                    .IsUnique();

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();

                entity.Property(e => e.Ccss)
                    .HasColumnName("CCSS")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaContrato).HasColumnType("date");

                entity.Property(e => e.FechaNac)
                    .HasColumnName("Fecha_Nac")
                    .HasColumnType("datetime");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.NumeroBancario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroSocial)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Profesion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsFixedLength();

                entity.Property(e => e.TipoDeEmp)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Hijo>(entity =>
            {
                entity.HasKey(e => e.IdHijo);

                entity.Property(e => e.Apellido1)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Apellido2)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaDeNac).HasColumnType("date");

                entity.Property(e => e.Identificacion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<HijoCliente>(entity =>
            {
                entity.HasKey(e => e.IdHijoCliente);

                entity.ToTable("Hijo_Cliente");

                entity.Property(e => e.IdHijoCliente).HasColumnName("IdHijo_Cliente");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.HijoCliente)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hijo_Cliente_Cliente");

                entity.HasOne(d => d.IdHijoNavigation)
                    .WithMany(p => p.HijoCliente)
                    .HasForeignKey(d => d.IdHijo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Hijo_Cliente_Hijo");
            });

            modelBuilder.Entity<MatriculaClaseGym>(entity =>
            {
                entity.HasKey(e => e.IdMatriculaGym)
                    .HasName("PK_MatriculaGym");

                entity.Property(e => e.Fecha).HasColumnType("datetime");

                entity.HasOne(d => d.IdClaseGymNavigation)
                    .WithMany(p => p.MatriculaClaseGym)
                    .HasForeignKey(d => d.IdClaseGym)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatriculaClaseGym_ClaseGym1");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.MatriculaClaseGym)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatriculaClaseGym_Cliente");
            });

            modelBuilder.Entity<MatriculaGuarderia>(entity =>
            {
                entity.HasKey(e => e.IdMatricula);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.IdClaseGuarderiaNavigation)
                    .WithMany(p => p.MatriculaGuarderia)
                    .HasForeignKey(d => d.IdClaseGuarderia)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatriculaGuarderia_ClaseGuarderia1");

                entity.HasOne(d => d.IdHijoNavigation)
                    .WithMany(p => p.MatriculaGuarderia)
                    .HasForeignKey(d => d.IdHijo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MatriculaGuarderia_Hijo");
        });

            modelBuilder.Entity<Monedero>(entity =>
            {
                entity.HasKey(e => e.IdMonedero);

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Monedero)
                    .HasForeignKey(d => d.IdCliente)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Monedero_Cliente");
            });

            modelBuilder.Entity<MovimientoMonedero>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.IdMonederoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdMonedero)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovimientoMonedero_Monedero");

                entity.HasOne(d => d.IdTipoMovimientoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.IdTipoMovimiento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MovimientoMonedero_TipoMovimiento");
            });

            modelBuilder.Entity<Pedido>(entity =>
            {
                entity.HasKey(e => e.IdPedido);

                entity.Property(e => e.Descripcion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCompra).HasColumnType("datetime");

                entity.Property(e => e.Importe).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioUnidad).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdProductoNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdProducto)
                    .HasConstraintName("FK_Pedido_Producto1");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Pedido)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pedido_Proveedor1");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.IdProducto);

                entity.Property(e => e.IdProducto).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Existencia)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCadu).HasColumnType("date");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PrecioUnidad)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.HasOne(d => d.IdCategoriaNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdCategoria)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Categoria1");

                entity.HasOne(d => d.IdProveedorNavigation)
                    .WithMany(p => p.Producto)
                    .HasForeignKey(d => d.IdProveedor)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Producto_Proveedor");
            });

            modelBuilder.Entity<Proveedor>(entity =>
            {
                entity.HasKey(e => e.IdProveedor);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProducto)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NombreRepresentante)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sala>(entity =>
            {
                entity.HasKey(e => e.IdSala);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.NombreSala)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Tarifa>(entity =>
            {
                entity.HasKey(e => e.IdTarifa);

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Duracion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoMovimiento>(entity =>
            {
                entity.HasKey(e => e.IdTipoMovimiento);

                entity.Property(e => e.IdTipoMovimiento).ValueGeneratedNever();

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });
            modelBuilder.Entity<Roles>(entity =>
            {
                entity.HasKey(e => e.IdRole);

                entity.Property(e => e.IdRole).ValueGeneratedNever();

                entity.Property(e => e.NombreRole)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.Property(e => e.ConfirmarContraseña)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contraseña)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaCreacion).HasColumnType("datetime");

                entity.Property(e => e.NombreUsuario)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
