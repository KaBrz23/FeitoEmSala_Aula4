namespace FeitoEmSala_Aula4.Models;

public class ConstrutorEspecializado
{
    private string Nome { get; set; }
    public ConstrutorEspecializado()
    {
        
    }
    public ConstrutorEspecializado(string nome)
    {
        Console.WriteLine(nome);
    }

    public string RetornaNome()
    {
        return Nome;
    }
}