using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio24
{
    public partial class Form1 : Form
    {

        Cena cena;
        Cumpleanos cumple;
        public Form1()
        {
            InitializeComponent();
            cena = new Cena();
            cumple = new Cumpleanos();
            Num_Ce.Minimum = 0;
            Num_Cu.Minimum = 0;
            txtBx_coste_Ce.Text = "0,00€";
            txtBx_coste_Cu.Text = "0,00€";
            txtBx_txtTarta_Cu.Enabled = false;
            ckBx_lujo_Cu.Enabled = false;
            ckBx_lujo_Ce.Enabled = false;
            ckBx_Saludable_Ce.Enabled = false;


        }
        public void Cumple()
        {
            txtBx_coste_Cu.Text = Convert.ToString(Math.Round(cumple.CalcularCoste(), 2) + "€");
        }
        private void Num_Cu_ValueChanged(object sender, EventArgs e)
        {
            if (Num_Cu.Value == 0)
            {
                cumple.NumPersonas = (int)Num_Cu.Value;
                txtBx_txtTarta_Cu.Enabled = false;
                ckBx_lujo_Cu.Enabled = false;
                ckBx_lujo_Cu.Checked = false;
                txtBx_txtTarta_Cu.Clear();
                txtBx_coste_Cu.Text = "0,00€";
                Cumple();
            }
            else if (Num_Cu.Value <= 8)
            {
                cumple.NumPersonas = (int)Num_Cu.Value;
                txtBx_txtTarta_Cu.Enabled = true;
                ckBx_lujo_Cu.Enabled = true;
                cumple.tamanoTarta = 40;
                Cumple();

            }
            else if (Num_Cu.Value > 8)
            {
                cumple.NumPersonas = (int)Num_Cu.Value;
                txtBx_txtTarta_Cu.Enabled = true;
                ckBx_lujo_Cu.Enabled = true;
                cumple.tamanoTarta = 75;
                Cumple();
            }
        }
        private void ckBx_lujo_Cu_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBx_lujo_Cu.Checked)
            {
                cumple.decoracionLujo = true;
                Cumple();
            }
            else
            {
                cumple.decoracionLujo = false;
                Cumple();
            }
        }
        public void Cena()
        {
            txtBx_coste_Ce.Text = Convert.ToString(Math.Round(cena.CalcularCoste(),2) + "€");
        }
        private void Num_Ce_ValueChanged(object sender, EventArgs e)
        {
            
            if (Num_Ce.Value == 0)
            {
                cena.NumPersonas = (int)Num_Ce.Value;
                ckBx_lujo_Ce.Enabled = false;
                ckBx_lujo_Ce.Checked = false;
                ckBx_Saludable_Ce.Enabled = false;
                ckBx_lujo_Ce.Checked = false;
                ckBx_Saludable_Ce.Checked = false;
                Cena();
            }
            else
            {
                cena.NumPersonas = (int)Num_Ce.Value;
                ckBx_lujo_Ce.Enabled = true;
                ckBx_Saludable_Ce.Enabled = true;
                Cena();


            }
        }
        
        private void ckBx_lujo_Ce_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBx_lujo_Ce.Checked)
            {
                cena.decoracionLujo = true;
                Cena();
            }
            else
            {
                cena.decoracionLujo = false;
                Cena();
            }
        }

        private void ckBx_Saludable_Ce_CheckedChanged(object sender, EventArgs e)
        {
            if (ckBx_Saludable_Ce.Checked)
            {
                cena.opcionSaludable = true;
                Cena();
            }
            else
            {
                cena.opcionSaludable = false;
                Cena();
            }
        }

        private void txtBx_txtTarta_Cu_TextChanged(object sender, EventArgs e)
        {
            string sinespacio;
            sinespacio = txtBx_txtTarta_Cu.Text.Replace(" ", "");
            if (Num_Cu.Value <= 8 )
            {
                if (sinespacio.Length < 16)
                {
                    cumple.textoTarta = sinespacio.Length;
                    Cumple();
                }
                else
                {
                    MessageBox.Show("Has llegado al límite de letras de la tarta pequeña.", "LÍMITE", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                if (sinespacio.Length < 40)
                {
                    cumple.textoTarta = sinespacio.Length;
                    Cumple();
                }
                else {
                    MessageBox.Show("Has llegado al límite de letras de la tarta grande.", "LÍMITE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
             
        }

    }
}
