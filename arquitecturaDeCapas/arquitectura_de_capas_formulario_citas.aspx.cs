using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDatos;
using CapaEntidades;
using capaNegocio;
using System.Data;

namespace arquitecturaDeCapas
{
    public partial class arquitectura_de_capas_formulario_citas : System.Web.UI.Page
    {
        capa_negocio_citas ONcitas = new capa_negocio_citas();
        capa_entidades_cita OEcitas = new capa_entidades_cita();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btn_consultar_cita_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEcitas.Cod_cita = txt_cod_cita.Text;

            ds = ONcitas.consultar_cita(OEcitas);

            if(ds.Tables[0].Rows.Count == 0)
            {
                lbl_resultado_bool.Text = "No se encontraron resultados";
            } 
            else
            {
                txt_fecha.Text = ds.Tables[0].Rows[0]["fecha"].ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            OEcitas.Cod_cita = txt_cod_cita.Text;
            OEcitas.Fecha = Convert.ToDateTime(txt_fecha.Text);
            OEcitas.Valor = Convert.ToInt32(txt_valor.Text);
            if (ONcitas.guardar_cita(OEcitas))
            {
                lbl_resultado_bool.Text = "Cita creada correctamente";
            }
            else
            {
                lbl_resultado_bool.Text = "Error al crear la cita";
            }
        }
    }
}