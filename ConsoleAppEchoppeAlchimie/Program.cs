namespace ConsoleAppEchoppeAlchimie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Saisir la quantité");
            int quantité = int.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le calibre du flacon (standard/grand)");
            string calibre = Console.ReadLine();
            Console.WriteLine("Saisir la finition désirée (A/P)");
            char finition = char.Parse(Console.ReadLine());
            Console.WriteLine("Saisir le degré de pureté voulu (1-4)");
            int pureté = int.Parse(Console.ReadLine());
            decimal prixStandard = 0;
            decimal prixGrand = 0;
            decimal prixFinal = 0;
            if (quantité >= 1 && quantité <= 25)
            {
                prixStandard = 1.5m;
                prixGrand = 3.0m;
            }
            else if (quantité >= 26 && quantité <= 50)
            {
                prixStandard = 1.0m;
                prixGrand = 2.0m;
            }
            else if (quantité >= 51 && quantité <= 100)
            {
                prixStandard = 0.90m;
                prixGrand = 1.80m;
            }
            else if (quantité >= 101 && quantité <= 250)
            {
                prixStandard = 0.80m;
                prixGrand = 1.60m;
            }
            else if (quantité >= 251 && quantité <= 500)
            {
                prixStandard = 0.70m;
                prixGrand = 1.40m;
            }
            else if (quantité >= 501 && quantité <= 1000)
            {
                prixStandard = 0.60m;
                prixGrand = 1.20m;
            }
            else if (quantité >= 1001 && quantité <= 3000)
            {
                prixStandard = 0.50m;
                prixGrand = 1.20m;
            }
            else if (quantité >= 3001 && quantité <= 4000)
            {
                prixStandard = 0.80m;
                prixGrand = 0.40m;
            }
            else if (quantité > 4000)
            {
                prixStandard = 0.30m;
                prixGrand = 0.60m;
            }
            if (calibre == "standard" && finition == 'A')
            {
                prixFinal = (prixStandard * quantité) + (0.30m * quantité);
            }
            else if (calibre == "standard" && finition == 'P')
            {
                prixFinal = (prixGrand * quantité) + (1.60m * quantité);
            }
            else if (calibre == "grand" && finition == 'A')
            {
                prixFinal = (prixGrand * quantité) + (0.60m * quantité);
            }
            else if (calibre == "grand" && finition == 'P')
            {
                prixFinal = (prixStandard * quantité) + (3.20m * quantité);
            }
            if (pureté == 1 && calibre == "standard")
            {
                prixFinal += 0.50m * quantité;
            }
            else if (pureté == 1 && calibre == "grand")
            {
                prixFinal += 1.00m * quantité;
            }

            else if (pureté == 2 && calibre == "standard")
            {
                prixFinal += 1.00m * quantité;
            }
            else if (pureté == 2 && calibre == "grand")
            {
                prixFinal += 2.00m * quantité;
            }

            else if (pureté == 3 && calibre == "standard")
            {
                prixFinal += 2.00m * quantité;
            }
            else if (pureté == 3 && calibre == "grand")
            {
                prixFinal += 4.00m * quantité;
            }
            else if (pureté == 4 && calibre == "standard")
            {
                prixFinal += 3.00m * quantité;
            }
            else if (pureté == 4 && calibre == "grand")
            {
                prixFinal += 6.00m * quantité;
            }

            else
            {
                Console.WriteLine("Pureté invalide");
                return;
            }
            Console.WriteLine($"Le prix final est de {prixFinal} euros");
        }
    }
}

