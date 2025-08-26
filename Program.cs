namespace Ambiente1
{
    internal class Program
    { 
        /// <summary>
        /// Funcao que recebe um String e a printa
        /// </summary>
        /// <param name="message"> Mensagem a ser printada </param>
        static void Print(String message)
        {
            Console.Write(message);
            return;
        }

        /// <summary>
        /// Funcao que calcula a area de uma circunferencia atraves de um raio
        /// </summary>
        /// <param name="raio"> Raio da circunferencia </param>
        /// <returns> Double saida </returns>
        static Double CalcularAreaCirculo(Double raio)
        {
            Double saida = Math.PI * Math.Pow(raio, 2);
            return saida;
        }


        public static void Main(string[] args)
        {
            Print("Olá, qual o seu nome?\n\t- ");
            String nome = Console.ReadLine();

            Print("Opa " + nome + ", diga um valor de raio para eu medir a área da circuferência:\n\t- ");
            Double raio = Double.Parse(Console.ReadLine());

            Print(nome + ", a área de uma circunferência de raio " + raio + " é: " + CalcularAreaCirculo(raio) + ".\n");
        }
    }
}
