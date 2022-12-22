using ContactApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactView mainView = new ContactView();
            mainView.run();
        }
    }
}
