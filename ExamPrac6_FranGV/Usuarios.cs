using ExamPrac6_FranGV.API;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPrac6_FranGV
{
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }

        #region Controladores de eventos
        private void Controlador_Click(object sender, EventArgs e)
        {
            // Recursos
            Button opcion = (Button)sender;
            string MensajeError = "";
            bool esValido = true; // Inicializado a true previamente

            try
            {
                switch (opcion.Name) 
                {
                    case "buttonAcceder":
                        Acceder();
                        break;
                    case "buttonCargarUsuarios":
                        cargar();
                        break;
                }
            }
            catch(Exception Error)
            {
                esValido = false;
                MensajeError = Error.Message;
            }
            finally
            {
                if (!esValido)
                {
                    API.API_UI.MostrarError(MensajeError);
                    textBoxContrasenia.Text = "";
                }
                else
                {
                    textBoxUsuario.Text = "";
                    textBoxContrasenia.Text = "";
                }
            }
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {

            // Recursos
            string MensajeError = "";
            bool esValido = true; // Inicializado a true previamente

            try
            {
                // Cada vez que el programa se inicie, el verificará que el directorio exista,
                // Si no es así, se creará 
                API.API_File.CrearDirectorio();
            }
            catch (Exception Error)
            {
                esValido = false;
                MensajeError = Error.Message;
            }
            finally
            {
                if (!esValido) API.API_UI.MostrarError(MensajeError);
            }

        }

        private void comboBoxListaUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recursos
            string MensajeError = "";
            bool esValido = true; // Inicializado a true previamente

            try
            {
                // Mostrar el usuario seleccionado
                API_UI.MostrarMensaje($"El usuario {comboBoxListaUsuarios.Text} está registrado");
            }
            catch (Exception Error)
            {
                esValido = false;
                MensajeError = Error.Message;
            }
            finally
            {
                if (!esValido) API.API_UI.MostrarError(MensajeError);
            }
        }
        #endregion

        #region Funcionalidades Botones

        private void Acceder()
        {
            // Recursos
            string User = textBoxUsuario.Text;
            string password = textBoxContrasenia.Text;

            // Validar que la contraseña y usuario esten correctos
            Validaciones.ValidarNombreUsuario(User);
            Validaciones.ValidarContrasenia(password);


            // Las acciones del switch variarán si existe o no el usuario
            switch (API_File.VerificarExistenciaFichero(User))
            {
                // Validar que la contraseña sea correcta
                // En caso de que el usuario exista
                case true:
                    UsuarioExistente(User);
                    break;



                // En caso de que no exista
                case false:

                    UsuarioInexistente(User, password);
                    break;
            }

        }
        #region Funcionalidades Acceder
        private static void UsuarioInexistente(string User, string password)
        {
            // Creamos el fichero del usuario y
            // mostramos el mensaje de que el proceso de a producido correctamente
            API.API_File.CrearUsuario(User, password);
            API_UI.MostrarMensaje($"El usuario {User} a sido añadido correctamente");
        }

        private void UsuarioExistente(string User)
        {
            // En caso de que el usuario exista,
            // esto lo hacemos consultando el fichero del usuario dado y lo comparamos,
            // comparamos el contenido del fichero con el textbox
            if (textBoxContrasenia.Text.Equals(API_File.ConsultarFichero(User)))
            {
                API_UI.MostrarMensaje($"Bienvenido {User}, usted tiene acceso.");
            }
            else
            {
                throw new Exception("Contraseña incorrecta, vuelva a introducirla");
            }
        }
        #endregion




        private void cargar()
        {
            // Lipiamos el comoboBox para que no se acumulen datos
            comboBoxListaUsuarios.Items.Clear();
            comboBoxListaUsuarios.Text = "";

            comboBoxListaUsuarios.Items.AddRange(API_File.ConsultarDirectorio());
            
        }

        #endregion

    }
}
