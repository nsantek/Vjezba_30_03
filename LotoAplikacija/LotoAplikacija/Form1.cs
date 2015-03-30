using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LotoAplikacija
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            loto = new Loto();
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(txtUplaceniBroj1.Text);
            vrijednosti.Add(txtUplaceniBroj2.Text);
            vrijednosti.Add(txtUplaceniBroj3.Text);
            vrijednosti.Add(txtUplaceniBroj4.Text);
            vrijednosti.Add(txtUplaceniBroj5.Text);
            vrijednosti.Add(txtUplaceniBroj6.Text);
            vrijednosti.Add(txtUplaceniBroj7.Text);

            bool ispravnaKombinacija ==Loto.UnesiUplaceneBrojeve(vrijednosti);
            if(ispravnaKombinacija==true)
            {
                btnOdigraj.Enabled=true;
            }
            else{
                btnOdigraj.Enabled==false;
                Message.Show("Kombinacija uplaćenih brojeva nije ispravna!");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            Loto.GenerirajDobitnuKombinaciju();

            txtDobitniBroj1.Text = loto.DobitniBrojevi[0].ToString();
            txtDobitniBroj1.Text = loto.DobitniBrojevi[1].ToString();
            txtDobitniBroj1.Text = loto.DobitniBrojevi[2].ToString();

            txtDobitniBroj1.Text = loto.DobitniBrojevi[3].ToString();

            txtDobitniBroj1.Text = loto.DobitniBrojevi[4].ToString();

            txtDobitniBroj1.Text = loto.DobitniBrojevi[5].ToString();
            txtDobitniBroj1.Text = loto.DobitniBrojevi[6].ToString();

            int brojPogodaka = loto.IzracunajBrojPogodaka();
            lblBrojPogodaka.Text = brojPogodaka.ToString();

        }

    }
}
