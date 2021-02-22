using System;
using NLog;
using System.IO;
using System.Collections.Generic;

namespace MovieLibrary
{
    class Program
    {           
       
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            menu.MenuSelection();
        }
    }
}