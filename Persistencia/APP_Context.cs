using Dominio;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace Persistencia
{
    public class APP_Context : DbContext
    {
        public APP_Context(DbContextOptions options) 
        base(options)
        {

        }

        public DbSet<EJERCIOS> ejercisio {get; set;}

        public DbSet<ESCUELA> escuela {get; set;}

        public DbSet<ESTADO> estado {get; set;}

        public DbSet<MATERIA> materia {get; set;}

        public DbSet<MUNICIPIO> municipio {get; set;} 

        public DbSet<PAIS> pais {get; set;}

        public DbSet<RESPUESTA> respuesta {get; set;}

        public DbSet<RESPUESTA_ALUMNOS> respuesta_alumnos {get; set;}

        public DbSet<ROLES> roles {get; set;}

        public DbSet<TEMAS> temas {get; set;}

        public DbSet<USUARIOS> usuarios {get; set;}
    }
}