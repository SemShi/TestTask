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
    /// Логика взаимодействия для Level4_page.xaml
    /// </summary>
    public partial class Level4_page : Page
    {
        Models.AppContext appContext;
        public Level4_page()
        {
            InitializeComponent();
            appContext = new Models.AppContext();
            appContext.apartments.Load();
            apartmentsGrid.ItemsSource = appContext.apartments.Local.ToBindingList();
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new Level3_page();
        }

        private void FilterButton_Click(object sender, RoutedEventArgs e)
        {
            decimal firstParam = Convert.ToDecimal(textbox1.Text);
            decimal secondParam = Convert.ToDecimal(textbox2.Text);
            appContext = new Models.AppContext();
            appContext.apartments.Load();
            using (appContext)
            {
                var areas = appContext.apartments.Local.ToBindingList().Where(p => p.area >= firstParam && p.area <= secondParam);
                apartmentsGrid.ItemsSource = areas;
            }
            appContext.Dispose();
        }
    }
}
