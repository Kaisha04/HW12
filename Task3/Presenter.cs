using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;
using System.Windows.Threading;

namespace Task3
{
    internal class Presenter
    {
        Model model;
        MainWindow view;
        DispatcherTimer timer;

        public Presenter(MainWindow mainWindow)
        {
            this.model = new Model();
            this.view = mainWindow;
            this.view.Start += ViewStart;
            this.view.Stop += ViewStop;
            this.view.Reset += ViewReset;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(30);
            timer.Tick += TimerTick;
        }

        private void ViewStart(object? sender, EventArgs e)
        {
            model.Start();
            timer.Start();
        }
        private void ViewStop(object? sender, EventArgs e)
        {
            model.Stop();
            timer.Stop();
            UpdateViewTime();
        }
        private void ViewReset(object? sender, EventArgs e)
        {
            model.Reset();
            UpdateViewTime();
        }
        private void TimerTick(object? sender, EventArgs e)
        {
       
            UpdateViewTime();
        }

        private void UpdateViewTime()
        {
            TimeSpan time = model.GetTime();

            string timeText =  string.Format("{0:hh\\:mm\\:ss}", time);

            view.UpdateTime(timeText);
        }
    }
}