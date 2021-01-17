using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test04
{
    public partial class Form1 : Form
    {
        Button btnUnique;                    // 1
        

        public Form1()
        {
            InitializeComponent();
        }

        private void CreerPlusieurs()
        {
            for (int k=0; k<10; k++)
            {
                RadioButton btr = new RadioButton();
                grbChoix.Controls.Add(btr);
                btr.Location = new Point(10, 19 + 23 * k);
                btr.Text = ((char)('A' + k)).ToString();
                btr.Click += new System.EventHandler(btr_Click);
            }
        }

        private void btr_Click(object sender, EventArgs e) // 10 boutons, une seule procédure évènementielle
        {
            // le premier argument compte
            RadioButton cbrLettre = (RadioButton)sender;
            txtMessage.Text = cbrLettre.Text;
        }

        private void CreerUnique()   // au chargement, creation d'un bouton géré dans MON code
        {
            btnUnique = new Button();
            Controls.Add(btnUnique);        // vient de Form1.Designer.cs this.Controls.Add(this.txtMessage);
            btnUnique.Location = new Point(12, 12);
            btnUnique.Size = new Size(75, 23);
            btnUnique.TabIndex = 2;
            btnUnique.Text = "Unique";
            btnUnique.Click += new System.EventHandler(btnUnique_Click);

        }

        private void btnUnique_Click(object sender, EventArgs e)
        {
            txtMessage.Text = "Coucou";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreerUnique();                  // apparaît à l'éxécution
            CreerPlusieurs();
        }
    }
}
