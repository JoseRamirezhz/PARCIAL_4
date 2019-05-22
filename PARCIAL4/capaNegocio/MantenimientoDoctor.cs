using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace capaNegocio
{
   public class MantenimientoDoctor
    {
        ConexionBD test = new ConexionBD();
        private String codDoctor, codHospital,apellidoDoc,especialidadDoc;

        public string CodDoctor
        {
            get { return codDoctor;}
            set{ codDoctor = value;}
        }

        public string CodHospital
        {
            get{ return codHospital; }
            set{ codHospital = value; }
        }

        public string ApellidoDoc
        {
            get{return apellidoDoc;}
            set{ apellidoDoc = value;}
        }

        public string EspecialidadDoc
        {
            get{return especialidadDoc;}
            set{ especialidadDoc = value;}
        }

        //insert into VENDEDOR(VENDEDOR, NOMBRE) values(,)
        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else
            {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }
        public void insertarDoctor()
        {
            try
            {
                String insert = ("INSERT INTO Doctor(Doctor_No, Hospital_Cod, Apellido, Especialidad) VALUES ('" + codDoctor + "','" + codHospital + "','" + apellidoDoc + "','" + especialidadDoc + "')"); 
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();
            }
            catch
            {

            }
        }

        /*public void updateVendedor()
        {
            try
            {
                String update = (@"update [dbo].[VENDEDOR]
                                 set NOMBRE = '" + nomVendedor +
                                 "where vendedor ='" + codVendedor + "'");
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();
            }
            catch
            {

            }
        }
        public void deleteVendedor()
        {
            try
            {
                String delete = @"delete from [dbo].[VENDEDOR]
                                where vendedor = '" + codVendedor + "'";
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();
            }
            catch
            {

            }
        }
        public void mostrarVendedor()
        {
            try
            {
                String consulta = "select * from VENDEDOR";
                test.Conectar();
                test.mostrarSQL(consulta);
                test.da.Fill(dt);
                test.Desconectar();
            }
            catch
            {

            }
        }*/
    }
}
