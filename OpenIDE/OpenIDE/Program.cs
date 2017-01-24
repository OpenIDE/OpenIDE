using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyvarUI.Window;

namespace OpenIDE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Form f = new Form();
            f.Show();

            

            while(true)
            {
                f.Draw();
            }
        }
    }
}