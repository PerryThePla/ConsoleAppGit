using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppGit
{
    public class Dadi
    {
        public int Lanciadado()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }
    }
}
