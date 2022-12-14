using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZH_CM8IHC
{
    public partial class Diakhozzaad : Form
    {
        public Diakhozzaad()
        {
            InitializeComponent();
        }

        private void buttonok_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void buttoncancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void textBoxid_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxid.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxid.Text, "Nem lehet üres, számot kell megadni ami nincs használva");
            }
        }

        private void textBoxid_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxid, "");
        }

        private void textBoxnev_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxnev.Text ))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBoxnev.Text, "Nem lehet üres");
            }
        }

        private void textBoxnev_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(textBoxnev, "");
        }
    }
}
