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

namespace Increments_Grid
{
    /// <summary>
    /// Interaction logic for ForLoop.xaml
    /// </summary>
    public partial class ForLoop : Window
    {
        public ForLoop()
        {
            InitializeComponent();
        }

        private void Button_CLick(object sender, RoutedEventArgs e)
        {
            StringBuilder focus = new StringBuilder();
            
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        for (int m = 0; m < 4; m++)
                        {
                            for (int n = 0; n < 5; n++)
                            {
                                focus.Append(i.ToString());
                                focus.Append(j.ToString());
                                focus.Append(m.ToString());
                                focus.Append(n.ToString());
                                focus.AppendLine("");
                                lbl_loop.Content = focus.ToString();
                            }
                        }
                    }

                }
            }
        }
    }
}
