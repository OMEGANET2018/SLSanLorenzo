//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/01/04 - 09:59:27
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
    public partial class servicecomponentfieldvaluesDto
    {
        [DataMember()]
        public String v_ServiceComponentFieldValuesId { get; set; }

        [DataMember()]
        public String v_ComponentFieldValuesId { get; set; }

        [DataMember()]
        public String v_ServiceComponentFieldsId { get; set; }

        [DataMember()]
        public String v_Value1 { get; set; }

        [DataMember()]
        public String v_Value2 { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Index { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Value1 { get; set; }

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
        public servicecomponentfieldsDto servicecomponentfields { get; set; }

        [DataMember()]
        public List<servicecomponentfieldvaluesmultimediaDto> servicecomponentfieldvaluesmultimedia { get; set; }

        public servicecomponentfieldvaluesDto()
        {
        }

        public servicecomponentfieldvaluesDto(String v_ServiceComponentFieldValuesId, String v_ComponentFieldValuesId, String v_ServiceComponentFieldsId, String v_Value1, String v_Value2, Nullable<Int32> i_Index, Nullable<Int32> i_Value1, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, componentfieldvaluesDto componentfieldvalues, servicecomponentfieldsDto servicecomponentfields, List<servicecomponentfieldvaluesmultimediaDto> servicecomponentfieldvaluesmultimedia)
        {
			this.v_ServiceComponentFieldValuesId = v_ServiceComponentFieldValuesId;
			this.v_ComponentFieldValuesId = v_ComponentFieldValuesId;
			this.v_ServiceComponentFieldsId = v_ServiceComponentFieldsId;
			this.v_Value1 = v_Value1;
			this.v_Value2 = v_Value2;
			this.i_Index = i_Index;
			this.i_Value1 = i_Value1;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.componentfieldvalues = componentfieldvalues;
			this.servicecomponentfields = servicecomponentfields;
			this.servicecomponentfieldvaluesmultimedia = servicecomponentfieldvaluesmultimedia;
        }
    }
}
