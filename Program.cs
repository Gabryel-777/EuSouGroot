using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(@"
    +---------------------+
    |   EU SOU O GROOT!   |
    +---------------------+
        ");

        while (true)
        {
            Console.Write("Pergunta: ");
            string? pergunta = Console.ReadLine();

            
            if (string.IsNullOrWhiteSpace(pergunta))
            {
                continue; 
            }

            if (pergunta.ToLower().Trim() == "tchau")
            {

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("                          Resposta: Eu sou Groot!");
                Console.ResetColor();

                break;

            }
            else
            {

                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("                          Resposta: Eu sou Groot.");
                Console.ResetColor();

            }
        }
    }
}