using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar.Schedule;
using DevComponents.DotNetBar;
using DevComponents.Schedule.Model;

namespace Hostelia
{
    public partial class Login : DevComponents.DotNetBar.Metro.MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ingresar_Click(object sender, EventArgs e)
        {
            if (txt_usuario.Text == "admin" && txt_password.Text == "admin") 
            { 
                app.dashboard form = new app.dashboard();
                form.Show();
                this.Hide();
                MessageBox.Show("Bienvenido a Hostelia, " + txt_usuario.Text);
                

            }
            else
            {
                MessageBox.Show("Autenticacion Incorrecta");
            }
        }
    }
}
