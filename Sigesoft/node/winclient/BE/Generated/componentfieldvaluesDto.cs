//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/07/30 - 14:19:44
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
    public partial class componentfieldvaluesDto
    {
        [DataMember()]
        public String v_ComponentFieldValuesId { get; set; }

        [DataMember()]
        public String v_Diseases { get; set; }

        [DataMember()]
        public String v_ComponentFieldId { get; set; }

        [DataMember()]
        public String v_AnalyzingValue1 { get; set; }

        [DataMember()]
        public String v_AnalyzingValue2 { get; set; }

        [DataMember()]
        public Nullable<Int32> i_OperatorId { get; set; }

        [DataMember()]
        public String v_LegalStandard { get; set; }

        [DataMember()]
        public Nullable<Int32> i_IsAnormal { get; set; }

        [DataMember()]
        public Nullable<Int32> i_ValidationMonths { get; set; }

        [DataMember()]
        public Nullable<Int32> i_GenderId { get; set; }

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
        public componentfieldDto componentfield { get; set; }

        [DataMember()]
        public diseasesDto diseases { get; set; }

        [DataMember()]
        public List<componentfieldvaluesrecommendationDto> componentfieldvaluesrecommendation { get; set; }

        [DataMember()]
        public List<componentfieldvaluesrestrictionDto> componentfieldvaluesrestriction { get; set; }

        [DataMember()]
        public List<servicecomponentfieldvaluesDto> servicecomponentfieldvalues { get; set; }

        public componentfieldvaluesDto()
        {
        }

        public componentfieldvaluesDto(String v_ComponentFieldValuesId, String v_Diseases, String v_ComponentFieldId, String v_AnalyzingValue1, String v_AnalyzingValue2, Nullable<Int32> i_OperatorId, String v_LegalStandard, Nullable<Int32> i_IsAnormal, Nullable<Int32> i_ValidationMonths, Nullable<Int32> i_GenderId, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, componentfieldDto componentfield, diseasesDto diseases, List<componentfieldvaluesrecommendationDto> componentfieldvaluesrecommendation, List<componentfieldvaluesrestrictionDto> componentfieldvaluesrestriction, List<servicecomponentfieldvaluesDto> servicecomponentfieldvalues)
        {
			this.v_ComponentFieldValuesId = v_ComponentFieldValuesId;
			this.v_Diseases = v_Diseases;
			this.v_ComponentFieldId = v_ComponentFieldId;
			this.v_AnalyzingValue1 = v_AnalyzingValue1;
			this.v_AnalyzingValue2 = v_AnalyzingValue2;
			this.i_OperatorId = i_OperatorId;
			this.v_LegalStandard = v_LegalStandard;
			this.i_IsAnormal = i_IsAnormal;
			this.i_ValidationMonths = i_ValidationMonths;
			this.i_GenderId = i_GenderId;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.componentfield = componentfield;
			this.diseases = diseases;
			this.componentfieldvaluesrecommendation = componentfieldvaluesrecommendation;
			this.componentfieldvaluesrestriction = componentfieldvaluesrestriction;
			this.servicecomponentfieldvalues = servicecomponentfieldvalues;
        }
    }
}
