using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class DbContextBiblioteca : DbContext
    {
        public DbContextBiblioteca() : base (new DbContextOptionsBuilder<DbContextBiblioteca>().UseOracle(Configuracion.StringConexion).Options)
        {
            
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Pantalla> Pantallas { get; set; }
        public DbSet<Sistema> Sistemas {  get; set; }
        public DbSet<PermisoUsuario> PermisosUsuarios {  get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<UsuarioRol> UsuarioRoles { get; set; }
        public DbSet<PermisoRol> PermisosRoles { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Configurar llave compuesta para permisosUsuario
            modelBuilder.Entity<PermisoUsuario>()
            .HasKey(x => new { x.IdUsuario, x.IdPantalla });

            //Configurar llave compuesta para UsuarioRol
            modelBuilder.Entity<UsuarioRol>()
           .HasKey(x => new { x.IdUsuario, x.IdRol });

            //Llaves foraneas para Permisos_Usuario
            modelBuilder.Entity<PermisoUsuario>()
                .HasOne(up => up.Usuario)
                .WithMany(u => u.PermisoUsuarios)
                .HasForeignKey(up=>up.IdUsuario);

            modelBuilder.Entity<PermisoUsuario>()
               .HasOne(up => up.Pantalla)
               .WithMany(p => p.PermisoUsuarios)
               .HasForeignKey(up => up.IdPantalla);

            //Llaves foraneas para Usuario_Rol
            modelBuilder.Entity<UsuarioRol>()
                .HasOne(up => up.Usuario)
                .WithMany(u => u.UsuarioRoles)
                .HasForeignKey(up => up.IdUsuario);

            modelBuilder.Entity<UsuarioRol>()
                .HasOne(up => up.Rol)
                .WithMany(u => u.UsuarioRol)
                .HasForeignKey(up => up.IdRol);

            //Llaves foraneas para Pantallas
            modelBuilder.Entity<Pantalla>()
               .HasOne(p => p.Sistema)
               .WithMany(s => s.Pantallas)
               .HasForeignKey(p => p.IdSistema);

            //Llave foranea permisos rol
            modelBuilder.Entity<PermisoRol>()
               .HasOne(up => up.Pantalla)
               .WithMany(p => p.PermisosRol)
               .HasForeignKey(up => up.IdPantalla);

            modelBuilder.Entity<PermisoRol>()
               .HasOne(up => up.Rol)
               .WithMany(p => p.PermisosRol)
               .HasForeignKey(up => up.IdRol);

            modelBuilder.Entity<PermisoRol>()
            .HasKey(x => new { x.IdRol, x.IdPantalla });

        }


    }
}
