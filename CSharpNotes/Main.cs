using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{
    //委托代码
    //class Program
    //{
    //    static void Main()
    //    {
    //        AboutDelegate aboutDelegate = new AboutDelegate();

    //        MyDel myDel;  //声明委托变量

    //        Random rand = new Random();
    //        int randomValue = rand.Next(99);

    //        myDel = randomValue < 50 ? new MyDel(aboutDelegate.PrintLow) : new MyDel(aboutDelegate.PrintHigh);  //为委托变量赋值委托对象
    //        myDel(randomValue);  //执行委托

    //    }
    //}


    //事件代码
    class Program
    {
        static void Main()
        {
            AboutEventPub aboutEventPub = new AboutEventPub();
            AboutEventSub aboutEventSub = new AboutEventSub(aboutEventPub);

            aboutEventPub.DoCount();
            Console.WriteLine($"{aboutEventSub.NumCount}");

        }
    }





}
