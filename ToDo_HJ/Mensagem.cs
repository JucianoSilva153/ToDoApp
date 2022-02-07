using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo_HJ
{
    class Mensagem
    {
        private Form Formulario { get; set; }
        IntPtr Ptr;
        
        public DialogResult MostrarMensagem()
        {
            Form M = new Form();
            Button b = new Button();
            M.Owner = Formulario;
            M.Width = 200;
            M.Height = 100;
            M.StartPosition = FormStartPosition.CenterParent;
            M.Controls.Add(b);

            b.Text = "OK";
            M.Show();
            return b.DialogResult;
        }

        public Mensagem(Form Form)
        {
            Formulario = Form;
        }

    }
}
