using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace UD06Actividad01
{
    public partial class MainWindow : Window
    {
        ObservableCollection<Mensajes> mensajes;
        public MainWindow()
        {
            InitializeComponent();

            mensajes = new ObservableCollection<Mensajes>();


            listaMensajesItemsControl.DataContext = mensajes;
        }

        private void Enviar_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            mensajes.Add(new Mensajes(Mensajes.Emisor.Usuario, mensajeUsuarioTextBox.Text));
            mensajes.Add(new Mensajes(Mensajes.Emisor.Bot));
            mensajeUsuarioTextBox.Text = "";
        }

        private void Enviar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = mensajeUsuarioTextBox != null && mensajeUsuarioTextBox.Text != "";
        }

        private void NuevaConversacion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            if (mensajes.Count > 0)
                mensajes = new ObservableCollection<Mensajes>();

            listaMensajesItemsControl.DataContext = mensajes;
        }

        private void NuevaConversacion_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = listaMensajesItemsControl.Items.Count > 0;
        }

        private void Guardar_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Guardar_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = listaMensajesItemsControl.Items.Count > 0;
        }

        private void Salir_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void Salir_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }

        private void Configuracion_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            
        }

        private void Configuracion_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
        }

        private void ComprobarConexion_Executed(object sender, ExecutedRoutedEventArgs e)
        {

        }

        private void ComprobarConexion_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = true;
        }
    }
}
