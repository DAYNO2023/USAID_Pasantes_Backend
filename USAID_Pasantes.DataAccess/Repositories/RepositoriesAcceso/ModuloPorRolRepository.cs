﻿using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USAID_Pasantes.Entities.Entities;

namespace USAID_Pasantes.DataAccess.Repositories.RepositoriesAcceso
{
    public class ModuloPorRolRepository : IRepository<tbModulosPorRoles>
    {
        public RequestStatus Delete(int? id)
        {
            RequestStatus result = new RequestStatus();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Role_Id", id);

                var answer = db.QueryFirst<int>(
                    ScriptsDataBase.EliminarModulosPorRol,
                    parameter,
                    commandType: CommandType.StoredProcedure
                );

                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbModulosPorRoles> Buscar(int? id)
        {
            List<tbModulosPorRoles> result = new List<tbModulosPorRoles>();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Role_Id", id);
                result = db.Query<tbModulosPorRoles>(ScriptsDataBase.BuscarModulosPorRol, parameter, commandType: CommandType.StoredProcedure).ToList();
                return result;
            }
        }
        public tbModulosPorRoles Find(int? id)
        {
            throw new NotImplementedException();
        }

        public RequestStatus Insert(tbModulosPorRoles item)
        {
            RequestStatus result = new RequestStatus();

            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Role_Id", item.role_Id);
                parameter.Add("@Modu_Id", item.modu_Id);

                var answer = db.QueryFirst<int>(
                    ScriptsDataBase.InsertarModulosPorRol,
                    parameter,
                    commandType: CommandType.StoredProcedure
                );

                result.CodeStatus = answer;
                return result;
            }
        }

        public IEnumerable<tbModulosPorRoles> List()
        {
            List<tbModulosPorRoles> result = new List<tbModulosPorRoles>();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                result = db.Query<tbModulosPorRoles>(ScriptsDataBase.ListarModulosPorRol, commandType: CommandType.Text).ToList();
                return result;
            }
        }

        public RequestStatus Update(tbModulosPorRoles item)
        {
            RequestStatus result = new RequestStatus();
            using (var db = new SqlConnection(USAID_Pasantes.ConnectionString))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@Moro_Id", item.moro_Id);
                parameter.Add("@Role_Id", item.role_Id);
                parameter.Add("@Modu_Id", item.modu_Id);

                var ansewer = db.QueryFirst<int>(ScriptsDataBase.ActualizarModulosPorRol, parameter, commandType: CommandType.StoredProcedure);
                result.CodeStatus = ansewer;
                return result;
            }
        }
    }
}
