using System;
using System.Collections.Generic;
using System.Text;

namespace Task_4._1
{
    public interface ITreeElement
    {
        ITreeElement Left
        {
            get;
            set;
        }
        ITreeElement Right
        {
            get;
            set;
        }
        char Value
        {
            get;
            set;
        }
        void Print();
        int Count();
    }
}
