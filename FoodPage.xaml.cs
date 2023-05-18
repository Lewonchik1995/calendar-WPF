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

namespace calendar
{
    public partial class FoodPage : Page
    {
        public FoodPage()
        {
            InitializeComponent();

            FoodUserControl breakfast = new FoodUserControl();
            breakfast.CheckBoxFood.IsChecked = false;
            breakfast.ImageFood.Source = new BitmapImage(new Uri("images\\breakfast.png", UriKind.Relative));
            breakfast.NameFood.Text = "Завтрак";

            FoodUserControl lunch = new FoodUserControl();
            breakfast.CheckBoxFood.IsChecked = false;
            lunch.ImageFood.Source = new BitmapImage(new Uri("images\\lunch.png", UriKind.Relative));
            lunch.NameFood.Text = "Обед";

            FoodUserControl snack = new FoodUserControl();
            breakfast.CheckBoxFood.IsChecked = false;
            snack.ImageFood.Source = new BitmapImage(new Uri("images\\snack.png", UriKind.Relative));
            snack.NameFood.Text = "Перекус";

            FoodUserControl dinner = new FoodUserControl();
            breakfast.CheckBoxFood.IsChecked = false;
            dinner.ImageFood.Source = new BitmapImage(new Uri("images\\dinner.png", UriKind.Relative));
            dinner.NameFood.Text = "Ужин";

            List<FoodUserControl> food_list = new List<FoodUserControl>() { breakfast, lunch, snack, dinner };
            FoodList.ItemsSource = food_list;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Food.Content = new MainPage();
        }

        private void SandE_Button_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
