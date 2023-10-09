using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Grid
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
        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            if(sender == B1)
                popup1.IsOpen = true;
            else if(sender == B2)
                popup2.IsOpen = true;
            else if(sender == B3)
                popup3.IsOpen = true;
            else if( sender == B4)
                popup4.IsOpen = true;
        }
        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            if(sender == B1)
                popup1.IsOpen = false;
            else if(sender == B2)
                popup2.IsOpen = false;
            else if(sender == B3)
                popup3.IsOpen = false;
            else if( sender == B4)
                popup4.IsOpen = false;
        }
    }
}
