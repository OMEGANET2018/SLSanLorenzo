//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/06/04 - 16:19:01
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
    public partial class componentfieldvaluesrecommendationDto
    {
        [DataMember()]
        public String v_ComponentFieldValuesRecommendationId { get; set; }

        [DataMember()]
        public String v_ComponentFieldValuesId { get; set; }

        [DataMember()]
        public String v_MasterRecommendationRestricctionId { get; set; }

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
        public componentfieldvaluesDto componentfieldvalues { get; set; }

        [DataMember()]
        public masterrecommendationrestricctionDto masterrecommendationrestricction { get; set; }

        public componentfieldvaluesrecommendationDto()
        {
        }

        public componentfieldvaluesrecommendationDto(String v_ComponentFieldValuesRecommendationId, String v_ComponentFieldValuesId, String v_MasterRecommendationRestricctionId, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, componentfieldvaluesDto componentfieldvalues, masterrecommendationrestricctionDto masterrecommendationrestricction)
        {
			this.v_ComponentFieldValuesRecommendationId = v_ComponentFieldValuesRecommendationId;
			this.v_ComponentFieldValuesId = v_ComponentFieldValuesId;
			this.v_MasterRecommendationRestricctionId = v_MasterRecommendationRestricctionId;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.componentfieldvalues = componentfieldvalues;
			this.masterrecommendationrestricction = masterrecommendationrestricction;
        }
    }
}
