using System;

namespace CSharpNotes
{
    delegate void MyDel(int value);  //声明一个委托

    public class AboutDelegate
    {
        public void PrintLow(int value)
        {
            Console.WriteLine("{0}-low value", value);
        }

        public void PrintHigh(int value)
        {
            Console.WriteLine("{0}-high value", value);
        }

        
    }

    
}
