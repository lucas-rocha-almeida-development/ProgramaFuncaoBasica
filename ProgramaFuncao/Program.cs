using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramaFuncao {
    internal class Program {
        static void Main(string[] args) { 
             Console.WriteLine("Digite 3 numeros: ");
             int Numero1 = int.Parse(Console.ReadLine());
             int Numero2 = int.Parse(Console.ReadLine());
             int Numero3 = int.Parse(Console.ReadLine());

            // CRIANDO UMA FUNÇÃO
            double resultado = Maior(Numero1, Numero2, Numero3);

            Console.WriteLine("Maior = " + resultado);
        }//inicio de uma nova função
        static int Maior (int a,int b ,int c) {
            int m;
            if(a > b && a >c) {

                m = a;
            } else if(b > c) {
                m = b;
            }
            else {
                m = c;
            }
            return m;//retorne o valor da minha variavel m, que ira cair dentro da variavel resultado   
            
        }
    }
}
