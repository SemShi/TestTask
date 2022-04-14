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
    /// Логика взаимодействия для Level2_page.xaml
    /// </summary>
    public partial class Level2_page : Page
    {
        Models.AppContext appContext;
        public Level2_page()
        {
            InitializeComponent();
            appContext = new Models.AppContext();
            appContext.streets.Load();
            streetsGrid.ItemsSource = appContext.streets.Local.ToBindingList();
        }

        private void streetsGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Level3_page();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Level1_page();
        }
    }
}
