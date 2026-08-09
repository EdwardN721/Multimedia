using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Multimedia.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Multimedia");

            migrationBuilder.CreateTable(
                name: "Artistas",
                schema: "Multimedia",
                columns: table => new
                {
                    ArtistaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artistas", x => x.ArtistaId);
                });

            migrationBuilder.CreateTable(
                name: "Auditorias",
                columns: table => new
                {
                    AuditoriaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tabla = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Operacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UsuarioDb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaHora = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValorAnterior = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValorNuevo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditorias", x => x.AuditoriaId);
                });

            migrationBuilder.CreateTable(
                name: "Clasificacion",
                schema: "Multimedia",
                columns: table => new
                {
                    ClasificacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clasificacion", x => x.ClasificacionId);
                });

            migrationBuilder.CreateTable(
                name: "Directores",
                schema: "Multimedia",
                columns: table => new
                {
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PrimerApellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SegundoApellido = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true, defaultValue: "")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Directores", x => x.DirectorId);
                });

            migrationBuilder.CreateTable(
                name: "Editoriales",
                schema: "Multimedia",
                columns: table => new
                {
                    EditorialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Editoriales", x => x.EditorialId);
                });

            migrationBuilder.CreateTable(
                name: "EstadoContenido",
                schema: "Multimedia",
                columns: table => new
                {
                    EstadoContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoContenido", x => x.EstadoContenidoId);
                });

            migrationBuilder.CreateTable(
                name: "Formatos",
                schema: "Multimedia",
                columns: table => new
                {
                    FormatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formatos", x => x.FormatoId);
                });

            migrationBuilder.CreateTable(
                name: "Generos",
                schema: "Multimedia",
                columns: table => new
                {
                    GeneroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Generos", x => x.GeneroId);
                });

            migrationBuilder.CreateTable(
                name: "Plataformas",
                schema: "Multimedia",
                columns: table => new
                {
                    PlataformaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plataformas", x => x.PlataformaId);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                schema: "Multimedia",
                columns: table => new
                {
                    RolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Descripcion = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rol", x => x.RolId);
                });

            migrationBuilder.CreateTable(
                name: "TiposContenidos",
                schema: "Multimedia",
                columns: table => new
                {
                    TipoContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiposContenidos", x => x.TipoContenidoId);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                schema: "Multimedia",
                columns: table => new
                {
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    Nombre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Apellidos = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Correo = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(256)", maxLength: 256, nullable: false),
                    RolId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.UsuarioId);
                    table.ForeignKey(
                        name: "FK_Usuario_Rol_RolId",
                        column: x => x.RolId,
                        principalSchema: "Multimedia",
                        principalTable: "Rol",
                        principalColumn: "RolId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Biblioteca",
                schema: "Multimedia",
                columns: table => new
                {
                    BibliotecaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    UsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FechaAgregado = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    EsFavorito = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Observaciones = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Biblioteca", x => x.BibliotecaId);
                    table.ForeignKey(
                        name: "FK_Biblioteca_Usuario_UsuarioId",
                        column: x => x.UsuarioId,
                        principalSchema: "Multimedia",
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Contenido",
                schema: "Multimedia",
                columns: table => new
                {
                    ContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    TipoContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Titulo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Anio = table.Column<int>(type: "int", nullable: false),
                    FechaLanzamiento = table.Column<DateOnly>(type: "date", nullable: true),
                    GeneroId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdiomaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClasificacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FormatoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Portada = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    EstadoContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreadoPorUsuarioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsuarioActualizacionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    FechaCreacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    FechaModificacion = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contenido", x => x.ContenidoId);
                    table.CheckConstraint("CK_Contenido_Anio", "[Anio] >= 1800 AND [Anio] <= YEAR(SYSDATETIME()) + 5");
                    table.ForeignKey(
                        name: "FK_Contenido_Clasificacion_ClasificacionId",
                        column: x => x.ClasificacionId,
                        principalSchema: "Multimedia",
                        principalTable: "Clasificacion",
                        principalColumn: "ClasificacionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contenido_EstadoContenido_EstadoContenidoId",
                        column: x => x.EstadoContenidoId,
                        principalSchema: "Multimedia",
                        principalTable: "EstadoContenido",
                        principalColumn: "EstadoContenidoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contenido_Formatos_FormatoId",
                        column: x => x.FormatoId,
                        principalSchema: "Multimedia",
                        principalTable: "Formatos",
                        principalColumn: "FormatoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contenido_Generos_GeneroId",
                        column: x => x.GeneroId,
                        principalSchema: "Multimedia",
                        principalTable: "Generos",
                        principalColumn: "GeneroId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contenido_TiposContenidos_TipoContenidoId",
                        column: x => x.TipoContenidoId,
                        principalSchema: "Multimedia",
                        principalTable: "TiposContenidos",
                        principalColumn: "TipoContenidoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contenido_Usuario_CreadoPorUsuarioId",
                        column: x => x.CreadoPorUsuarioId,
                        principalSchema: "Multimedia",
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Contenido_Usuario_UsuarioActualizacionId",
                        column: x => x.UsuarioActualizacionId,
                        principalSchema: "Multimedia",
                        principalTable: "Usuario",
                        principalColumn: "UsuarioId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Libro",
                schema: "Multimedia",
                columns: table => new
                {
                    ContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    ISBN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EditorialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumeroPaginas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Libro", x => x.ContenidoId);
                    table.ForeignKey(
                        name: "FK_Libro_Contenido_ContenidoId",
                        column: x => x.ContenidoId,
                        principalSchema: "Multimedia",
                        principalTable: "Contenido",
                        principalColumn: "ContenidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Libro_Editoriales_EditorialId",
                        column: x => x.EditorialId,
                        principalSchema: "Multimedia",
                        principalTable: "Editoriales",
                        principalColumn: "EditorialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Musica",
                schema: "Multimedia",
                columns: table => new
                {
                    ContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    ArtistaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Album = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    DuracionMinutos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Musica", x => x.ContenidoId);
                    table.CheckConstraint("CK_Musica_Duracion", "\"DuracionMinutos\" > 0");
                    table.ForeignKey(
                        name: "FK_Musica_Artistas_ArtistaId",
                        column: x => x.ArtistaId,
                        principalSchema: "Multimedia",
                        principalTable: "Artistas",
                        principalColumn: "ArtistaId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Musica_Contenido_ContenidoId",
                        column: x => x.ContenidoId,
                        principalSchema: "Multimedia",
                        principalTable: "Contenido",
                        principalColumn: "ContenidoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Peliculas",
                schema: "Multimedia",
                columns: table => new
                {
                    ContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    DirectorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DuracionMinutos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peliculas", x => x.ContenidoId);
                    table.ForeignKey(
                        name: "FK_Peliculas_Contenido_ContenidoId",
                        column: x => x.ContenidoId,
                        principalSchema: "Multimedia",
                        principalTable: "Contenido",
                        principalColumn: "ContenidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Peliculas_Directores_DirectorId",
                        column: x => x.DirectorId,
                        principalSchema: "Multimedia",
                        principalTable: "Directores",
                        principalColumn: "DirectorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VideoJuegos",
                schema: "Multimedia",
                columns: table => new
                {
                    ContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    PlataformaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EsMultijugador = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VideoJuegos", x => x.ContenidoId);
                    table.ForeignKey(
                        name: "FK_VideoJuegos_Contenido_ContenidoId",
                        column: x => x.ContenidoId,
                        principalSchema: "Multimedia",
                        principalTable: "Contenido",
                        principalColumn: "ContenidoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VideoJuegos_Plataformas_PlataformaId",
                        column: x => x.PlataformaId,
                        principalSchema: "Multimedia",
                        principalTable: "Plataformas",
                        principalColumn: "PlataformaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Idiomas",
                schema: "Multimedia",
                columns: table => new
                {
                    IdiomaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "NEWSEQUENTIALID()"),
                    CodigoIso = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PeliculaContenidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Nombre = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EsActivo = table.Column<bool>(type: "bit", nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Idiomas", x => x.IdiomaId);
                    table.ForeignKey(
                        name: "FK_Idiomas_Peliculas_PeliculaContenidoId",
                        column: x => x.PeliculaContenidoId,
                        principalSchema: "Multimedia",
                        principalTable: "Peliculas",
                        principalColumn: "ContenidoId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Biblioteca_ContenidoId",
                schema: "Multimedia",
                table: "Biblioteca",
                column: "ContenidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Biblioteca_UsuarioId_ContenidoId",
                schema: "Multimedia",
                table: "Biblioteca",
                columns: new[] { "UsuarioId", "ContenidoId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clasificacion_Nombre",
                schema: "Multimedia",
                table: "Clasificacion",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_ClasificacionId",
                schema: "Multimedia",
                table: "Contenido",
                column: "ClasificacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_CreadoPorUsuarioId",
                schema: "Multimedia",
                table: "Contenido",
                column: "CreadoPorUsuarioId");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_EstadoContenidoId",
                schema: "Multimedia",
                table: "Contenido",
                column: "EstadoContenidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_FormatoId",
                schema: "Multimedia",
                table: "Contenido",
                column: "FormatoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_GeneroId",
                schema: "Multimedia",
                table: "Contenido",
                column: "GeneroId");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_IdiomaId",
                schema: "Multimedia",
                table: "Contenido",
                column: "IdiomaId");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_TipoContenidoId",
                schema: "Multimedia",
                table: "Contenido",
                column: "TipoContenidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_Titulo",
                schema: "Multimedia",
                table: "Contenido",
                column: "Titulo");

            migrationBuilder.CreateIndex(
                name: "IX_Contenido_UsuarioActualizacionId",
                schema: "Multimedia",
                table: "Contenido",
                column: "UsuarioActualizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_EstadoContenido_Nombre",
                schema: "Multimedia",
                table: "EstadoContenido",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Idiomas_PeliculaContenidoId",
                schema: "Multimedia",
                table: "Idiomas",
                column: "PeliculaContenidoId");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_EditorialId",
                schema: "Multimedia",
                table: "Libro",
                column: "EditorialId");

            migrationBuilder.CreateIndex(
                name: "IX_Libro_ISBN",
                schema: "Multimedia",
                table: "Libro",
                column: "ISBN",
                unique: true,
                filter: "[ISBN] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Musica_ArtistaId",
                schema: "Multimedia",
                table: "Musica",
                column: "ArtistaId");

            migrationBuilder.CreateIndex(
                name: "IX_Peliculas_DirectorId",
                schema: "Multimedia",
                table: "Peliculas",
                column: "DirectorId");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_Nombre",
                schema: "Multimedia",
                table: "Rol",
                column: "Nombre",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Correo",
                schema: "Multimedia",
                table: "Usuario",
                column: "Correo",
                unique: true)
                .Annotation("SqlServer:Include", new[] { "PasswordHash", "RolId", "EsActivo" });

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_RolId",
                schema: "Multimedia",
                table: "Usuario",
                column: "RolId");

            migrationBuilder.CreateIndex(
                name: "IX_VideoJuegos_PlataformaId",
                schema: "Multimedia",
                table: "VideoJuegos",
                column: "PlataformaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Biblioteca_Contenido_ContenidoId",
                schema: "Multimedia",
                table: "Biblioteca",
                column: "ContenidoId",
                principalSchema: "Multimedia",
                principalTable: "Contenido",
                principalColumn: "ContenidoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Contenido_Idiomas_IdiomaId",
                schema: "Multimedia",
                table: "Contenido",
                column: "IdiomaId",
                principalSchema: "Multimedia",
                principalTable: "Idiomas",
                principalColumn: "IdiomaId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peliculas_Contenido_ContenidoId",
                schema: "Multimedia",
                table: "Peliculas");

            migrationBuilder.DropTable(
                name: "Auditorias");

            migrationBuilder.DropTable(
                name: "Biblioteca",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Libro",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Musica",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "VideoJuegos",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Editoriales",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Artistas",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Plataformas",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Contenido",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Clasificacion",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "EstadoContenido",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Formatos",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Generos",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Idiomas",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "TiposContenidos",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Usuario",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Peliculas",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Rol",
                schema: "Multimedia");

            migrationBuilder.DropTable(
                name: "Directores",
                schema: "Multimedia");
        }
    }
}
