//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/01/04 - 09:57:11
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
    public partial class antecedenteasistencialDto
    {
        [DataMember()]
        public String v_AntecendenteAsistencialId { get; set; }

        [DataMember()]
        public String v_personId { get; set; }

        [DataMember()]
        public Int32 i_GrupoEtario { get; set; }

        [DataMember()]
        public Int32 i_GrupoData { get; set; }

        [DataMember()]
        public Int32 i_ParametroId { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Valor { get; set; }

        [DataMember()]
        public Nullable<Int32> i_Quien { get; set; }

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

        public antecedenteasistencialDto()
        {
        }

        public antecedenteasistencialDto(String v_AntecendenteAsistencialId, String v_personId, Int32 i_GrupoEtario, Int32 i_GrupoData, Int32 i_ParametroId, Nullable<Int32> i_Valor, Nullable<Int32> i_Quien, Nullable<Int32> i_IsDeleted, Nullable<Int32> i_InsertUserId, Nullable<DateTime> d_InsertDate, Nullable<Int32> i_UpdateUserId, Nullable<DateTime> d_UpdateDate)
        {
			this.v_AntecendenteAsistencialId = v_AntecendenteAsistencialId;
			this.v_personId = v_personId;
			this.i_GrupoEtario = i_GrupoEtario;
			this.i_GrupoData = i_GrupoData;
			this.i_ParametroId = i_ParametroId;
			this.i_Valor = i_Valor;
			this.i_Quien = i_Quien;
			this.i_IsDeleted = i_IsDeleted;
			this.i_InsertUserId = i_InsertUserId;
			this.d_InsertDate = d_InsertDate;
			this.i_UpdateUserId = i_UpdateUserId;
			this.d_UpdateDate = d_UpdateDate;
        }
    }
}
