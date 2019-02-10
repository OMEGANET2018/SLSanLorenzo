//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/02/09 - 20:47:51
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Sigesoft.Node.WinClient.DAL;

namespace Sigesoft.Node.WinClient.BE
{

    /// <summary>
    /// Assembler for <see cref="antecedenteasistencial"/> and <see cref="antecedenteasistencialDto"/>.
    /// </summary>
    public static partial class antecedenteasistencialAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="antecedenteasistencialDto"/> converted from <see cref="antecedenteasistencial"/>.</param>
        static partial void OnDTO(this antecedenteasistencial entity, antecedenteasistencialDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="antecedenteasistencial"/> converted from <see cref="antecedenteasistencialDto"/>.</param>
        static partial void OnEntity(this antecedenteasistencialDto dto, antecedenteasistencial entity);

        /// <summary>
        /// Converts this instance of <see cref="antecedenteasistencialDto"/> to an instance of <see cref="antecedenteasistencial"/>.
        /// </summary>
        /// <param name="dto"><see cref="antecedenteasistencialDto"/> to convert.</param>
        public static antecedenteasistencial ToEntity(this antecedenteasistencialDto dto)
        {
            if (dto == null) return null;

            var entity = new antecedenteasistencial();

            entity.v_AntecendenteAsistencialId = dto.v_AntecendenteAsistencialId;
            entity.v_personId = dto.v_personId;
            entity.i_GrupoEtario = dto.i_GrupoEtario;
            entity.i_GrupoData = dto.i_GrupoData;
            entity.i_ParametroId = dto.i_ParametroId;
            entity.i_Valor = dto.i_Valor;
            entity.i_Quien = dto.i_Quien;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="antecedenteasistencial"/> to an instance of <see cref="antecedenteasistencialDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="antecedenteasistencial"/> to convert.</param>
        public static antecedenteasistencialDto ToDTO(this antecedenteasistencial entity)
        {
            if (entity == null) return null;

            var dto = new antecedenteasistencialDto();

            dto.v_AntecendenteAsistencialId = entity.v_AntecendenteAsistencialId;
            dto.v_personId = entity.v_personId;
            dto.i_GrupoEtario = entity.i_GrupoEtario;
            dto.i_GrupoData = entity.i_GrupoData;
            dto.i_ParametroId = entity.i_ParametroId;
            dto.i_Valor = entity.i_Valor;
            dto.i_Quien = entity.i_Quien;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="antecedenteasistencialDto"/> to an instance of <see cref="antecedenteasistencial"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<antecedenteasistencial> ToEntities(this IEnumerable<antecedenteasistencialDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="antecedenteasistencial"/> to an instance of <see cref="antecedenteasistencialDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<antecedenteasistencialDto> ToDTOs(this IEnumerable<antecedenteasistencial> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
