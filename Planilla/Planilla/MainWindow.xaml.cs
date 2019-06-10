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

namespace Planilla
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string nombre = Nombre del Empleado;
            string id = Identidad;
            decimal dedu = (Convert.ToDecimal(horasTrabajadas.Text) * Convert.ToDecimal(pagoPorHora.Text));
            decimal ex = (Convert.ToDecimal(horasExtras.Text) * Convert.ToDecimal(pagoHorasExtras.Text));
            decimal IH = (((Convert.ToDecimal(horasTrabajadas.Text) * Convert.ToDecimal(pagoPorHora.Text)) * Convert.ToDecimal(0.04)));
            decimal RA = (((Convert.ToDecimal(horasTrabajadas.Text) * Convert.ToDecimal(pagoPorHora.Text)) * Convert.ToDecimal(0.035)));
            decimal PT = ((dedu + ex) - (IH + RA));
            MessageBox.Show("Nombre: " + nombre + "\nIdentidad: " + id + "\nSueldo sin deducciones: " + dedu + "\nSueldo Horas Extras: " + ex + "\nDeducciones IHSS: " + IH + "\nDeducciones RAP: " + RA + "\nPago Total: " + PT);
        }
    }
}