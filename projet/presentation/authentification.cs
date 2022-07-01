using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet.application
{
    public partial class authentification : Form
    {
        public authentification()
        {
            InitializeComponent();
        }

        private void connecter_Click(object sender, EventArgs e)
        {
            if (login.Text != "" && password.Text != "")
            {
                if (login.Text.Equals("root") && password.Text.Equals("root"))
                {

                    this.Visible = false;
                    new menuPrincipal().Visible = true;
                }
                else
                {
                    MessageBox.Show("utilisateur ou mot de passe non valide");
                    return;
                }
            }
            else
            {
                MessageBox.Show("remplir tout les champs");
                return;
            }

        }
    }
}
