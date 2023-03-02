using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices
{
    public class Addition : ICommand
    {
        public string Name => "Addition";

        public void Execute()
        {
            int a = 5, b = 3;
            Console.WriteLine($"{a} + {b} = {a + b}");
        }
    }
}
