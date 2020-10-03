namespace LanguageBasics
{
    public class Panda
    {
        public string Name;
        public static int Population;

        public Panda(string n)
        {
            Name = n;
            Population++;
        }
    }
}