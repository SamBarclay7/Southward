using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Southward
{
    /// <summary>
    /// Interaction logic for AddEnemy.xaml
    /// </summary>
    public partial class AddEnemy : Window
    {
        Object x;
        int num;
        public AddEnemy()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            if(cbxType.Equals("FireDemon"))
            {
                x = new FireDemon();
            }
        }

        public Object getEnemy()
        {
            return x;
        }

        public int getNum()
        {
            return num;
        }
    }
}
