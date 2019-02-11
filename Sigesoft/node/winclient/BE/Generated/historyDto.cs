//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/02/09 - 20:46:11
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
    public partial class historyDto
    {
        [DataMember()]
        public String v_HistoryId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_StartDate { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_EndDate { get; set; }

        [DataMember()]
        public String v_Organization { get; set; }

        [DataMember()]
        public String v_TypeActivity { get; set; }

        [DataMember()]
        public Nullable<Int32> i_GeografixcaHeight { get; set; }

        [DataMember()]
        public String v_workstation { get; set; }

        [DataMember()]
        public Byte[] b_RubricImage { get; set; }

        [DataMember()]
        public Byte[] b_FingerPrintImage { get; set; }

        [DataMember()]
        public String t_RubricImageText { get; set; }

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
        public Nullable<Int32> i_TypeOperationId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_TrabajoActual { get; set; }

        [DataMember()]
        public String v_FechaUltimaMamo { get; set; }

        [DataMember()]
        public String v_FechaUltimoPAP { get; set; }

        [DataMember()]
        public String v_ResultadoMamo { get; set; }

        [DataMember()]
        public String v_ResultadosPAP { get; set; }

        [DataMember()]
        public Nullable<Int32> i_SoloAnio { get; set; }

        [DataMember()]
        public String v_ActividadEmpresa { get; set; }

        [DataMember()]
        public personDto person { get; set; }

        [DataMember()]
        public List<typeofeepDto> typeofeep { get; set; }

        [DataMember()]
        public List<workstationdangersDto> workstationdangers { get; set; }

        public historyDto()
        {
        }

        public historyDto(String v_HistoryId, String v_PersonId, Nullable<DateTime> d_StartDate, Nullable<DateTime> d_EndDate, String v_Organization, String v_TypeActivity, Nullable<Int32> i_GeografixcaHeight, String v_workstation, Byte[] b_RubricImage, Byte[] b_FingerPrintImage, String t_RubricImageText, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, Nullable<Int32> i_TypeOperationId, Nullable<Int32> i_TrabajoActual, String v_FechaUltimaMamo, String v_FechaUltimoPAP, String v_ResultadoMamo, String v_ResultadosPAP, Nullable<Int32> i_SoloAnio, String v_ActividadEmpresa, personDto person, List<typeofeepDto> typeofeep, List<workstationdangersDto> workstationdangers)
        {
			this.v_HistoryId = v_HistoryId;
			this.v_PersonId = v_PersonId;
			this.d_StartDate = d_StartDate;
			this.d_EndDate = d_EndDate;
			this.v_Organization = v_Organization;
			this.v_TypeActivity = v_TypeActivity;
			this.i_GeografixcaHeight = i_GeografixcaHeight;
			this.v_workstation = v_workstation;
			this.b_RubricImage = b_RubricImage;
			this.b_FingerPrintImage = b_FingerPrintImage;
			this.t_RubricImageText = t_RubricImageText;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.i_TypeOperationId = i_TypeOperationId;
			this.i_TrabajoActual = i_TrabajoActual;
			this.v_FechaUltimaMamo = v_FechaUltimaMamo;
			this.v_FechaUltimoPAP = v_FechaUltimoPAP;
			this.v_ResultadoMamo = v_ResultadoMamo;
			this.v_ResultadosPAP = v_ResultadosPAP;
			this.i_SoloAnio = i_SoloAnio;
			this.v_ActividadEmpresa = v_ActividadEmpresa;
			this.person = person;
			this.typeofeep = typeofeep;
			this.workstationdangers = workstationdangers;
        }
    }
}
