using ApiFinalPelisAWS.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiFinalPelisAWS.Data
{
    public class PeliculasContext : DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext> options) : base(options) { }
        public DbSet<Pelicula> Peliculas { get; set; }

    }

}
