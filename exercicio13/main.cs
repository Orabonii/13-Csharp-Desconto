using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite o valor da compra:");
            double valorCompra;

            if (!double.TryParse(Console.ReadLine(), out valorCompra))
            {
                Console.WriteLine("Valor de compra inválido.");
                return;
            }

            Console.WriteLine("Por favor, digite a categoria do cliente (1 para comum, 2 para associado, 3 para VIP):");
            int categoriaCliente;

            if (!int.TryParse(Console.ReadLine(), out categoriaCliente))
            {
                Console.WriteLine("Categoria do cliente inválida.");
                return;
            }

            double valorFinal = valorCompra;

            switch (categoriaCliente)
            {
                case 1:
                    break;
                case 2:
                    valorFinal *= 0.90; 
                    break;
                case 3:
                    valorFinal *= 0.80;
                    break;
                default:
                    Console.WriteLine("Categoria do cliente inválida.");
                    return;
            }
            Console.WriteLine($"O valor final da compra após o desconto é: {valorFinal:C2}");
        }
    }





