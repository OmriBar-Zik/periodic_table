using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cimestry
{
    class UserInterface
    {
        public static DataBase N = new DataBase();
        public static void UserInput()
        {
            List<string> a = new List<string>();
            while (true)
            {
                Console.WriteLine(ColoredComment("Enter your question about the periodic table:", "yellow"));
                CheckKeyWords(SentenceToWords(SpecialCommands(Console.ReadLine())));
            }
        }

        private static List<string> SentenceToWords(string Sentence)
        {
            List<string> words = new List<string>();
            for (int i = 0, StartWord = 0; i < Sentence.Length; i++)
            {
                if (Sentence[i] == ' ')
                {
                    words.Add(Sentence.Substring(StartWord, (i - StartWord)));
                    StartWord = (i + 1);
                }
            }
            return TestWords(words);
        }

        private static List<string> TestWords(List<string> words)
        {
            if (words.ToArray().Length < 2)
            {
                words.Add("ffff");
                words.Add("ffff");
            }
            for (int i = 0; i < words.ToArray().Length; i++)
            {
                if (words[i] == "")
                {
                    words.Remove("");
                }
            }
            return words;
        }

        private static void CheckKeyWords(List<string> Words)
        {
            List<string> KeyWord = new List<string>();
            List<string> Materials = new List<string>();
            for (int K = 0; K < Words.ToArray().Length; K++)
            {
                for (int J = 0; J < N.KeyWord.Length; J++)
                {
                    if (Words[K].ToLower() == N.KeyWord[J])
                    {
                        KeyWord.Add(Words[K]);
                        break;
                    }
                }
                for (int L = 0; L < N.MaterialsInformtion.Length; L++)
                {
                    for (int I = 0; I < 3; I++)
                    {
                        if (char.ToUpper(Words[K][0]) + Words[K].Substring(1) == N.MaterialsInformtion[L][I])
                        {
                            Materials.Add(Words[K]);
                        }
                    }
                }
            }
            if (ErrorChecker(KeyWord,Materials))
            {
                MutipulQuests(KeyWord, Materials);
                return;
            }
        }

        private static void MutipulQuests(List<string> KeyWord, List<string> Materials)
        {
            for (int J = 0; J < KeyWord.ToArray().Length; J++)
            {
                Console.WriteLine(ColoredComment(KeyWord[J],"cyan"));
                for (int K = 0; K < Materials.ToArray().Length; K++)
                {
                    string[] Mul = {KeyWord[J],Materials[K]};
                    ProcessInformation(Mul);
                }
            }
        }

        private static void ProcessInformation(string[] KeyWords)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            switch (KeyWords[0])
            {
                case "name":
                    Console.WriteLine("the name of {0} is {1}", KeyWords[1], N.MaterialsInformtion[ProcessMaterials(KeyWords[1])][2]);
                    break;
                case "number":
                    Console.WriteLine("the number of {0} is {1}", KeyWords[1], N.MaterialsInformtion[ProcessMaterials(KeyWords[1])][0]);
                    break;
                case "symbol":
                    Console.WriteLine("the symbol of {0} is {1}", KeyWords[1], N.MaterialsInformtion[ProcessMaterials(KeyWords[1])][1]);
                    break;
                case "type":
                    Console.WriteLine("the type of {0} is {1}", KeyWords[1], N.MaterialsInformtion[ProcessMaterials(KeyWords[1])][3]);
                    break;
                case "all":
                    Console.WriteLine("all the information about {0}: {1}", KeyWords[1], string.Join(" ", N.MaterialsInformtion[ProcessMaterials(KeyWords[1])]));
                    break;
            }
            Console.ResetColor();
        }

        private static int ProcessMaterials(string Materials)
        {
            for (int L = 0; L < N.MaterialsInformtion.Length; L++)
            {
                for (int I = 0; I < N.MaterialsInformtion[1].Length; I++)
                {
                    if (Materials.ToLower() == N.MaterialsInformtion[L][I].ToLower())
                    {
                        return L;
                    }
                }
            }
            return 1;
        }


        private static string SpecialCommands(string Commands)
        {
            switch (Commands.ToLower())
            {
                case "exit":
                    Environment.Exit(0);
                    break;
                case "commands":
                    PringCommandsList();
                    return "skip ";
                case "printall":
                    PrintAllMaterials();
                    return "skip ";
            }
            return Commands + ' ';
        }

        private static void PringCommandsList()
        {
            Console.WriteLine();
            Console.WriteLine(ColoredComment("comands:", "green"));
            Console.WriteLine(ColoredComment("exit:", "red") + ColoredComment(" to exit the progrem", "cyan"));
            Console.WriteLine(ColoredComment("PrintAll:", "red") + ColoredComment(" print all database", "cyan"));
            Console.WriteLine(ColoredComment("commands:", "red") + ColoredComment(" to show this list", "cyan"));
            Console.WriteLine(ColoredComment("Key words:", "green"));
            Console.WriteLine(ColoredComment("name:", "red") + ColoredComment(" write the name of the Material", "cyan"));
            Console.WriteLine(ColoredComment("number:", "red") + ColoredComment("write the number of the Material", "cyan"));
            Console.WriteLine(ColoredComment("symbol:", "red") + ColoredComment("write the symbol of the Material", "cyan"));
            Console.WriteLine(ColoredComment("series:", "red") + ColoredComment("write the series of the Material", "cyan"));
            Console.WriteLine();
        }

        private static string ColoredComment(string Command, string color)
        {
            switch (color)
            {
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "cyan":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
            }
            Console.Write(Command);
            Console.ResetColor();
            return "";
        }

        private static void PrintAllMaterials()
        {
            for (int i = 0; i < N.MaterialsInformtion.Length; i++)
            {
                Console.WriteLine(string.Join("    \t", N.MaterialsInformtion[i]));
            }
        }

        private static bool ErrorChecker(List<string> check1, List<string> check2)
        {
            int ret = 0;
            if (check1[0] == "skip")
                return false;
            for (int J = 0; J < check1.ToArray().Length; J++)
            {
                if (check1[J] == null)
                {
                    Console.WriteLine(ColoredComment("\nthe sytstem did not recognise the keyword.\nhere is the list of keyword and commands", "red"));
                    PringCommandsList();
                    ret = 1;
                }
            }

            if (check2 == null)
            {
                ColoredComment("the sytstem did not recognise the material / atomic number.\nthe system only have the first 20 materials.\n", "red");
                ret = 1;
            }


            if (ret == 1)
                return false;

            return true;
        }

    }
}
