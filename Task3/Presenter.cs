using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    internal class Presenter
    {
        Model model;
        MainWindow view;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;
            this.view.Start += ViewStart;
            this.view.Stop += ViewStop;
            this.view.Reset += ViewReset;
        }

        private void ViewStart(object? sender, EventArgs e)
        {
           
        }
        private void ViewStop(object? sender, EventArgs e)
        {


        }
        private void ViewReset(object? sender, EventArgs e)
        {


        }
    }
}