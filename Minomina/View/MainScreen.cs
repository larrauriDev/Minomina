using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minomina
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            MaximizedBounds = Screen.FromHandle(Handle).WorkingArea;

        }

        private void btMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
                btMaximizar.Visible = false;
                btNormal.Visible = true;


            }

        }

        private void btNormal_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            btMaximizar.Visible = true;
            btNormal.Visible = false;
        }

        private void CerrarApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wMsg, int wParam, int IParam);
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuGestionHumana_AutoSizeChanged(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {

                btNormal.Visible = false;
                btMaximizar.Visible = true;
            }
            else if (WindowState == FormWindowState.Maximized)
            {

                btNormal.Visible = true;
                btMaximizar.Visible = false;
            }
        }

        private void btNomina_Click(object sender, EventArgs e)
        {

        }

        private void btAdministracion_Click(object sender, EventArgs e)
        {

        }
    }
}
