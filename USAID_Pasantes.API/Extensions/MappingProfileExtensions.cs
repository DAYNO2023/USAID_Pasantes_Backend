using AutoMapper;

using USAID_Pasantes.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using USAID_Pasantes.Entities;
using USAID_Pasantes.Common.Models.ModelsAcceso;
using USAID_Pasantes.Common.Models.ModelsComunicacion;
using USAID_Pasantes.Common.Models.ModelsGeneral;
using USAID_Pasantes.Common.Models.ModelsGestion;

namespace USAID_Pasantes.API.Extensions
{
    public class MappingProfileExtensions : Profile
    {
        public MappingProfileExtensions()
        {
            #region Acceso
            CreateMap<ModuloPorRolViewModel, tbModulosPorRoles>().ReverseMap();
            CreateMap<ModuloViewModel, tbModulos>().ReverseMap();
            CreateMap<RolViewModel, tbRoles>().ReverseMap();
            CreateMap<UsuarioViewModel, tbUsuarios>().ReverseMap();
            #endregion

            #region Comunicacion
            CreateMap<DiscusionViewModel, tbDiscusiones>().ReverseMap();
            CreateMap<DocumentoImagenPorDiscusionViewModel, tbDocumentosImagenesPorDiscusion>().ReverseMap();
            CreateMap<EmpresaViewModel, tbEmpresas>().ReverseMap();
            CreateMap<ForoPorActividadViewModel, tbForosPorActividad>().ReverseMap();
            CreateMap<ForoPorEmpleadoViewModel, tbForosPorEmpleados>().ReverseMap();
            CreateMap<ForoViewModel, tbForos>().ReverseMap();
            CreateMap<HojaTiempoViewModel, tbHojaTiempo>().ReverseMap();
            CreateMap<HojaTiempoPorOptanteViewModel, tbHojaTiempoPorOptante>().ReverseMap();
            CreateMap<NotificacionPorUsuarioViewModel, tbNotificacionesPorUsuario>().ReverseMap();
            CreateMap<NotificacionViewModel, tbNotificaciones>().ReverseMap();
            CreateMap<OpcionPorPreguntaViewModel, tbOpcionesPorPregunta>().ReverseMap();
            CreateMap<PreguntaFrecuenteViewModel, tbPreguntasFrecuentes>().ReverseMap();
            CreateMap<TokenViewModel, tbTokens>().ReverseMap();
            #endregion

            #region General
            CreateMap<EstadosCivilesViewModel, tbEstadosCiviles>().ReverseMap();
            CreateMap<TipoSangreViewModel, tbTipoSangre>().ReverseMap();
            CreateMap<DepartamentoViewModel, tbDepartamentos>().ReverseMap();
            CreateMap<MunicipioViewModel, tbMunicipios>().ReverseMap();
            CreateMap<UniversidadViewModel, tbUniversidades>().ReverseMap();
            CreateMap<RegionalCorporativaViewModel, tbRegionalCorporativa>().ReverseMap();
            CreateMap<FacultadViewModel, tbFacultades>().ReverseMap();
            CreateMap<CarreraViewModel, tbCarreras>().ReverseMap();
            #endregion

            #region Gestión
            CreateMap<BeneficioViewModel, tbBeneficios>().ReverseMap();
            CreateMap<OptanteViewModel, tbOptantes>().ReverseMap();
            CreateMap<ProyectoViewModel, tbProyectos>().ReverseMap();
            #endregion
        }

    }
}
