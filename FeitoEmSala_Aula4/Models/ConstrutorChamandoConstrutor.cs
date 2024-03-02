namespace FeitoEmSala_Aula4.Models;

public class ConstrutorChamandoConstrutor
{
    public int Numero { get; set; }
    public ConstrutorChamandoConstrutor(int numero)
    {
        Numero = numero;
    }

    public ConstrutorChamandoConstrutor() : this(3)
    {
        
    }
}