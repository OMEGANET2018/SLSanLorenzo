//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/03 - 14:43:37
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
    public partial class embarzoDto
    {
        [DataMember()]
        public String v_EmbarazoId { get; set; }

        [DataMember()]
        public String v_PersonId { get; set; }

        [DataMember()]
        public String v_Anio { get; set; }

        [DataMember()]
        public String v_Cpn { get; set; }

        [DataMember()]
        public String v_Complicacion { get; set; }

        [DataMember()]
        public String v_Parto { get; set; }

        [DataMember()]
        public String v_PesoRn { get; set; }

        [DataMember()]
        public String v_Puerpio { get; set; }

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
        public String v_ObservacionesGestacion { get; set; }

        [DataMember()]
        public personDto person { get; set; }

        public embarzoDto()
        {
        }

        public embarzoDto(String v_EmbarazoId, String v_PersonId, String v_Anio, String v_Cpn, String v_Complicacion, String v_Parto, String v_PesoRn, String v_Puerpio, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate, String v_ObservacionesGestacion, personDto person)
        {
			this.v_EmbarazoId = v_EmbarazoId;
			this.v_PersonId = v_PersonId;
			this.v_Anio = v_Anio;
			this.v_Cpn = v_Cpn;
			this.v_Complicacion = v_Complicacion;
			this.v_Parto = v_Parto;
			this.v_PesoRn = v_PesoRn;
			this.v_Puerpio = v_Puerpio;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
			this.v_ObservacionesGestacion = v_ObservacionesGestacion;
			this.person = person;
        }
    }
}
