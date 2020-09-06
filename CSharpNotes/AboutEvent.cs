using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpNotes
{

    delegate void Handler();

    class AboutEventPub
    {
        public event Handler CounterNum;  //声明事件

        public void DoCount()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 12 == 0 && CounterNum != null)
                {
                    CounterNum();  //触发事件
                }
            }
        }

    }

    class AboutEventSub
    {
        public int NumCount { get; private set; } = 0;
        public AboutEventSub(AboutEventPub aboutEventPub)
        {
            //订阅事件
            aboutEventPub.CounterNum += DealEvent;
        }

        void DealEvent()  //事件处理程序
        {
            NumCount++;
        }
    }


}
