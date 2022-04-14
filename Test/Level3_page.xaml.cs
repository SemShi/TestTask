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
using System.Data.Entity;

namespace Test
{
    /// <summary>
    /// Логика взаимодействия для Level3_page.xaml
    /// </summary>
    public partial class Level3_page : Page
    {
        Models.AppContext appContext;
        public Level3_page()
        {
            InitializeComponent();
            appContext = new Models.AppContext();
            appContext.houses.Load();
            housesGrid.ItemsSource = appContext.houses.Local.ToBindingList();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Level2_page();
        }

        private void housesGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Level4_page();
        }
    }
}
