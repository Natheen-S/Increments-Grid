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

namespace Increments_Grid
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

        private void btn_increment_Click(object sender, RoutedEventArgs e)
        {
            int start_inc = Convert.ToInt32(txtbox_start_inc.Text);
            int end_inc = Convert.ToInt32(txtbox_end_inc.Text);
            int increment = Convert.ToInt32(txtbox_increment.Text);
            {
                for (int i = start_inc; i <= end_inc; i = i + increment)
                {
                    lbl_increresult.Content = lbl_increresult.Content + i.ToString() + ",";
                }
            }
        }

        private void btn_decrement_Click(object sender, RoutedEventArgs e)
        {
            int start_dec = Convert.ToInt32(txtbox_start_dec.Text);
            int end_dec = Convert.ToInt32(txtbox_end_dec.Text);
            int decrement = Convert.ToInt32(txtbox_dec.Text);
            {
                for (int j = start_dec; j>= end_dec; j = j- decrement)
                {
                    lbl_deccreresult.Content = lbl_deccreresult.Content + j.ToString() + ",";
                }
            }
        }
    }
}
