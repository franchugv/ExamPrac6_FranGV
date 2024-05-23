using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac6_FranGV.API
{
    public static class API_File
    {
        // CONSTANTES
        private const string DIRECTORIO = "Usuarios_FranGV\\";
        private const string EXTENSION = ".usr";


        #region Crear Ficheros

        /// <summary>
        /// Creador del directorio, en caso de que no exista, se creará el directorio
        /// </summary>
        public static void CrearDirectorio()
        {
            // Recursos
            // En caso de que el directorio no exista, se creará
            if (!Directory.Exists(DIRECTORIO))
            {
                Directory.CreateDirectory(DIRECTORIO);
            }
        }

        /// <summary>
        /// Creador de usuario, crea un archivo con el nombre y contraseña
        /// </summary>
        /// <param name="nombre">Nombre del usuario</param>
        /// <param name="contrasenia">Credenciales del usuario</param>
        /// <exception cref="Exception"></exception>
        public static void CrearUsuario(string nombre, string contrasenia)
        {
            // Recursos
            StreamWriter escritor;

            // Si el usuario ya existe
            // nos lanzara una excepción
           if(VerificarExistenciaFichero(nombre) == true) throw new Exception("Archivo repetido");


            // Creación del fichero
            escritor = File.CreateText(DIRECTORIO+nombre+EXTENSION);

            // Agregar contrasenia
            escritor.WriteLine(contrasenia);

            // Cerramos al escritor
            escritor.Close();
        }

        #endregion

        #region Consultar Ficheros

        /// <summary>
        /// Consulta del directorio
        /// </summary>
        /// <returns>Devuelve un array con el contenido del directorio formateado</returns>
        public static string[] ConsultarDirectorio()
        {
            // Recursos
            string[] ListaUsuarios;
            string aux; // Variable auxiliar y temporal

            // Almacenamos en el array el contenido del directorio:
            // Directorio/nombre.extension
            ListaUsuarios = Directory.GetFiles(DIRECTORIO);

            // Ahora vamos a limpiar el nombre:
            // Directorio/nombre.extension --> nombre
            for(int indice = 0; indice < ListaUsuarios.Length; indice++)
            {
                aux = ListaUsuarios[indice];

                aux = aux.Substring(aux.IndexOf("\\") + 1);
                aux = aux.Substring(0, aux.IndexOf("."));

                ListaUsuarios[indice] = aux;
            }

            return ListaUsuarios;
        }

        /// <summary>
        /// Consulta del fichero
        /// </summary>
        /// <param name="nombre">Nombre de usuario</param>
        /// <returns>devuelve la primera linea del fichero, la contraseña</returns>
        public static string ConsultarFichero(string nombre)
        {
            // Recursos
            StreamReader lector;
            string contenido; // Contenido del fichero

            lector = File.OpenText(DIRECTORIO+nombre+EXTENSION);

            contenido = lector.ReadLine();

            lector.Close();

            return contenido;

            
        }


        #endregion



        #region Validar Ficheros

        /// <summary>
        /// Validar Existencia del fichero
        /// </summary>
        /// <param name="fichero">Nombre del fichero o usuario</param>
        /// <returns>En caso de que no exista devolverá un false, si existe será true</returns>
        public static bool VerificarExistenciaFichero(string fichero)
        {
            string aux = "";
            bool esValido = false; 

            // Remover mayúsculas y espacios
            fichero = fichero.ToLower().Trim();

            foreach (string cadena in ConsultarDirectorio())
            {
                // Remover mayusculas y espacios
                aux = cadena.Trim().ToLower();

                if (fichero.Equals(aux)) esValido = true;
            }

            return esValido;
        }

        #endregion


    }
}
