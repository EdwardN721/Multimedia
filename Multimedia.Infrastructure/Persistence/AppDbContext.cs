using Multimedia.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Multimedia.Domain.Models.Dominio;
using Multimedia.Domain.Models.Catalogo;

namespace Multimedia.Infrastructure.Persistence;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options) { }

    public DbSet<Artista> Artistas => Set<Artista>();
    public DbSet<Clasificacion> Clasificaciones => Set<Clasificacion>();
    public DbSet<Director> Directores => Set<Director>();
    public DbSet<Editorial> Editoriales => Set<Editorial>();
    public DbSet<EstadoContenido> EstadosContenido => Set<EstadoContenido>();
    public DbSet<Formato> Formatos => Set<Formato>();
    public DbSet<Genero> Generos => Set<Genero>();

    public DbSet<Plataforma> Plataformas => Set<Plataforma>();
    public DbSet<Idioma> Idiomas => Set<Idioma>();

    public DbSet<Rol> Roles => Set<Rol>();
    public DbSet<TipoContenido> TiposContenido => Set<TipoContenido>();

    public DbSet<Contenido> Contenidos => Set<Contenido>();
    public DbSet<Libro> Libros => Set<Libro>();

    public DbSet<Musica> Musicas => Set<Musica>();
    public DbSet<Pelicula> Peliculas => Set<Pelicula>();

    public DbSet<Videojuego> VideoJuegos => Set<Videojuego>();
    public DbSet<Usuario> Usuarios => Set<Usuario>();

    public DbSet<Biblioteca> Bibliotecas => Set<Biblioteca>();
    public DbSet<Auditoria> Auditorias => Set<Auditoria>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Esto busca automáticamente todas las clases que implementen IEntityTypeConfiguration en el proyecto
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
    }



}