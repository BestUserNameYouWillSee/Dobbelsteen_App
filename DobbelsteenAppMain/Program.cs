using DobbelsteenAppMain.Models;

namespace DobbelsteenAppMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vragenAntwoorden = Vragen();

            //Dobbelsteen dobbelsteen = new Dobbelsteen(20, true, new List<string> { "Geel"}, 1, 2, true, new List<string> { "Bruin", "Oranje" }, new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20},new List<int> { 50,50 },new List<string> {"Geen","Dots"});
            switch (vragenAntwoorden.Item3)
            {
                case 50:
                    D50 nD50 = new(vragenAntwoorden.Item1, vragenAntwoorden.Item9, vragenAntwoorden.Item5, vragenAntwoorden.Item4, vragenAntwoorden.Item2, vragenAntwoorden.Item8, vragenAntwoorden.Item10, vragenAntwoorden.Item11, vragenAntwoorden.Item7);
                    nD50.SetTypeDobbelsteen("D50");
                    Console.WriteLine($"Het type dobbelsteen is: {nD50.GetDobbelsteenType()}");
                    WeergaveDobbelsteen(nD50);
                    nD50.GooiDobbelsteen(vragenAntwoorden.Item3, vragenAntwoorden.Item1, vragenAntwoorden.Item10);
                    break;
                case 6:
                    D6 nD6 = new(vragenAntwoorden.Item6, vragenAntwoorden.Item1, vragenAntwoorden.Item9, vragenAntwoorden.Item5, vragenAntwoorden.Item4, vragenAntwoorden.Item2, vragenAntwoorden.Item8, vragenAntwoorden.Item10, vragenAntwoorden.Item11, vragenAntwoorden.Item7);
                    WeergaveDobbelsteen(nD6);
                    nD6.GooiDobbelsteen(vragenAntwoorden.Item3, vragenAntwoorden.Item1, vragenAntwoorden.Item10);
                    break;
                default:
                    Dobbelsteen dobbelsteen = new(vragenAntwoorden.Item3, vragenAntwoorden.Item1, vragenAntwoorden.Item9, vragenAntwoorden.Item5, vragenAntwoorden.Item4, vragenAntwoorden.Item2, vragenAntwoorden.Item8, vragenAntwoorden.Item10, vragenAntwoorden.Item11, vragenAntwoorden.Item7);
                    WeergaveDobbelsteen(dobbelsteen);
                    dobbelsteen.GooiDobbelsteen(vragenAntwoorden.Item3, vragenAntwoorden.Item1, vragenAntwoorden.Item10);
                    break;
            }
            
            
        }
        static (bool,bool,int,int,int,string,List<string>, List<string>, List<string>, List<string>, List<int>) Vragen()
        {
            List<string> lsKleuren = new List<string>();
            List<string> lsWaardeKleuren = new List<string>();
            List<string> lsWaardeZijde = new List<string>();
            List<string> lsAanwezigPatronen = new List<string>();
            List<int> lsPercentagekleur = new List<int>();
            int intPercentagekleur = 0;
            int intAantalZijdes = 0;
            int intHoeveelKleuren = 0;
            int intHoeveelWaardeKleuren = 0;
            bool check = true;
            bool bZijnGetallenSymbolen = true;
            bool bMeerderePatronen = true;
            string strSoortSymbolen = "";
            while (check)
            {
                Console.WriteLine("Hoeveel zijdes heeft je dobbelsteen?");
                string strAantalZijdes = Console.ReadLine();
                strAantalZijdes =EmptyReadlineCheck(strAantalZijdes);
                intAantalZijdes = TryParseCheck(strAantalZijdes);

                Console.WriteLine("Zijn de symbolen getallen? (j/n)");
                string strZijnGetallenSymbolen = Console.ReadLine();
                strZijnGetallenSymbolen = EmptyReadlineCheck(strZijnGetallenSymbolen);
                bZijnGetallenSymbolen = BoolCheck(strZijnGetallenSymbolen);
                
                if (bZijnGetallenSymbolen == false)
                {
                    Console.WriteLine("Wat voor soort symbolen zijn het?");
                    strSoortSymbolen = Console.ReadLine();
                    strSoortSymbolen = EmptyReadlineCheck(strSoortSymbolen);

                }
                Console.WriteLine("Hoeveel kleuren heeft je dobbelsteen (alleen je dobbelsteen zonder symbool kleuren)?");
                string strHoeveelKleuren = Console.ReadLine();
                strHoeveelKleuren = EmptyReadlineCheck(strHoeveelKleuren);
                intHoeveelKleuren = TryParseCheck(strHoeveelKleuren);
                for (int i = 0; i < intHoeveelKleuren; i++)
                {
                    Console.WriteLine("Welke kleur(en) heeft je dobbelsteen? (een voor een invoeren. Je krijgt per kleur een nieuwe input.)");
                    string strKleuren = Console.ReadLine();
                    strKleuren = EmptyReadlineCheck(strKleuren);
                    lsKleuren.Add(strKleuren);
                }
                
                Console.WriteLine("Hoeveel kleuren heeft de waarde van je dobbelsteen?");
                string strHoeveelWaardeKleuren = Console.ReadLine();
                strHoeveelWaardeKleuren = EmptyReadlineCheck(strHoeveelWaardeKleuren);
                intHoeveelWaardeKleuren = TryParseCheck(strHoeveelWaardeKleuren);
                for (int i = 0; i < intHoeveelWaardeKleuren; i++)
                {
                    Console.WriteLine("Welke kleur(en) heeft de waarde van je dobbelsteen? (een voor een invoeren. Je krijgt per kleur een nieuwe input.)");
                    string strWaardeKleuren = Console.ReadLine();
                    strWaardeKleuren = EmptyReadlineCheck(strWaardeKleuren);
                    lsWaardeKleuren.Add(strWaardeKleuren);
                }

                for (int i = 0; i < intAantalZijdes; i++)
                {
                    Console.WriteLine("Wat zijn de waarden van de zijdes? (een voor een invoeren. Je krijgt per waarde een nieuwe input.)");
                    string strWaardeZijde = Console.ReadLine();
                        strWaardeZijde = EmptyReadlineCheck(strWaardeZijde);
                    lsWaardeZijde.Add(strWaardeZijde);
                }
                
                Console.WriteLine("Heeft je dobbelsteen een of meerdere patronen? (j/n)");
                string strMeerderePatronen = Console.ReadLine();
                strMeerderePatronen =   EmptyReadlineCheck(strMeerderePatronen);
                bMeerderePatronen = BoolCheck(strMeerderePatronen);
                int intHoeveelPatronen = 0;
                if (bMeerderePatronen)
                {
                    Console.WriteLine("Hoeveel patronen heeft je dobbelsteen?");
                    string strHoeveelPatronen = Console.ReadLine();
                    strHoeveelPatronen = EmptyReadlineCheck(strHoeveelPatronen);
                    intHoeveelPatronen = TryParseCheck(strHoeveelPatronen);
                }
                else
                {
                    intHoeveelPatronen = 1;
                }
                for (int i = 0; i < intHoeveelPatronen; i++)
                {
                    Console.WriteLine("Welke patronen zijn aanwezig (per primaire kleur de patroon geven. e.g. 2 primaire kleuren: Geel en Groen. Geel heeft 'dots' als patroon en groen heeft 'geen' patroon. Waarde binnen '' zijn de patronen die je invuld)?");
                    string strAanwezigPatronen = Console.ReadLine();
                    strAanwezigPatronen = EmptyReadlineCheck(strAanwezigPatronen);
                    lsAanwezigPatronen.Add(strAanwezigPatronen);
                }

                for (int i = 0; i < intHoeveelKleuren; i++)
                {
                    Console.WriteLine("Hoeveel procent van de dobbelsteen wordt per kleur gebruikt? (een voor een invoeren. Je krijgt per kleur een nieuwe input. Gebruik hele getallen!)");
                    string strPercentagekleur = Console.ReadLine();
                    strPercentagekleur = EmptyReadlineCheck(strPercentagekleur);
                    intPercentagekleur = TryParseCheck(strPercentagekleur);
                    lsPercentagekleur.Add(intPercentagekleur);
                }

                check = false;
            }
            return (bZijnGetallenSymbolen,bMeerderePatronen,intAantalZijdes,intHoeveelKleuren, intHoeveelWaardeKleuren, strSoortSymbolen,lsAanwezigPatronen,lsKleuren,lsWaardeKleuren,lsWaardeZijde, lsPercentagekleur);
        }
        static void WeergaveDobbelsteen(Dobbelsteen dobbelsteen)
        {
            Console.WriteLine($"De dobbelsteen heeft {dobbelsteen.AantalZijdes} zijdes");
            Console.WriteLine($"De kleuren zijn ongeveer {dobbelsteen.PercentageKleurenSplit[0]}/{dobbelsteen.PercentageKleurenSplit[1]} gesplitst");
            Console.WriteLine($"De waardes hebben/heeft {dobbelsteen.AantalDobbelsteenWaardeKleur} kleur(en). De kleur(en) is/zijn: ");
            foreach (var waardekleur in dobbelsteen.DobbelsteenWaardeKleur)
            {
                Console.WriteLine($"{waardekleur}, ");
            }
            Console.WriteLine($"De dobbelsteen heeft {dobbelsteen.AantalDobbelsteenKleur} primaire kleuren. De primaire kleuren van de dobbelsteen zijn:");
            foreach (var kleur in dobbelsteen.DobbelsteenKleuren)
            {
                Console.Write($"{kleur},");
            }
            Console.WriteLine("\nDe waardes zijn:");
            foreach (var waarde in dobbelsteen.DobbelsteenWaardes)
            {
                Console.Write($"{waarde},");
            }
            Console.WriteLine("\nDe volgende patronen zijn aanwezig");
            foreach (var patroon in dobbelsteen.SoortPatronen)
            {
                Console.Write($"{patroon},");
            }
            //Console.WriteLine(dobbelsteen.SoortPatronen);
            //Console.WriteLine(dobbelsteen.GetDobbelsteen());
        }
        static string EmptyReadlineCheck(string input)
        {
            bool c = true;
            while (c)
            {
                if (input == "")
                {
                    Console.WriteLine("Voer iets in.");
                    input = Console.ReadLine();
                    EmptyReadlineCheck(input);
                }
                else
                {
                    c = false;
                }
            }
            return input;
        }
        static int TryParseCheck(string Input)
        {
            bool c = true;
            bool success = int.TryParse(Input, out int intInput);
            while (c)
            {
                if (success == false)
                {
                    Console.WriteLine("Voer een getal in.");
                    Input = Console.ReadLine();
                    TryParseCheck(Input);
                }
                else
                {
                    c = false;
                }
                
            }
            return intInput;
        }
        static bool BoolCheck(string input)
        {
            bool c = true;
            bool bInput = true;
            while (c)
            {
                if (input == "j")
                {
                    c = false;
                    return bInput;
                }
                else if (input == "n")
                {
                    c = false;
                    bInput = false;
                    return bInput;
                }
                else
                {
                    Console.WriteLine("Voer een j of n in.");
                    Console.ReadLine();
                }
            }
            return bInput;
        }
    }
}
