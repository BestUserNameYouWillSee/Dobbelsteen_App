namespace DobbelsteenAppMain.Models
{
    internal class Dobbelsteen
    {
        public int AantalZijdes { get; private set; }
        public bool IsGetal {  get; private set; }
        public List<string> DobbelsteenWaardeKleur { get; private set; }
        public int AantalDobbelsteenWaardeKleur { get; private set; }
        public int AantalDobbelsteenKleur { get; private set; }
        public bool HeeftPatroon { get; private set; }
        public List<string> DobbelsteenKleuren { get; private set; }
        public List<string> DobbelsteenWaardes { get; private set; }
        public List<int> PercentageKleurenSplit { get; private set; }
        public List<string> SoortPatronen { get; private set; }
        private string typeDobbelsteen;

        public Dobbelsteen(int aantalZijdes, bool isGetal, List<string> dobbelsteenWaardeKleur, int aantalDobbelsteenWaardeKleur, int aantalDobbelsteenKleur, bool heeftPatroon, List<string> dobbelsteenKleuren, List<string> dobbelsteenWaardes, List<int> percentageKleurenSplit, List<string> soortPatronen)
        {
            this.AantalZijdes = aantalZijdes;
            this.IsGetal = isGetal;
            this.DobbelsteenWaardes = dobbelsteenWaardes;
            this.DobbelsteenWaardeKleur = dobbelsteenWaardeKleur;
            this.AantalDobbelsteenWaardeKleur = aantalDobbelsteenWaardeKleur;
            this.AantalDobbelsteenKleur = aantalDobbelsteenKleur;
            this.HeeftPatroon = heeftPatroon;
            this.PercentageKleurenSplit = percentageKleurenSplit;
            this.SoortPatronen = soortPatronen;
            this.DobbelsteenKleuren = dobbelsteenKleuren;
        }
        public void GooiDobbelsteen(int aantalZijdes,bool isGetal, List<string> dobbelsteenWaardes)
        {
            Random randomGetal = new Random();
            int intRandomGetal = randomGetal.Next(1,aantalZijdes);
            if (isGetal == false)
            {
                Console.WriteLine($"Je hebt {dobbelsteenWaardes[intRandomGetal]} gegooid");
            }
            else
            {
                Console.WriteLine($"Je hebt {intRandomGetal} gegooid.");
            }
        }
        public void SetTypeDobbelsteen(string dobbelsteenType)
        {
            typeDobbelsteen = dobbelsteenType;
        }
        public string GetDobbelsteenType() 
        { 
            return typeDobbelsteen; 
        }
    }
    internal class D50:Dobbelsteen
    {

        public D50(bool isGetal, List<string> dobbelsteenWaardeKleur, int aantalDobbelsteenWaardeKleur, int aantalDobbelsteenKleur, bool heeftPatroon, List<string> dobbelsteenKleuren, List<string> dobbelsteenWaardes, List<int> percentageKleurenSplit, List<string> soortPatronen) : base(50, isGetal, dobbelsteenWaardeKleur, aantalDobbelsteenWaardeKleur, aantalDobbelsteenKleur, heeftPatroon, dobbelsteenKleuren, dobbelsteenWaardes, percentageKleurenSplit, soortPatronen)
        {

        }
    }
    internal class D6:Dobbelsteen
    {
        public string SoortWaarde { get; private set; }
        public D6(string soortWaarde, bool isGetal, List<string> dobbelsteenWaardeKleur, int aantalDobbelsteenWaardeKleur, int aantalDobbelsteenKleur, bool heeftPatroon, List<string> dobbelsteenKleuren, List<string> dobbelsteenWaardes, List<int> percentageKleurenSplit, List<string> soortPatronen) : base(6, isGetal, dobbelsteenWaardeKleur, aantalDobbelsteenWaardeKleur, aantalDobbelsteenKleur, heeftPatroon, dobbelsteenKleuren, dobbelsteenWaardes, percentageKleurenSplit, soortPatronen)
        {
            this.SoortWaarde = soortWaarde;
        }
    }
}
