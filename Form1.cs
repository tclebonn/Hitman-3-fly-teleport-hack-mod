using Memory;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Hitman3Reworked
{
    public partial class Form1 : Form
    {
        readonly string hitmanProcessName = "hitman3.exe";
        public Mem mem = new Mem();
        bool processOpened = false;

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int id = m.WParam.ToInt32();
                if (id == 0 || id == 1 || id == 2)
                {
                    KeysPressFunctions(id);
                }
                else if (id == 7 || id == 4 || id == 8 || id == 5 || id == 9 || id == 6)
                {
                    ManagePlayerMovements(id);
                }

                else if(id == 3)
                {
                    userControlTeleport1.TPToPosition(false);
                }
            }
            base.WndProc(ref m);
        }
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(20,20,20);
            panel1.BackColor = Color.FromArgb(20,20,20);
            panel4.BackColor = Color.FromArgb(30, 30, 30);
            RegisterHotKey(this.Handle, 0, 0, (int)Keys.NumPad0);
            RegisterHotKey(this.Handle, 1, 0, (int)Keys.NumPad1);
            RegisterHotKey(this.Handle, 2, 0, (int)Keys.NumPad2); // active checkboxes

            RegisterHotKey(this.Handle, 7, 0, (int)Keys.NumPad7);
            RegisterHotKey(this.Handle, 4, 0, (int)Keys.NumPad4); // increase decrease  x axis 

            RegisterHotKey(this.Handle, 8, 0, (int)Keys.NumPad8);
            RegisterHotKey(this.Handle, 5, 0, (int)Keys.NumPad5); // increase decrease z axis

            RegisterHotKey(this.Handle, 9, 0, (int)Keys.NumPad9);
            RegisterHotKey(this.Handle, 6, 0, (int)Keys.NumPad6); // inc decr y axis

            RegisterHotKey(this.Handle, 3, 0, (int)Keys.NumPad3); // tp to saved position
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
    
            userControlMainPage1.Show();
            userControlTeleport1.Hide();
        }

        private void KeysPressFunctions(Int32 keyId)
        {
            userControlMainPage1.KeysPressFunctions(keyId);
        }

        private void ManagePlayerMovements(int id)
        {
            userControlMainPage1.ManagePlayerMovements(id);
        }

        private void ClickMainButton(object sender, EventArgs e)
        {
            userControlMainPage1.Show();
            userControlTeleport1.Hide();
        }

        private void ClickTeleportButton(object sender, EventArgs e)
        {
            userControlMainPage1.Hide();
            userControlTeleport1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

}
