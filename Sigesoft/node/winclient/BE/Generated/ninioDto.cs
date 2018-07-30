//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/07/30 - 14:20:15
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sigesoft.Node.WinClient.BE
{
    [DataContract()]
    public partial class ninioDto
    {
        [DataMember()]
        public String v_NinioId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public String v_NombrePadre { get; set; }

        [DataMember()]
        public String v_EdadPadre { get; set; }

        [DataMember()]
        public String v_DniPadre { get; set; }

        [DataMember()]
        public Nullable<Int32> i_TipoAfiliacionPadre { get; set; }

        [DataMember()]
        public String v_CodigoAfiliacionPadre { get; set; }

        [DataMember()]
        public Nullable<Int32> i_GradoInstruccionPadre { get; set; }

        [DataMember()]
        public String v_OcupacionPadre { get; set; }

        [DataMember()]
        public Nullable<Int32> i_EstadoCivilIdPadre { get; set; }

        [DataMember()]
        public String v_ReligionPadre { get; set; }

        [DataMember()]
        public String v_NombreMadre { get; set; }

        [DataMember()]
        public String v_EdadMadre { get; set; }

        [DataMember()]
        public String v_DniMadre { get; set; }

        [DataMember()]
        public Nullable<Int32> i_TipoAfiliacionMadre { get; set; }

        [DataMember()]
        public String v_CodigoAfiliacionMadre { get; set; }

        [DataMember()]
        public Nullable<Int32> i_GradoInstruccionMadre { get; set; }

        [DataMember()]
        public String v_OcupacionMadre { get; set; }

        [DataMember()]
        public Nullable<Int32> i_EstadoCivilIdMadre1 { get; set; }

        [DataMember()]
        public String v_ReligionMadre { get; set; }

        [DataMember()]
        public Nullable<Int32> i_IsDeleted { get; set; }

        [DataMember()]
        public Nullable<Int32> i_InsertUserId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_InsertDate { get; set; }

        [DataMember()]
        public Nullable<Int32> i_UpdateUserId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_UpdateDate { get; set; }

        [DataMember()]
        public String v_NombreCuidador { get; set; }

        [DataMember()]
        public String v_EdadCuidador { get; set; }

        [DataMember()]
        public String v_DniCuidador { get; set; }

        [DataMember()]
        public String v_PatologiasGestacion { get; set; }

        [DataMember()]
        public String v_nEmbarazos { get; set; }

        [DataMember()]
        public String v_nAPN { get; set; }

        [DataMember()]
        public String v_LugarAPN { get; set; }

        [DataMember()]
        public String v_ComplicacionesParto { get; set; }

        [DataMember()]
        public String v_Atencion { get; set; }

        [DataMember()]
        public String v_EdadGestacion { get; set; }

        [DataMember()]
        public String v_Peso { get; set; }

        [DataMember()]
        public String v_Talla { get; set; }

        [DataMember()]
        public String v_PerimetroCefalico { get; set; }

        [DataMember()]
        public String v_PerimetroToracico { get; set; }

        [DataMember()]
        public String v_EspecificacionesNac { get; set; }

        [DataMember()]
        public String v_LME { get; set; }

        [DataMember()]
        public String v_Mixta { get; set; }

        [DataMember()]
        public String v_Artificial { get; set; }

        [DataMember()]
        public String v_InicioAlimentacionComp { get; set; }

        [DataMember()]
        public String v_AlergiasMedicamentos { get; set; }

        [DataMember()]
        public String v_OtrosAntecedentes { get; set; }

        [DataMember()]
        public String v_EspecificacionesAgua { get; set; }

        [DataMember()]
        public String v_EspecificacionesDesague { get; set; }

        [DataMember()]
        public String v_TiempoHospitalizacion { get; set; }

        [DataMember()]
        public personDto person { get; set; }

        public ninioDto()
        {
        }

        public ninioDto(String v_NinioId, String v_PersonId, String v_NombrePadre, String v_EdadPadre, String v_DniPadre, Nullable<Int32> i_TipoAfiliacionPadre, String v_CodigoAfiliacionPadre, Nullable<Int32> i_GradoInstruccionPadre, String v_OcupacionPadre, Nullable<Int32> i_EstadoCivilIdPadre, String v_ReligionPadre, String v_NombreMadre, String v_EdadMadre, String v_DniMadre, Nullable<Int32> i_TipoAfiliacionMadre, String v_CodigoAfiliacionMadre, Nullable<Int32> i_GradoInstruccionMadre, String v_OcupacionMadre, Nullable<Int32> i_EstadoCivilIdMadre1, String v_ReligionMadre, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, String v_NombreCuidador, String v_EdadCuidador, String v_DniCuidador, String v_PatologiasGestacion, String v_nEmbarazos, String v_nAPN, String v_LugarAPN, String v_ComplicacionesParto, String v_Atencion, String v_EdadGestacion, String v_Peso, String v_Talla, String v_PerimetroCefalico, String v_PerimetroToracico, String v_EspecificacionesNac, String v_LME, String v_Mixta, String v_Artificial, String v_InicioAlimentacionComp, String v_AlergiasMedicamentos, String v_OtrosAntecedentes, String v_EspecificacionesAgua, String v_EspecificacionesDesague, String v_TiempoHospitalizacion, personDto person)
        {
			this.v_NinioId = v_NinioId;
			this.v_PersonId = v_PersonId;
			this.v_NombrePadre = v_NombrePadre;
			this.v_EdadPadre = v_EdadPadre;
			this.v_DniPadre = v_DniPadre;
			this.i_TipoAfiliacionPadre = i_TipoAfiliacionPadre;
			this.v_CodigoAfiliacionPadre = v_CodigoAfiliacionPadre;
			this.i_GradoInstruccionPadre = i_GradoInstruccionPadre;
			this.v_OcupacionPadre = v_OcupacionPadre;
			this.i_EstadoCivilIdPadre = i_EstadoCivilIdPadre;
			this.v_ReligionPadre = v_ReligionPadre;
			this.v_NombreMadre = v_NombreMadre;
			this.v_EdadMadre = v_EdadMadre;
			this.v_DniMadre = v_DniMadre;
			this.i_TipoAfiliacionMadre = i_TipoAfiliacionMadre;
			this.v_CodigoAfiliacionMadre = v_CodigoAfiliacionMadre;
			this.i_GradoInstruccionMadre = i_GradoInstruccionMadre;
			this.v_OcupacionMadre = v_OcupacionMadre;
			this.i_EstadoCivilIdMadre1 = i_EstadoCivilIdMadre1;
			this.v_ReligionMadre = v_ReligionMadre;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.v_NombreCuidador = v_NombreCuidador;
			this.v_EdadCuidador = v_EdadCuidador;
			this.v_DniCuidador = v_DniCuidador;
			this.v_PatologiasGestacion = v_PatologiasGestacion;
			this.v_nEmbarazos = v_nEmbarazos;
			this.v_nAPN = v_nAPN;
			this.v_LugarAPN = v_LugarAPN;
			this.v_ComplicacionesParto = v_ComplicacionesParto;
			this.v_Atencion = v_Atencion;
			this.v_EdadGestacion = v_EdadGestacion;
			this.v_Peso = v_Peso;
			this.v_Talla = v_Talla;
			this.v_PerimetroCefalico = v_PerimetroCefalico;
			this.v_PerimetroToracico = v_PerimetroToracico;
			this.v_EspecificacionesNac = v_EspecificacionesNac;
			this.v_LME = v_LME;
			this.v_Mixta = v_Mixta;
			this.v_Artificial = v_Artificial;
			this.v_InicioAlimentacionComp = v_InicioAlimentacionComp;
			this.v_AlergiasMedicamentos = v_AlergiasMedicamentos;
			this.v_OtrosAntecedentes = v_OtrosAntecedentes;
			this.v_EspecificacionesAgua = v_EspecificacionesAgua;
			this.v_EspecificacionesDesague = v_EspecificacionesDesague;
			this.v_TiempoHospitalizacion = v_TiempoHospitalizacion;
			this.person = person;
        }
    }
}
