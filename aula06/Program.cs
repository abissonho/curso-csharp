using System;

namespace aula02
{
    class Program
    {
        /*static void Main()
        {
            int n1,n2,n3;
            n1 = 10;
            n2 = 20;    
            n3 = 30;
            Console.Write("\nn1=\t{0}\nn2=\t{1}\nn3=\t{2}", n1, n2, n3);
            //\n - quebra de linha
            //\t - tabulação

        }*/

        static void Main()
        {
            double valorCompra= 5.50;
            double valorVenda=0;
            double lucro= 0.1;

            valorVenda=valorCompra+(valorCompra*lucro);

            string produto= "Caderno";

            Console.WriteLine("Produto: {0,15}", produto);
            Console.WriteLine("Valor de Compra: {0,10:C}", valorCompra);
            Console.WriteLine("Valor de Venda: {0,12:C}", valorVenda);
            Console.WriteLine("Lucro: {0,18:P}", lucro);

        }
    }
}