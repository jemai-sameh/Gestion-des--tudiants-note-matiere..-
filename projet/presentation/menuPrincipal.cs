using projet.presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet.application
{
    
    public partial class menuPrincipal : Form
    {
        Object form = null;

    public menuPrincipal()
        {
            InitializeComponent();

        }


        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous Quitter l'application?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        
        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        

        private void enseignantToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            if (this.MdiChildren.Length > 0)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            }
            
                espaceEnseignant es = new espaceEnseignant();
                form = es;
                es.MdiParent = this;
                es.Show();
            

        }

        private void etudiantToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            }
            
                espaceEtudiant et = new espaceEtudiant();
            form = et;
                et.MdiParent = this;
                et.Show();
            
        }

        private void matiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            }

            espaceFiliere f = new espaceFiliere();
            form = f;
            f.MdiParent = this;
            f.Show();

            
        }

        private void noteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            }
            
                espaceNote et = new espaceNote();
            form = et;
                et.MdiParent = this;
                et.Show();
            
        }

        private void filiereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.MdiChildren.Length > 0)
            {
                foreach (Form childForm in MdiChildren)
                {
                    childForm.Close();
                }
            }
            
                espaceMatiere et = new espaceMatiere();
            form = et;
                et.MdiParent = this;
                et.Show();
            
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void accueilToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.Visible = false;
            new menuPrincipal().Visible = true;
        }

        private void deconnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez vous deconnecter?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Visible = false;
                new authentification().Visible = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new menuPrincipal().Visible = true;

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new propos().Visible = true;

        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Contact().Visible = true;
        }

      
    }
}
