namespace Ambiente1
{
    internal class Program
    {
        /// <summary>
        /// Funcao que printa uma mensagem n vezes
        /// </summary>
        /// <param name="vezes">quantidade de vezes</param>
        /// <param name="mensagem">mensagem a ser repetida</param>
        static void PrintaNVezes(int vezes, String mensagem)
        {
            for (int count = 0; count < vezes; count++)
            {
                Console.Write(mensagem);
            }
            return;
        }


        /// <summary>
        /// Funcao que printa cada linha de um triangulo
        /// </summary>
        /// <param name="vazios">quantidade de vazios na parte inicial e final da linha</param>
        /// <param name="cheios">quantidade de chars completos tanto do lado esquedo como direito do centro da linha</param>
        /// <param name="impar">necessidade de uma coluna central no caso de bases impares</param>
        static void PrintaLinhaTriangulo(int vazios, int cheios, bool impar = false)
        {
            PrintaNVezes(vazios, " ");
            PrintaNVezes(cheios, "#");
            if (impar)
            {
                Console.Write("#");
            }
            PrintaNVezes(cheios, "#");
            PrintaNVezes(vazios, " ");
            Console.WriteLine();
            return;
        }
        /// <summary>
        /// Funcao que printa troncos de arvores
        /// </summary>
        /// <param name="espacos">espacamentos finais e iniciais para centralizat tronco</param>
        /// <param name="impar">necessidade de espacamento de cada parede do tronco</param>
        static void PrintaCaule(int espacos, bool impar = false)
        {
            PrintaNVezes(espacos, " ");
            Console.Write("|");
            if (impar)
            {
                Console.Write(" ");
            }
            Console.Write("|");
            PrintaNVezes(espacos, " ");
            Console.WriteLine();
            return;
        }
        /// <summary>
        /// Funcao que printa triangulos de base par
        /// </summary>
        /// <param name="baseTriangulo">valor da base do triangulo</param>
        /// <returns>int meiaBaseTriangulo</returns>
        static int CriaTrianguloPar(int baseTriangulo)
        {
            int meiaBaseTriangulo = baseTriangulo / 2;
            int quantidadeVazio = 0;
            for (int quantidadePreenchida = 1; quantidadePreenchida <= meiaBaseTriangulo; quantidadePreenchida++)
            {
                quantidadeVazio = meiaBaseTriangulo - quantidadePreenchida;
                PrintaLinhaTriangulo(quantidadeVazio, quantidadePreenchida);
            }
            return meiaBaseTriangulo;
        }
        /// <summary>
        /// Funcao que printa triangulos de base impar
        /// </summary>
        /// <param name="baseTriangulo">valor da base do triangulo</param>
        /// <returns>int meiaBaseTriangulo</returns>
        static int CriaTrianguloImpar(int baseTriangulo)
        {
            int meiaBaseTriangulo = (baseTriangulo - 1) / 2;
            int quantidadeVazio = 0;
            for (int quantidadePreenchida = 0; quantidadePreenchida <= meiaBaseTriangulo; quantidadePreenchida++)
            {
                quantidadeVazio = meiaBaseTriangulo - quantidadePreenchida;
                PrintaLinhaTriangulo(quantidadeVazio, quantidadePreenchida, true);
            }
            return meiaBaseTriangulo;
        }
        /// <summary>
        /// Funcao que decide usar um criador de triangulos par ou impar, alem de permitir criacao de arvores
        /// </summary>
        /// <param name="baseTriangulo">valor da base do triangulo</param>
        /// <param name="arvore">se e uma arvore ou triangulo</param>
        static void EscolheCriaTriangulo(int baseTriangulo, bool arvore = false)
        {
            if (baseTriangulo < 2)
            {
                baseTriangulo = 2;
            }
            
            int meiaBaseTrianguloParaPrint;
            if (baseTriangulo % 2 == 0)
            {
                meiaBaseTrianguloParaPrint = CriaTrianguloPar(baseTriangulo);
                if (arvore)
                {
                    PrintaCaule(meiaBaseTrianguloParaPrint - 1);
                }
            }
            else
            {
                meiaBaseTrianguloParaPrint = CriaTrianguloImpar(baseTriangulo);
                if (arvore)
                {
                    PrintaCaule(meiaBaseTrianguloParaPrint - 1, true);
                }
            }
            Console.WriteLine(" - Forma de base: {0}\n\n", baseTriangulo);
            return;
        }


