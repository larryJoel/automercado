 internal class Program
    {
        static void Main(string[] args)
        {
            var art22 = new Articulo("AQW12","Agua mineral","Minalva",22,34.24);
            Console.WriteLine(art22.ToString());
            var art234 = new Fresco("AQW12","Agua mineral","Minalva",22,34.24,"fresquito",14.5); 
            Console.WriteLine(art234.ToString());
            var art999 = new Limpieza("AQ232Q","Labandina","limpiolin",45,18.23,"2lts","desinfectante");
        }
    }
