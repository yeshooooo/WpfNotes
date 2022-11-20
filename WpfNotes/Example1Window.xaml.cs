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

namespace WpfNotes
{
    /// <summary>
    /// Interaction logic for Example1Window.xaml
    /// </summary>
    public partial class Example1Window : Window
    {
        public Example1Window()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 
            int value1 = int.Parse(this.tb1.Text);
            int value2 = int.Parse(this.tb2.Text);
            this.tb3.Text = (value1 + value2).ToString();
        }
    }
}
