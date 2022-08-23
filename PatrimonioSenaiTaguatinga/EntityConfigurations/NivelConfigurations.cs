using PatrimonioSenaiTaguatinga.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace PatrimonioSenaiTaguatinga.EntityConfigurations;
public class NivelConfigurations : IEntityTypeConfiguration<Nivel>
{
    public void Configure(EntityTypeBuilder<Nivel> builder)
    {
        builder.ToTable("Niveis");
        builder.HasKey(n => n.Id);
        builder.Property(n => n.Nome)
        .IsRequired()
        .HasMaxLength(50);
        builder.HasMany(n => n.Usuarios)
        .WithOne(u => u.Niveis)
        .HasForeignKey(u => u.IdNivel);
    }
}
