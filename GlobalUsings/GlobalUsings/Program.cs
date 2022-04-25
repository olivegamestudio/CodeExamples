namespace GlobalAlias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In the project file, by adding the following lines:
            //
            //    <ImplicitUsings>enable</ImplicitUsings>
            //	  <LangVersion>latest</LangVersion>
            //
            // we can add in global aliases.
            //
            // The global usings are stored in the GlobalUsings.cs file.

            Game game = new Game();
        }
    }
}
