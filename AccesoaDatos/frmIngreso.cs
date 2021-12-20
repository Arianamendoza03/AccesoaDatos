using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccesoaDatos
{
    public partial class frmIngreso : Form
    {
        public frmIngreso()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //1. crear la conexion
            SqlConnetion conexion = new SqlConnetion(@"server=L-ELR-010\SQLEXPRESS; databse=TI2021; Integranted Segurity = true");

            //2. Definir una operacion
            string sql = " insert info personas(cedula, apellidos, nombres, fechaNacimiento, peso) ";
            sql += "values (@cedula, @apellidos, @nombres, @fechaNacimiento, @peso)" ;

            //3. ejecutar la operacion 
            SqlCommand comando = new SqlCommand(sql, conexion);

            //3.1 configurar los parametros : @cedula, @apellidos, @nombres, @fechaNacimiento, @peso
            comando.Parameters.Add(new SqlParameter("@cedula", this.txtcedula.Text));
            comando.Parameters.Add(new SqlParameter("@apellidos", this.txtApellidos.Text));
            comando.Parameters.Add(new SqlParameter("@nombres", this.txtNombres.Text));
            comando.Parameters.Add(new SqlParameter("@fechaNacimiento", this.txtfechaNac.Text));
            comando.Parameters.Add(new SqlParameter("@peso", this.txtpeso.Text));


            //3.2 abrir conexion 
            conexion.Open();
            //3.3 ingresar el registro en la BDD
            int res = comando.ExecuteNonQuery();

            //4. cerrar conexion
            conexion.Close();

            MessageBox.Show("Filas Insertadas :" + res.ToString());
        }
    }
}
