using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;


namespace CapaDatos
{
    public class capa_datos_citas
    {
        clase_conexion oconexion = new clase_conexion();
        SqlCommand ocmd = new SqlCommand();

        public bool guardar_cita(capa_entidades_cita ocitas)
        {
            try
            {
                ocmd.CommandType = System.Data.CommandType.StoredProcedure;
                ocmd.Connection = oconexion.conectar("BDHospital");
                ocmd.CommandText = "actualizar_cita";
                ocmd.Parameters.Add("@cod_cita", ocitas.Cod_cita);
                ocmd.Parameters.Add("@fecha", ocitas.Fecha);
                ocmd.Parameters.Add("@hora", ocitas.Hora);
                ocmd.Parameters.Add("@id_paciente1", ocitas.Id_paciente);
                ocmd.Parameters.Add("@id_medico1", ocitas.Id_medico);
                ocmd.Parameters.Add("@valor", ocitas.Valor);
                ocmd.Parameters.Add("@diagnostico", ocitas.Diagnostico);
                ocmd.Parameters.Add("@nom_acompañante", ocitas.Nom_acompanante);
                ocmd.Parameters.Add("@activo", ocitas.Activo);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }

        public bool Anular_cita(capa_entidades_cita ocitas)
        {// de CECitas recibe la información para guardar citas.
         //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento

            try
            { // desactiva la recoleccion automatica de errores
                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar

                ocmd.CommandText = "borrar_cita";
                ocmd.Parameters.Add("@idc_c", ocitas.Cod_cita);

                ocmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }

        public DataSet Consultar_cita(capa_entidades_cita ocitas)
        {// de CECitas recibe la información para guardar citas.
         //Se realiza un crud dependiendo de los procedimientos almacenados que se han realizado, se realiza un método por cada procedimiento

            try
            { // desactiva la recoleccion automatica de errores
                ocmd.CommandType = CommandType.StoredProcedure;// comando de sql para abrir la conexión
                ocmd.Connection = oconexion.conectar("BDHospital");// se emplea para conectar

                ocmd.CommandText = "Consultar_citas";
                ocmd.Parameters.Add("@idc_c", ocitas.Cod_cita);

                SqlDataAdapter da = new SqlDataAdapter(ocmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception err)
            {
                throw new Exception(err.Message); // solo se ejecuta si hay error
            }
        }
    }
}

