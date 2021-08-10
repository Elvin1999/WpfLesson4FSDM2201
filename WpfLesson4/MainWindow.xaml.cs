using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfLesson4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //prgbar.IsIndeterminate = true;

            //lstbox.ItemsSource = GetCars();
          //  lstbox.SelectedIndex = 0;
        }
        public List<Car> GetCars()
        {
            return new List<Car>
            {
                new Car
                {
                     Model="E-200",
                     Vendor="Mercedes",
                     Year=2021
                },
                new Car
                {
                     Model="I8",
                     Vendor="BMW",
                     Year=2019
                },
                new Car
                {
                     Model="Mustang",
                     Vendor="Ford",
                     Year=2015
                }
                ,new Car
                {
                     Model="Supra",
                     Vendor="Toyota",
                     Year=2019
                },
                new Car
                {
                     Model="GTR",
                     Vendor="Nissan",
                     Year=2015
                },
                new Car
                {
                     Model="I8",
                     Vendor="BMW",
                     Year=2019
                },
                new Car
                {
                     Model="Mustang",
                     Vendor="Ford",
                     Year=2015
                }
                ,new Car
                {
                     Model="Supra",
                     Vendor="Toyota",
                     Year=2019
                },
                new Car
                {
                     Model="GTR",
                     Vendor="Nissan",
                     Year=2015
                }
            };
        }
        private void downBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (prgbar.Value > prgbar.Minimum)
            //{
            //    --prgbar.Value;
            //}
        }

        private void upBtn_Click(object sender, RoutedEventArgs e)
        {
            //if (prgbar.Value < prgbar.Maximum)
            //{
            //    ++prgbar.Value;
            //}
        }
        DispatcherTimer dispatcherTimer = new DispatcherTimer();

        private void startBtn_Click(object sender, RoutedEventArgs e)
        {
            dispatcherTimer.Interval = new TimeSpan(0, 0, 0, 0, 200);
            dispatcherTimer.Tick += DispatcherTimer_Tick;
            dispatcherTimer.Start();
        }

        private void DispatcherTimer_Tick(object sender, EventArgs e)
        {
            //if (prgbar.Value < prgbar.Maximum)
            //{
            //    ++prgbar.Value;
            //}
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //txtblock1.Text = Convert.ToInt32(slider.Value).ToString();
            //txtblock2.Text = Convert.ToInt32(slider.Value).ToString();
        }

        private void TabItem_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("Salam");
        }

        private void lstbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var car = lstbox.SelectedItem as Car;
            //if (car != null)
            //{
            //    modelTxtBlock.Text = $"Model {car.Model}";
            //    vendorTxtBlock.Text = $"Vendor {car.Vendor}";
            //    yearTxtBlock.Text = $"Year {car.Year}";
            //}

            //modelTxtBlock.Text = $"Model ".PadLeft(8);
            //vendorTxtBlock.Text = $"Vendor ".PadLeft(8);
            //yearTxtBlock.Text = $"Year ".PadLeft(8);

            //var carObjects = lstbox.SelectedItems;

            //foreach (var item in carObjects)
            //{
            //    if(item is Car car)
            //    {
                 
            //        modelTxtBlock.Text += car.Model + " ".PadLeft(12);
            //        vendorTxtBlock.Text += car.Vendor + " ".PadLeft(12);
            //        yearTxtBlock.Text += car.Year.ToString() + " ".PadLeft(7);
            //    }
            //}

        }

        private void cmbbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var c = cmbbox.SelectedItem as ComboBoxItem;
            var stackPanel = c.Content as StackPanel;
            foreach (var item in stackPanel.Children)
            {
                if(item is TextBlock tb)
                {
                    ScaleTransform scaleTransform1 = new ScaleTransform(1,2);

                    //cmbbox.RenderTransform = scaleTransform1;
                  //  MessageBox.Show(tb.Text);
                }
            }
        }
    }
}
