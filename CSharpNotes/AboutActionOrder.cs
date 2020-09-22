using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{
    class AboutActionOrder
    {
        public static AboutActionOrder aao = new AboutActionOrder();
        public static int x = 10;

        AboutActionOrder()
        {
            Console.WriteLine(x);
        }
    }
}
