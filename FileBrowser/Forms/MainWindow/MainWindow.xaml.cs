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
using System.Windows.Controls.Ribbon;

namespace FileBrowser
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void window_Closing(object sender, System.ComponentModel.CancelEventArgs args)
        {
            MessageBoxResult result = 
                MessageBox.Show(this, "Are you sure?\nDo you want to quit?", "Closing FileBrowser...",
                MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.No)
                args.Cancel = true;
        }

        private void exitAppMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        } 
    }
}
