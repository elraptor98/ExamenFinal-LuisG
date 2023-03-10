using Registro.Entidades;
using Registro.negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notas.Registro
{
    
    public partial class frmRegistroNotas : Form
    {
        //Nota _nota;
       
        public frmRegistroNotas(/*Nota nota*/)
        {
            InitializeComponent();
            //this._nota= nota;
        }

       

        private void CargarFormulario(object sender, EventArgs e)
        {
            cargardatos();
        }

        void cargardatos()
        {
            var listadoCursos = CursosBL.Listar();
            cboCurso.DataSource = listadoCursos;
            cboCurso.DisplayMember = "Nombre";
            cboCurso.ValueMember = "ID";

            var listadoAlumnos = AlumnoBL.Listar();
            cboAlumno.DataSource = listadoAlumnos;
            
            cboAlumno.DisplayMember = "Codigo_Nombres";
            cboAlumno.ValueMember = "Id";
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //asignarDatos();
            //this.DialogResult = DialogResult.OK;
        }

        //void asignarDatos()
        //{
        //    this._nota.Eva1 = double.Parse(txteva1.Text);
        //    this._nota.Eva2 = double.Parse(txteva2.Text);
        //    this._nota.Parcial = double.Parse(txtparcial.Text);
        //    this._nota.Final = double.Parse(txtfinal.Text);
        //    this._nota.IdAulmno = int.Parse(cboAlumno.SelectedValue.ToString());
        //    this._nota.IdCurso = int.Parse(cboCurso.SelectedValue.ToString());


        //}
    }
}
