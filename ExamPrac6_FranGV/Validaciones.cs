using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPrac6_FranGV
{
    public static class Validaciones
    {
        /// <summary>
        /// Valida que no sea nulo
        /// </summary>
        /// <param name="cadena">cadena</param>
        /// <exception cref="CadenaVaciaException">Cadena nula</exception>
        public static void ValidarCadena(string cadena)
        {
            if (string.IsNullOrEmpty(cadena)) throw new CadenaVaciaException();
        }

        /// <summary>
        /// Validar nombre del usuario, validará su formato
        /// </summary>
        /// <param name="cadena">Cadena</param>
        /// <exception cref="Exception"></exception>
        public static void ValidarNombreUsuario(string cadena)
        {
            ValidarCadena(cadena);

            // Aqui validamos que no tengan tildes,
            // no sean mayusculas, no  tengan caracteres especiales, y no tenga la ñ
            foreach(char caracter in cadena)
            {
                if (char.IsUpper(caracter) || "áéíóúñ".Contains(caracter) || char.IsSymbol(caracter)) throw new Exception("Formato incorrecto");
            }
            // Validar que el usuario tenga al menos 5 caracteres
            if (cadena.Length < 5) throw new Exception("El nombre debe de ser de almenos 5 caracteres"); 

        }

        // Validar que la contraseña tenga exactamente 8 caracteres
        public static void ValidarContrasenia(string contrasenia)
        {
            ValidarCadena(contrasenia);

            if (contrasenia.Length != 8) throw new Exception("La Contraseña debe tener exactamente 8 caracteres");

        }
    }
    public class CadenaVaciaException : Exception
    {
        public CadenaVaciaException() :base("Cadena vacía") { }
        public CadenaVaciaException(string mensaje) : base(mensaje) { }
    }
}
