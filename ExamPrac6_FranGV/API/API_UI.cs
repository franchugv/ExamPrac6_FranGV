using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamPrac6_FranGV.API
{
    public static class API_UI
    {
        public static void MostrarError(string error)
        {
            MessageBox.Show($"Error: {error}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        public static void MostrarMensaje(string cadena)
        {
            MessageBox.Show(cadena, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
