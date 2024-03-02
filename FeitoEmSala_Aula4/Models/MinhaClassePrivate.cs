namespace FeitoEmSala_Aula4.Models;

public class MinhaClassePrivate
{
    //Nosso Atributo privado
    private string nomePrivado;

    public void SetNome(string novoNome)
    {
        nomePrivado = novoNome;
    }

    public string GetNome()
    {
        return nomePrivado;
    }
}