        /// <summary>
        /// Funcao que printa cubos
        /// </summary>
        /// <param name="tamanho">tamanho da aresta do cubo</param>
        static void CriaCubo(int tamanho)
        {
            if (tamanho < 1)
            {
                tamanho = 1;
            }

            // aresta superior da face superior
            PrintaNVezes(2, " ");
            PrintaNVezes(tamanho*2, "_");
            Console.WriteLine();

            // arestas laterais da face superior
            // aresta superior da face central
            Console.Write("/");
            PrintaNVezes(tamanho*2, "_");
            Console.Write("/|");
            Console.WriteLine();

            // arestas laterais da face central
            // arestas laterais da face lateral
            for (int count=0; count<tamanho-1; count++)
            {
                Console.Write("|");
                PrintaNVezes(tamanho*2, " ");
                Console.WriteLine("||");
            }

            // aresta inferior da face central
            Console.Write('|');
            PrintaNVezes(tamanho*2, "_");
            Console.Write("|/");
            Console.WriteLine();

            Console.WriteLine(" - Forma de tamanho: {0}\n\n", tamanho);
            return;
        }


        /// <summary>
        /// Funcao que printa ambas as partes superiores e inferiores de um losango
        /// </summary>
        /// <param name="tamanho">tamanho das arestas de um losango</param>
        static void CriaLosango(int tamanho)
        {
            if (tamanho < 1)
            {
                tamanho = 1;
            }
            ParteSuperiorLosango(tamanho);
            ParteInferiorLosango(tamanho);
            Console.WriteLine(" - Forma de tamanho: {0}\n\n", tamanho);
            return;
        }
        /// <summary>
        /// Funcao que printa a parte superior de um losango
        /// </summary>
        /// <param name="tamanhoAresta">tamanho das arestas de um losango</param>
        static void ParteSuperiorLosango(int tamanhoAresta)
        {
            for(int espacosExternos= tamanhoAresta-1; espacosExternos>=0; espacosExternos--)
            {
                int espacosInternos = tamanhoAresta - (espacosExternos+1);
                PrintaNVezes(espacosExternos, " ");
                Console.Write("/");
                PrintaNVezes(espacosInternos*2, " ");
                Console.Write("\\");
                PrintaNVezes(espacosExternos, " ");
                Console.WriteLine();
            }
            return;
        }
        /// <summary>
        /// Funcao que printa a parte superior de um losango
        /// </summary>
        /// <param name="tamanhoAresta">tamanho das arestas de um losango</param>
        static void ParteInferiorLosango(int tamanhoAresta)
        {
            for (int espacosExternos=0; espacosExternos <= tamanhoAresta - 1; espacosExternos++)
            {
                int espacosInternos = tamanhoAresta - (espacosExternos + 1);
                PrintaNVezes(espacosExternos, " ");
                Console.Write("\\");
                PrintaNVezes(espacosInternos * 2, " ");
                Console.Write("/");
                PrintaNVezes(espacosExternos, " ");
                Console.WriteLine();
            }
            return;
        }


        public static void Main(string[] args)
        {
            // arvore
            // atividade pedida em aula
            EscolheCriaTriangulo(0, true);
            EscolheCriaTriangulo(15, true);

            // triangulo
            EscolheCriaTriangulo(7);
            EscolheCriaTriangulo(16);

            // cubo
            CriaCubo(0);
            CriaCubo(6);
            CriaCubo(9);
            
            // losango
            CriaLosango(0);
            CriaLosango(6);
            CriaLosango(9);

            // impedir fechamento automático do console
            Console.WriteLine("\n Aperte Enter para finalizar o programa");
            Console.ReadLine();

            //Console.WriteLine("  ____");
            //Console.WriteLine("/____/|");
            //Console.WriteLine("|    ||  ");
            //Console.WriteLine("|____|/  ");

            //Console.WriteLine("  ______");
            //Console.WriteLine("/______/|");
            //Console.WriteLine("|      ||  ");
            //Console.WriteLine("|      ||  ");
            //Console.WriteLine("|______|/  ");
        }
    }
}
