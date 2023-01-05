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
using System.Windows.Shapes;

namespace LayoutControlProjectApp
{
    /// <summary>
    /// Interaction logic for WindowProperties.xaml
    /// </summary>
    public partial class WindowProperties : Window
    {
        public WindowProperties()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            b1.Content = "this button is clicked";
        }
    }
}
