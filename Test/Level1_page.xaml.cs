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
    /// Логика взаимодействия для Level1_page.xaml
    /// </summary>
    public partial class Level1_page : Page
    {
        Models.AppContext appContext;
        public Level1_page()
        {
            InitializeComponent();
            appContext = new Models.AppContext();
            appContext.cities.Load();
            citiesGrid.ItemsSource = appContext.cities.Local.ToBindingList();
        }

        private void DataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Main.Content = new Level2_page();
        }
    }
}
