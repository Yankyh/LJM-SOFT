using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LJMSOFT.Control
{
    class Controle
    {
        public static DialogResult result;

        public static DialogResult EhLiberar()
        {
            result = MessageBox.Show("Você deseja ativar este registro?", "Liberar",
            MessageBoxButtons.YesNo);

            return result;
        }



    }
}
