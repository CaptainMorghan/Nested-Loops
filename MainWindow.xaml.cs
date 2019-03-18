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

namespace Nested_loops
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            for (int j = 0; j < 11; j++)
            {
                for (int i = (int)'A'; i < (int)'Z'; i++)
                {
                    lblOutput.Content += ((char)i).ToString() + j.ToString() + "\t";

                }
               

                lblOutput.Content += Environment.NewLine;
            }
        }
    }
}
