using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.DataAccess.Repositories.RepositoriesGeneral
{
    public class MunicipioRepository : IRepository<tbMunicipios>
    {
        /// <summary>
        /// Obtiene una lista de los municipios por el departamento.
        /// </summary>
        /// <returns>Lista de municipios disponibles.</returns>
        public virtual IEnumerable<tbMunicipios> ListByDepartment(string? id)
        {
            List<tbMunicipios> result = new List<tbMunicipios>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@depa_Id", id);
                result = db.Query<tbMunicipios>(ScriptsDataBase.ListarMunicipiosPorDepartamento, parameter, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }

        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@muni_Id", id);
                var answer = db.QueryFirst<int>(ScriptsDataBase.EliminarMunicipio, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public tbMunicipios Find(int? id)
        {
            tbMunicipios result = new tbMunicipios();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@muni_Id", id);
                result = db.QueryFirst<tbMunicipios>(ScriptsDataBase.BuscarMunicipio, parameter, commandType: CommandType.StoredProcedure);
                return result;
            }
        }

        public RequestStatus Insert(tbMunicipios item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@muni_DescripcionMunicipio", item.muni_DescripcionMunicipio);
                parameter.Add("@depa_Id", item.depa_Id);
                parameter.Add("@muni_UsuarioCreacion", item.muni_UsuarioCreacion);
                parameter.Add("@muni_FechaCreacion", item.muni_FechaCreacion);


                var answer = db.QueryFirst<int>(ScriptsDataBase.InsertarMunicipio, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbMunicipios> List()
        {
            List<tbMunicipios> result = new List<tbMunicipios>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbMunicipios>(ScriptsDataBase.ListarMunicipios, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbMunicipios item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@muni_Id", item.muni_Id);
                parameter.Add("@muni_DescripcionMunicipio", item.muni_DescripcionMunicipio);
                parameter.Add("@depa_Id", item.depa_Id);
                parameter.Add("@muni_UsuarioModificacion", item.muni_UsuarioModificacion);
                parameter.Add("@muni_FechaModificacion", item.muni_FechaModificacion);

                var answer = db.QueryFirst<int>(ScriptsDataBase.ActualizarMunicipio, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = answer;
                return result;
            }
        }
    }
}
