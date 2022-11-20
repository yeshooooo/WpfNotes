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
    /// Interaction logic for ButtonWindow.xaml
    /// </summary>
    public partial class ButtonWindow : Window
    {
        public ButtonWindow()
        {
            InitializeComponent();
        }
        int value = 0;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // 点击后切换按钮文字
            // this.btn 就可以拿到Name标记的对象
            //this.btn.Content = "Hello Jovan";
            value++;
            this.tb.Text = value.ToString();
            
        }

        private void RepeatButton_Click(object sender, RoutedEventArgs e)
        {
            // 点击之后改变textblock
            value++;
            this.tb.Text = value.ToString();
        }
    }
}
