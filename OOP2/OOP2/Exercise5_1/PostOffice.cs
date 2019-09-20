using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Exercise5_1
{
    public class PostOffice
    {
        private ArrayList ReaderList;
        public event ReadNewsDelegate NewsEvent;
        public void UpdateNews(string news)
        {
            NewsEvent(string news);
        }
    }
}
