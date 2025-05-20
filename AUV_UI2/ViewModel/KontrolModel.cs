using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using System;
using System.Timers;
using System.Windows.Threading;

namespace AquaDesk.ViewModel
{
    public class KontrolModel : ViewModelBase
    {
        public PlotModel MyPlotModel1 { get; set; }
        public PlotModel MyPlotModel2 { get; set; }
        public PlotModel MyPlotModel3 { get; set; }
        public PlotModel MyPlotModel4 { get; set; }

        private LineSeries line1, line2, line3, line4;
        private System.Timers.Timer timer;
        private double time = 0;
        private Random rnd = new Random();

        public KontrolModel()
        {
            // Grafikler
            MyPlotModel1 = CreateModel("Sinüs");
            MyPlotModel2 = CreateModel("Cosinüs");
            MyPlotModel3 = CreateModel("Rastgele");
            MyPlotModel4 = CreateModel("Artan Değer");

            // Seriler
            line1 = new LineSeries { Title = "Sin", Color = OxyColors.Red };
            line2 = new LineSeries { Title = "Cos", Color = OxyColors.Green };
            line3 = new LineSeries { Title = "Rand", Color = OxyColors.Blue };
            line4 = new LineSeries { Title = "Line", Color = OxyColors.Orange };


            MyPlotModel1.Series.Add(line1);
            MyPlotModel2.Series.Add(line2);
            MyPlotModel3.Series.Add(line3);
            MyPlotModel4.Series.Add(line4);

            // Timer
            timer = new System.Timers.Timer(300);
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private PlotModel CreateModel(string title)
        {
            var model = new PlotModel
            {
                Background = OxyColors.Transparent,           // Arka plan transparan  
                TextColor = OxyColors.White,                  // Genel metin rengi  
                PlotAreaBorderColor = OxyColors.White         // Grafik kenar çizgisi beyaz  
            };

            // Eksenler için de beyaz renk ayarı  
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White,
                AxislineColor = OxyColors.White
            });
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                TextColor = OxyColors.White,
                TicklineColor = OxyColors.White,
                AxislineColor = OxyColors.White
            });
            return model;
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            App.Current.Dispatcher.Invoke(() =>
            {
                double sin = Math.Sin(time);
                double cos = Math.Cos(time);
                double rand = rnd.NextDouble();
                double linear = time;

                AddPoint(line1, time, sin, MyPlotModel1);
                AddPoint(line2, time, cos, MyPlotModel2);
                AddPoint(line3, time, rand, MyPlotModel3);
                AddPoint(line4, time, linear, MyPlotModel4);

                time += 0.1;
            });
        }

        private void AddPoint(LineSeries line, double x, double y, PlotModel model)
        {
            line.Points.Add(new DataPoint(x, y));
            if (line.Points.Count > 100)
                line.Points.RemoveAt(0);
            model.InvalidatePlot(true);
        }
    }
}