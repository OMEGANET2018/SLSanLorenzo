//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/07/30 - 14:19:27
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
    public partial class adolescenteDto
    {
        [DataMember()]
        public String v_AdolescenteId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public String v_EdadInicioTrabajo { get; set; }

        [DataMember()]
        public String v_TipoTrabajo { get; set; }

        [DataMember()]
        public String v_NroHorasTv { get; set; }

        [DataMember()]
        public String v_NroHorasJuegos { get; set; }

        [DataMember()]
        public String v_MenarquiaEspermarquia { get; set; }

        [DataMember()]
        public String v_EdadInicioRS { get; set; }

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
        public String v_ViveCon { get; set; }

        [DataMember()]
        public String v_Observaciones { get; set; }

        [DataMember()]
        public personDto person { get; set; }

        public adolescenteDto()
        {
        }

        public adolescenteDto(String v_AdolescenteId, String v_PersonId, String v_EdadInicioTrabajo, String v_TipoTrabajo, String v_NroHorasTv, String v_NroHorasJuegos, String v_MenarquiaEspermarquia, String v_EdadInicioRS, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, String v_NombreCuidador, String v_EdadCuidador, String v_DniCuidador, String v_ViveCon, String v_Observaciones, personDto person)
        {
			this.v_AdolescenteId = v_AdolescenteId;
			this.v_PersonId = v_PersonId;
			this.v_EdadInicioTrabajo = v_EdadInicioTrabajo;
			this.v_TipoTrabajo = v_TipoTrabajo;
			this.v_NroHorasTv = v_NroHorasTv;
			this.v_NroHorasJuegos = v_NroHorasJuegos;
			this.v_MenarquiaEspermarquia = v_MenarquiaEspermarquia;
			this.v_EdadInicioRS = v_EdadInicioRS;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.v_NombreCuidador = v_NombreCuidador;
			this.v_EdadCuidador = v_EdadCuidador;
			this.v_DniCuidador = v_DniCuidador;
			this.v_ViveCon = v_ViveCon;
			this.v_Observaciones = v_Observaciones;
			this.person = person;
        }
    }
}
