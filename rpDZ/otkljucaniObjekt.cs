using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rpDZ
{
    public partial class otkljucaniObjekt : UserControl
    {
       
        
        public otkljucaniObjekt()
        {
            InitializeComponent();
        }

        private void otkljucaniObjekt_Load()
        {
            
        }

        
        public string putanja
        {
            set { pictureBox1.Image = new Bitmap(value); }           
        }

        public string ime
        {
            get { return imeLabel.Text; }
            set { imeLabel.Text = value; }
        }

        public int koliko
        {
            get { return Int32.Parse(kolikoLabel.Text); }
            set { kolikoLabel.Text = value.ToString(); }

        }

        public int cijena
        {
            get { return Int32.Parse(cijenaLabel.Text); }
            set { cijenaLabel.Text = value.ToString(); }
        }

        public int bodova
        {
            set { if (value >= cijena) button2.Enabled = true;
                  else button2.Enabled = false;
            }
        }

        public event EventHandler kupljeno;

        private void button2_Click(object sender, EventArgs e)
        {
            
                       
        }

        private void cijenaLabel_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (kupljeno != null)
            {
                kupljeno(this, EventArgs.Empty);
            }
        }
    }
}
