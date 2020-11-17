using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;
using System.Data;

namespace capaNegocio
{
    public class capa_negocio_citas
    {
        capa_datos_citas odatcitas = new capa_datos_citas();
        public bool guardar_cita(capa_entidades_cita oentcita)
        {
            return odatcitas.guardar_cita(oentcita);
        }
        public bool anular_cita(capa_entidades_cita oentcita)
        {
            return odatcitas.Anular_cita(oentcita);
        }
        public DataSet consultar_cita(capa_entidades_cita oentcita)
        {
            return odatcitas.Consultar_cita(oentcita);
        }
    }
}
