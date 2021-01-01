using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Minomina.WindowsUser
{
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }



        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int IParam);
        private void panelUp_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btCierre_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            btRestaurar.Visible = false;
            button1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            button1.Visible = false;
            btRestaurar.Visible = true;
        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
