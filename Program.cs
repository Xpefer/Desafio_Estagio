using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    
    internal class Program
    {
        static int num=0;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Bem-Vindo! Descubra se um número pertence a sequência de Fibonacci.");
            iniciar();
            Console.WriteLine(Verificar_Fibonacci(num)); 
            Console.ReadKey();
        }
        static void iniciar()
        {
            Console.WriteLine("informe um número: ");
            try
            {
                num = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Erro: valor Inválido!");
                iniciar();
            }
        }
        static string Verificar_Fibonacci(int ValorInformado)
        {
            int NumAtual = 1, NumAterior = 0, Intermediario, i = 1;
            do
            {
                Intermediario = NumAtual;
                NumAtual = NumAtual + NumAterior;
                NumAterior = Intermediario;
                if(NumAtual== ValorInformado)
                {
                    return "O número informado pertence a sequência";
                }
                i++;
            } while (NumAtual < ValorInformado);
            return "O número informado não pertence a sequência";
        }
    }

}
