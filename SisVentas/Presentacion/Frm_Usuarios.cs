using SisVentas.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Usuarios : Form
    {
        public Frm_Usuarios()
        {
            InitializeComponent();
        }
        #region "Mis variables"
        int nCodigo_us = 0;
        int nEstadoGuarda = 0;
        #endregion
        #region "Mis Métodos"
        private void Limpia_texto()
        {
            txtLogin_us.Text = string.Empty;
            txtPassword_us.Text = string.Empty; 
            txtNombre_us.Text = string.Empty;
            cmbRolUsuario.Text = string.Empty;
        }
        private void Estado_texto(bool lEstado)
        {
            txtLogin_us.Enabled = lEstado;
            txtPassword_us.Enabled = lEstado;
            txtNombre_us.Enabled = lEstado;
            cmbRolUsuario.Enabled = lEstado;
        }

        private void Estado_BotonesPrincipales(bool lEstado)
        {
            btnNuevo.Enabled = lEstado;
            btnActualizar.Enabled = lEstado;
            btnEstado.Enabled = lEstado;
            btnRetornar.Enabled = lEstado;
        }

        private void Formato()
        {
            dgvListado.Columns[0].Width = 100;
            dgvListado.Columns[0].HeaderText = "CÓDIGO_US";
            dgvListado.Columns[1].Width = 150;
            dgvListado.Columns[1].HeaderText = "LOGIN";
            dgvListado.Columns[2].Width = 150;
            dgvListado.Columns[2].HeaderText = "NOMBRE";
            dgvListado.Columns[3].Width = 130;
            dgvListado.Columns[3].HeaderText = "ROL DE USUARIO";
            dgvListado.Columns[4].Width = 80;
            dgvListado.Columns[4].HeaderText = "ACTIVO";
            dgvListado.Columns[5].Visible = false;

        }

        private void Listado_us (string cTexto)
        {
            D_Usuarios Datos = new D_Usuarios();
            dgvListado.DataSource = Datos.Listado_us(cTexto);
            this.Formato();
        }
        private void Listado_ru()
        {
            try
            {
                D_Usuarios Datos = new D_Usuarios();
                cmbRolUsuario.DataSource = Datos.Listado_ru();
                cmbRolUsuario.ValueMember = "codigo_ru";
                cmbRolUsuario.DisplayMember = "descripcion_ru";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message +ex.StackTrace);
            }
        }
        #endregion
        private void Estado_botonesProcesos(bool lEstado)
        {
            btnCancelar.Visible = lEstado;
            btnGuardar.Visible = lEstado;
        }
        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 1; //Nuevo Registro
            this.Limpia_texto();
            this.Estado_texto(true);
            this.Estado_botonesProcesos(true);
            this.Estado_BotonesPrincipales(false);
            this.txtLogin_us.Focus();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void pnlTrabajo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            nEstadoGuarda = 0;
            this.Limpia_texto();
            this.Estado_texto(false);
            this.Estado_botonesProcesos(false);
            this.Estado_BotonesPrincipales(true);
        }

        private void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            this.Listado_ru();
            this.Listado_us("%");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Listado_us(txtBuscar.Text);
        }
    }
}
