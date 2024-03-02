namespace FeitoEmSala_Aula4.Models;

public class ConstrutorBase
{
    public int MyProperty { get; set; }
    public ConstrutorBase(int myProperty)
    {
        MyProperty = myProperty;
    }
}

public class ConstrutorHerdado : ConstrutorBase
{
    public string Nome { get; set; }
    public ConstrutorHerdado(int myProperty, string nome) : base(myProperty)
    {
        Nome = nome;
    }
}