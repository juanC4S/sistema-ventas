using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentas.Presentacion
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();

        }
        #region "Mis Variables"
            
        internal int nCodigo_us {  get; set; }
        internal string cLogin_us { get; set; }
        internal string cNombre_us { get; set; }
        internal string cDescripcion_ru {  get; set; }
        internal int nCodigo_ru {  get; set; }
            


        #endregion
        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            lbl_nombre_us.Text = "USUARIO: " + cNombre_us;
            lblDescripcion_ru.Text = "Rol usuario: " + cDescripcion_ru;
        }

        private void btn_cerrarsesion_Click(object sender, EventArgs e)
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Deseas cerrar sesión del Sistema?",
                                     "Aviso del Sistema",
                                     MessageBoxButtons.OKCancel,
                                     MessageBoxIcon.Question);
            if(Opcion == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Frm_Usuarios oFrm_us = new Frm_Usuarios();
            oFrm_us.ShowDialog();
        }
    }
}
