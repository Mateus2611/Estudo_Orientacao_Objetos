using System;

namespace OrientacaoObjetos
{
    public class TestaValorePadrao
    {
        static void Main(string[] args)
        {
            Conta c3 = new Conta();

            Console.WriteLine($"Valores padrão: ");
            Console.WriteLine($"Valores padrão Número {c3.numero} ");
            Console.WriteLine($"Valores padrão Saldo {c3.saldo} ");
            Console.WriteLine($"Valores padrão Limite {c3.limite}");

            Conta c4 = new Conta();
            c4.numero = 400;
            c4.saldo = 4000;

            Console.WriteLine($"Valores padrão: ");
            Console.WriteLine($"Valores padrão Número {c4.numero} ");
            Console.WriteLine($"Valores padrão Saldo {c4.saldo} ");
            Console.WriteLine($"Valores padrão Limite {c4.limite}");
        }
    }
}