using _31_05gg.Classes;
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

namespace _31_05gg
{
    /// <summary>
    /// Логика взаимодействия для Best.xaml
    /// </summary>
    public partial class Best : Window
    {
        public Best()
        {
            InitializeComponent();
            
        }
        public void Toback_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            foreach (string S in ClassHelpers.Bestys)
            {
                lstBestys.Items.Add(S);
            }
        }
    }
}
