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
    /// Interaction logic for InputWindow2.xaml
    /// </summary>
    public partial class InputWindow2 : Window
    {
        public InputWindow2()
        {
            InitializeComponent();
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            // 不一定要在控件上写name，这个sender就是触发事件的控件
            tb.Text = (sender as Slider).Value.ToString();
        }
    }
}
