namespace Ambiente1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // idade do primeiro aluno
            int age1;
            // idade do segundo aluno
            int age2;
            // entrada do usuário
            String userInput;
            // resultado da comparação para output
            String programOutput;


            // apresentação do programa
            Console.WriteLine("\n\n\tO programa a seguir irá pedir a " +
                "idade de dois alunos para definir quem é o mais velho e quem é o mais novo.");
            

            // input do aluno 1
            Console.Write("\nInsira a idade do primeiro aluno:\n\t- ");
            userInput = Console.ReadLine();
            age1 = int.Parse(userInput);


            // input do aluno 2
            Console.Write("\nInsira a idade do segundo aluno:\n\t- ");
            userInput = Console.ReadLine();
            age2 = int.Parse(userInput);


            // definição do output
            if (age1 > age2)
            {
                programOutput = "mais velho que";
            }
            else if (age1 == age2)
            {
                programOutput = "tão velho quanto";
            }
            else
            {
                programOutput = "mais novo que";
            }


            // output
            Console.WriteLine("\nO primeiro aluno(idade: {0}) é {1} o segundo aluno(idade: " +
                "{2})!", age1, programOutput, age2);
        }
    }
}