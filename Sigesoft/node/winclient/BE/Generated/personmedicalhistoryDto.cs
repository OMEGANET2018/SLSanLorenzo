//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/02/02 - 16:08:07
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
    public partial class personmedicalhistoryDto
    {
        [DataMember()]
        public String v_PersonMedicalHistoryId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public String v_DiseasesId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_TypeDiagnosticId { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_StartDate { get; set; }

        [DataMember()]
        public String v_DiagnosticDetail { get; set; }

        [DataMember()]
        public String v_TreatmentSite { get; set; }

        [DataMember()]
        public Nullable<Int32> i_AnswerId { get; set; }

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
        public Nullable<Int32> i_SoloAnio { get; set; }

        [DataMember()]
        public String NombreHospital { get; set; }

        [DataMember()]
        public String v_Complicaciones { get; set; }

        [DataMember()]
        public diseasesDto diseases { get; set; }

        [DataMember()]
        public personDto person { get; set; }

        public personmedicalhistoryDto()
        {
        }

        public personmedicalhistoryDto(String v_PersonMedicalHistoryId, String v_PersonId, String v_DiseasesId, Nullable<Int32> i_TypeDiagnosticId, Nullable<DateTime> d_StartDate, String v_DiagnosticDetail, String v_TreatmentSite, Nullable<Int32> i_AnswerId, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, Nullable<Int32> i_SoloAnio, String nombreHospital, String v_Complicaciones, diseasesDto diseases, personDto person)
        {
			this.v_PersonMedicalHistoryId = v_PersonMedicalHistoryId;
			this.v_PersonId = v_PersonId;
			this.v_DiseasesId = v_DiseasesId;
			this.i_TypeDiagnosticId = i_TypeDiagnosticId;
			this.d_StartDate = d_StartDate;
			this.v_DiagnosticDetail = v_DiagnosticDetail;
			this.v_TreatmentSite = v_TreatmentSite;
			this.i_AnswerId = i_AnswerId;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.i_SoloAnio = i_SoloAnio;
			this.NombreHospital = nombreHospital;
			this.v_Complicaciones = v_Complicaciones;
			this.diseases = diseases;
			this.person = person;
        }
    }
}
