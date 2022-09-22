namespace Covid_OO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient elke = new Patient("Elke Boonen", 1980, false);
            Console.WriteLine(elke);
            Console.WriteLine(elke.Name);
            Console.WriteLine(elke.Hello());
            Console.WriteLine(elke.Age);


            Patient evy = new Patient("Evy Tempst", 1999, false);
            Patient luca = new Patient("Luca Cavur", 1997, false);
            Patient jarne = new Patient("Jarne Schoolmeesters", 1999, false);
            Patient lasse = new Patient("Lasse Vrijmoed", 1998, false);
            Patient stijn = new Patient("Stijn Sommerijns", 1998, true);


            Hospital AZSintMaarten = new Hospital("Mechelen", 5);

            Console.WriteLine($"Add Stijn: {AZSintMaarten.AddPatient(stijn)}");
            Console.WriteLine(AZSintMaarten);

            AZSintMaarten.AddPatient(luca);
            Console.WriteLine(AZSintMaarten);

            AZSintMaarten.AddPatient(jarne);
            Console.WriteLine(AZSintMaarten);

            AZSintMaarten.AddPatient(lasse);
            Console.WriteLine(AZSintMaarten);

            AZSintMaarten.AddPatient(evy);
            Console.WriteLine(AZSintMaarten);

            Console.WriteLine($"Add Elke: {AZSintMaarten.AddPatient(elke)}");
            Console.WriteLine(AZSintMaarten);

            AZSintMaarten.RemovePatient(evy);
            Console.WriteLine(AZSintMaarten);

            AZSintMaarten.AddPatient(elke);
            Console.WriteLine(AZSintMaarten);

            AZSintMaarten.RemovePatient(stijn);
            Console.WriteLine(AZSintMaarten);

            AZSintMaarten.AddPatient(elke);
            Console.WriteLine(AZSintMaarten);

        }
    }
}