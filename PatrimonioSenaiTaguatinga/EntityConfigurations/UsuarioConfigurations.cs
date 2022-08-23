using Microsoft.EntityFrameworkCore;
using PatrimonioSenaiTaguatinga.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace PatrimonioSenaiTaguatinga.EntityConfigurations;
public class UsuarioConfigurations : IEntityTypeConfiguration<Usuario>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("Usuarios");
        builder.HasKey(u => u.Id);
        builder.Property(u => u.nome)
        .IsRequired()
        .HasMaxLength(50);
        builder.Property(u => u.Login)
        .IsRequired()
        .HasMaxLength(30);
        builder.HasIndex(u => u.Login)
        .IsUnique();
        builder.Property(u => u.SobreNome)
        .IsRequired()
        .HasMaxLength(30);
        builder.Property(u => u.senha)
        .IsRequired()
        .HasMaxLength(16);
        builder.HasOne(n => n.Niveis);
    }
}
