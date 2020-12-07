using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minomina.Helpers
{
    class HelperForms
    {
        public static void ClearControllers(Form crt)
        {

            if (crt != null)
                foreach (Control con in crt.Controls)
                {
                    if (con is TextBox)
                    {
                        ((TextBox)con).Clear();
                    }
                    else if (con is ComboBox)
                    {
                        ((ComboBox)con).SelectedIndex = -1;
                        ((ComboBox)con).Text = "";

                    }
                    else if (con is DateTimePicker)
                    {
                        //((DateTimePicker)con).;

                    }
                    else if (con is Panel)
                    {

                        ClearPanel(((Panel)con));
                    }
                    else if (con is DataGridView)
                    {

                        // ((DataGridView)con).Rows.Clear();

                    }
                }
        }
        public static void ClearGroupBox(GroupBox gb)
        {
            foreach (Control con in gb.Controls)
            {
                if (con is TextBox)
                {
                    ((TextBox)con).Clear();
                }
                else if (con is ComboBox)
                {
                    ((ComboBox)con).Text = "";
                }
                else if (con is DateTimePicker)
                {
                    ((DateTimePicker)con).Text = "";
                }

            }

        }
        public static void ClearPanel(Panel pn)
        {
            foreach (Control con in pn.Controls)
            {
                if (con is TextBox)
                {
                    ((TextBox)con).Clear();
                }
                else if (con is ComboBox)
                {
                    ((ComboBox)con).SelectedIndex = -1;
                }
                else if (con is DateTimePicker)
                {
                    ((DateTimePicker)con).Text = "";
                }

            }

        }
        public static bool CheckEmpy(Form crt)
        {

            foreach (Control con in crt.Controls)
            {
                if (con is TextBox)
                {
                    if (((TextBox)con).Name != "tbID")
                        if (((TextBox)con).Text == "")
                        {
                            MesEmpy();
                            return true;
                        }

                }
                else if (con is ComboBox)
                {
                    if (((ComboBox)con).Text == "")
                    {
                        MesEmpy();
                        return true;
                    }
                }
                else if (con is GroupBox)
                {
                    foreach (Control cx in con.Controls)
                    {
                        if (cx is TextBox)
                        {
                            if (((TextBox)cx).Text == "")
                            {
                                MesEmpy();
                                return true;
                            }
                        }

                        else if (cx is ComboBox)
                        {
                            if (((ComboBox)cx).Text == "")
                            {
                                MesEmpy();
                                return true;
                            }
                        }

                        else if (cx is DateTimePicker)
                        {
                            if (((DateTimePicker)cx).Text == "")
                            {
                                MesEmpy();
                                return true;
                            }
                        }

                    }

                }
                else if (con is Panel)
                {
                    foreach (Control item in con.Controls)
                    {
                        if (item is TextBox)
                        {
                            if (((TextBox)item).Name != "tbID")
                                if (((TextBox)item).Text == "")
                                {
                                    MesEmpy();
                                    return true;
                                }

                        }
                        else if (item is ComboBox)
                        {
                            if (((ComboBox)item).Text == "")
                            {
                                MesEmpy();
                                return true;
                            }
                        }
                        else if (item is GroupBox)
                        {
                            foreach (Control cx in item.Controls)
                            {
                                if (cx is TextBox)
                                {
                                    if (((TextBox)cx).Text == "")
                                    {
                                        MesEmpy();
                                        return true;
                                    }
                                }

                                else if (cx is ComboBox)
                                {
                                    if (((ComboBox)cx).Text == "")
                                    {
                                        MesEmpy();
                                        return true;
                                    }
                                }

                                else if (cx is DateTimePicker)
                                {
                                    if (((DateTimePicker)cx).Text == "")
                                    {
                                        MesEmpy();
                                        return true;
                                    }
                                }

                            }

                        }
                    }

                }
            }


            return false;
        }
        /// <summary>
        /// Validacion de Datos
        /// </summary>
        /// <param name="bt"></param>
        /// <param name="obj"></param>
        public static void ValidaDatos(KeyPressEventArgs bt, object obj)
        {
            if (!char.IsControl(bt.KeyChar) && !char.IsDigit(bt.KeyChar) && (bt.KeyChar != '.'))
            {
                bt.Handled = true;
                MessageBox.Show("Solo se permites Valores Numericos y un punto");
            }

            if ((bt.KeyChar == '.') && ((obj as TextBox).Text.IndexOf('.') > -1))
            {
                bt.Handled = true;
                MessageBox.Show("Valor Incorrecto se visualiza mas de un punto");
            }

        }
        public static void ValidaDatos() { }

        private static void MesEmpy()
        {
            MessageBox.Show("Se Requiere que todos los campos este completado", "Datos Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static bool FormularioOpen(string formu)
        {
            if (Application.OpenForms.OfType<Form>().Where(x => x.Name == formu).SingleOrDefault<Form>() == null)
            {

                return false;

            }
            else
            {

                MessageBox.Show("Este formulario ya esta abierto");
                return true;

            }


        }
    }
}
