using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1;

namespace Task4
{
    internal class Presenter
    {
        MainWindow MainWindow;
        Model model;
        public Presenter(MainWindow window)
        {
            MainWindow = window;
            model = new Model();
        }



    }
}
