namespace sajatoasszekotott
{
    internal class Program
    {
        static void Main(string[] args)
        {
            csomagok cs1 = new csomagok("ABC U.7",10.5,2.3,"Nagy Béla","Kis Miska","T,TWU");
            Console.WriteLine(cs1);
            postairoda PI1 = new postairoda(0,"N.Posta Iroda");
            Console.WriteLine(PI1);
            PI1.csomag_feladas(cs1);
            Console.WriteLine(PI1);
        }
    }
}
