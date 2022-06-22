using McMaster.Extensions.CommandLineUtils;
using System.ComponentModel.DataAnnotations;

namespace SeagullTemplateCLI
{
    class Program
    {
        static void Main(string[] args) => CommandLineApplication.Execute<Program>(args);

        [Argument(0, Description = "argument"), Required]
        public string Argument0 { get; private set; } = "";
        [Option(ShortName = "o", LongName = "option", Description = "option")]
        public string Option0 { get; private set; } = "";
        private void OnExecute()
        {
            ;
        }
    }
}