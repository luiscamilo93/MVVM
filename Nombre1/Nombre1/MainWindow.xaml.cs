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

namespace Nombre1
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            txtFirstName.TextChanged += TxtFirstName_TextChanged;
            txtLastName.TextChanged += TxtLastName_TextChanged;
        }

        private void TxtFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarNombreCompleto();
        }

        private void TxtLastName_TextChanged(object sender, TextChangedEventArgs e)
        {
            ActualizarNombreCompleto();
        }

        private void ActualizarNombreCompleto()
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;

            string fullName = $"{firstName} {lastName}";

            txtFullName.Text = fullName;
        }
    }
}