namespace PatrimonioSenaiTaguatinga.Entities;
public class Usuario
{
    public Usuario(string nome, string sobreNome, string login, int senha, int idNivel)
    {
        this.nome = nome;
        SobreNome = sobreNome;
        Login = login;
        this.senha = senha;
        IdNivel = idNivel;
    }
    public int Id { get; set; }
    public string nome { get; set; }
    public string SobreNome { get; set; }
    public string Login { get; set; }
    public int senha { get; set; }
    public int IdNivel { get; set; }
    public Nivel Niveis { get; set; } = null!;
}