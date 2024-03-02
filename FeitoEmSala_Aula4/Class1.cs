using FeitoEmSala_Aula4.Models;

namespace FeitoEmSala_Aula4;

public class Class1 : MinhaClasseProtected
{
    public void TestePrivate()
    {
        var classePrivada = new MinhaClassePrivate();
        //classePrivada.nomePrivado
    }

    public void TesteProtected()
    {
        var classeProtected = new MinhaClasseProtected();
        //classeProtected.GetNome();

        GetNome();
    }

    public void TesteConstrutor()
    {
        var construtorTeste = new ConstrutorEspecializado("teste");
        var construtorTeste2 = new ConstrutorEspecializado();

        
        //O resultado vai ser teste
        construtorTeste.RetornaNome();
        
        //O resultado vai ser string.Empty
        construtorTeste2.RetornaNome();
    }
}