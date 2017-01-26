using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyvarUI;
using MyvarUI.Window;
using OpenIDE.Forms;

namespace OpenIDE
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Form f = new MainForm();
            f.Show();

            while(true)
            {
                f.Draw();
            }
        }
    }
}