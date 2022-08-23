using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTaguatinga.Entities;
using PatrimonioSenaiTaguatinga.EntityConfigurations;

namespace PatrimonioSenaiTaguatinga.Contexts;
public class PatrimonioSenaiTaguatingaContexts : DbContext
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new UsuarioConfigurations());
        modelBuilder.ApplyConfiguration(new NivelConfigurations());
    }
    private readonly IConfiguration _configuration;
    public PatrimonioSenaiTaguatingaContexts(IConfiguration configuration)//Construtor !
    {
        _configuration = configuration;
    }
    public DbSet<Usuario> Usuarios => Set<Usuario>();
    public DbSet<Nivel> Niveis => Set<Nivel>();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(_configuration.GetConnectionString("SenaiTaguatinga"));
    }
}

