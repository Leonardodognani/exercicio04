/* Exercício 04 - Desenvolva um algoritmo que solicite a entrada da idade de um determinado usuário,
se for menor que 18 anos exiba na cor vermelha “Sem permissão”, caso seja maior ou igual a 18 anos
exiba na cor verde “Permissão concedida”.
*/

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;

            Console.Write("Por favor, digite o seu nome: ");
            name = Console.ReadLine();

            Console.Write("Por favor, digite a sua idade: ");
            age = Convert.ToInt32(Console.ReadLine());

            if(age < 18)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Aceso Negado");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Acesso Permitido");

            }
                Console.ReadKey();


        }
    }
}
