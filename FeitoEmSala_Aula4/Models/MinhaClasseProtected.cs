namespace FeitoEmSala_Aula4.Models;

public class MinhaClasseProtected
{
    protected string nome;

    protected virtual string GetNome()
    {
        return nome;
    }
}

public class HerancaProtected : MinhaClasseProtected
{
    protected override string GetNome()
    {
        nome += " Sobrenome";
        return "Outro Tipo";
    }
    
    public void TesteProtected()
    {
        GetNome();
    }
}