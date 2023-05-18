using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calendar
{
    public partial class MainPage : Page
    {
        public static Dictionary <DateTime, List<FoodUserControl>> DFood = new Dictionary <DateTime, List<FoodUserControl>>();
        public MainPage()
        {
            InitializeComponent();
            Calendar.SelectedDate = DateTime.Now;
            Panel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Calendar.SelectedDate = ((DateTime)Calendar.SelectedDate).AddMonths(+1);
            Panel();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Calendar.SelectedDate = ((DateTime)Calendar.SelectedDate).AddMonths(-1);
            Panel();
        }

        public void Panel()
        {
            Day.Children.Clear();

            for (int i = 1; i <= DateTime.DaysInMonth(((DateTime)Calendar.SelectedDate).Year, ((DateTime)Calendar.SelectedDate).Month); i++)
            {
                DayUserControl day = new DayUserControl();
                day.Number.Content = i.ToString();
                day.Image.Source = new BitmapImage(new Uri("images\\dots.png", UriKind.Relative));
                day.DayNum.Click += DayName_Click;
                Day.Children.Add(day);
            }
        }

        private void DayName_Click(object sender, RoutedEventArgs e)
        {
            FrameCheck.Content = new FoodPage();
        }
    }
}
