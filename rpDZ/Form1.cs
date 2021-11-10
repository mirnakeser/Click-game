using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.IO;

namespace rpDZ
{
    public partial class Form1 : Form
    {
        int bodovi;
        int kontrole;
        int povecaj;
        string mousename;
        string gamepadname;
        string robotname;
        string path;
        public Form1()
        {
            InitializeComponent();
            
           
            mousename = "Mouse.png";
            gamepadname = "Gamepad.png";
            robotname = "Robot.png";
            path = Directory.GetParent(Environment.CurrentDirectory).Parent.FullName + @"\data\";
            //path = Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.FullName, @"\data\", mousename);
            
            start();        
            
        }
        
        private void newGametoolStripButton_Click(object sender, EventArgs e)
        {
            start();
        }
        public void start()
        {
            bodovi = 0;
            brojBodovaLabel.Text = "Total: " + bodovi;
            textBox1.Clear();
            textBox1.Text = DateTime.Now.ToString("hh:mm") + " New game started." + System.Environment.NewLine;
            povecaj = 0;
            kontrole = 0;
            splitContainer2.Panel1.Controls.Clear();
        }

        private void povecajBodoveButton_Click(object sender, EventArgs e)
        {

            bodovi++;
            brojBodovaLabel.Text = "Total: " + bodovi;
           
            dodajKontrolu();
            updateKontrola();
        }

        private void otkljucaniObjekt3_Load(object sender, EventArgs e)
        {

        }

        private void otkljucaniObjekt2_kupljeno(object sender, EventArgs e)
        {

        }

        private void brojBodovaLabel_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void otkljucaniObjekt1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bodovi += povecaj;

            brojBodovaLabel.Text = "Total: " + bodovi;
            dodajKontrolu();
            updateKontrola();

        }

        private void mouseOtkljucaniObjekt_kupljeno(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
        public void dodajKontrolu()
        {
            //splitContainer2.Panel1
            if(bodovi >= 10 && kontrole == 0)
            {
                var mouse = new otkljucaniObjekt();
                mouse.ime = "Mouse";
                mouse.koliko = 0;
                mouse.cijena = 10;
                mouse.bodova = bodovi;
                mouse.putanja = path + mousename;
               
                mouse.Dock = DockStyle.Top;

                mouse.kupljeno += (sender, e) =>
                {
                    var s = (otkljucaniObjekt)sender;
                    bodovi -= s.cijena;
                    s.bodova = bodovi;
                    s.cijena = (int)(s.cijena * 1.15);
                    s.koliko++;
                    povecaj++;
                    brojBodovaLabel.Text = "Total: " + bodovi;
                    textBox1.Text += DateTime.Now.ToString("hh:mm") + " Mouse: " + s.koliko.ToString() + System.Environment.NewLine;
                    

                };
                kontrole++;
                splitContainer2.Panel1.Controls.Add(mouse);
            }

            if (bodovi >= 30 && kontrole == 1)
            {
                var gamepad = new otkljucaniObjekt();
                gamepad.ime = "Gamepad";
                gamepad.koliko = 0;
                gamepad.cijena = 30;
                gamepad.bodova = bodovi;
                gamepad.putanja = path + gamepadname;
                gamepad.Dock = DockStyle.Top;

                gamepad.kupljeno += (sender, e) =>
                {
                    var s = (otkljucaniObjekt)sender;
                    bodovi -= s.cijena;
                    s.bodova = bodovi;
                    s.cijena = (int)(s.cijena * 1.15);
                    s.koliko++;
                    povecaj += 5;
                    brojBodovaLabel.Text = "Total: " + bodovi;
                    textBox1.Text += DateTime.Now.ToString("hh:mm") + " Gamepad: " + s.koliko.ToString() + System.Environment.NewLine;

                };
                kontrole++;
                splitContainer2.Panel1.Controls.Add(gamepad);

            }
            if (bodovi >= 300 && kontrole == 2)
            {
                var robot = new otkljucaniObjekt();
                robot.ime = "Gamepad";
                robot.koliko = 0;
                robot.cijena = 300;
                robot.bodova = bodovi;
                robot.putanja = path + robotname;
                robot.Dock = DockStyle.Top;

                robot.kupljeno += (sender, e) =>
                {
                    var s = (otkljucaniObjekt)sender;
                    bodovi -= s.cijena;
                    s.bodova = bodovi;
                    s.cijena = (int)(s.cijena * 1.15);
                    s.koliko++;
                    povecaj += 25;
                    brojBodovaLabel.Text = "Total: " + bodovi;
                    textBox1.Text += DateTime.Now.ToString("hh:mm") + " Robot: " + s.koliko.ToString() + System.Environment.NewLine;

                };
                kontrole++;
                splitContainer2.Panel1.Controls.Add(robot);

            }

        }
        void updateKontrola()
        {
            if (kontrole >= 1)
            {
                var m = (otkljucaniObjekt)splitContainer2.Panel1.Controls[0];
                m.bodova = bodovi;                   

            }
            if (kontrole >= 2)
            {
                var g = (otkljucaniObjekt)splitContainer2.Panel1.Controls[1];
                g.bodova = bodovi;
            }
            if (kontrole == 3)
            {
                var r = (otkljucaniObjekt)splitContainer2.Panel1.Controls[2];
                r.bodova = bodovi;
            }
        }
    }
}
