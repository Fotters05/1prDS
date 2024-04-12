using Praktika1_DataSet.praktika1_datasetDataSetTableAdapters;
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


namespace Praktika1_DataSet
{

    public partial class Second : Page
    {
        SUSHISETSTableAdapter SUSHISETS = new SUSHISETSTableAdapter();
        public Second()
        {
            InitializeComponent();
            SushiDataGrid.ItemsSource = SUSHISETS.GetData();
        }
        private void ShowMainButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Window.GetWindow(this).Close();
        }
    }
}
