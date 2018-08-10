//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/08/09 - 16:47:38
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
    /// Assembler for <see cref="typeofeep"/> and <see cref="typeofeepDto"/>.
    /// </summary>
    public static partial class typeofeepAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="typeofeepDto"/> converted from <see cref="typeofeep"/>.</param>
        static partial void OnDTO(this typeofeep entity, typeofeepDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="typeofeep"/> converted from <see cref="typeofeepDto"/>.</param>
        static partial void OnEntity(this typeofeepDto dto, typeofeep entity);

        /// <summary>
        /// Converts this instance of <see cref="typeofeepDto"/> to an instance of <see cref="typeofeep"/>.
        /// </summary>
        /// <param name="dto"><see cref="typeofeepDto"/> to convert.</param>
        public static typeofeep ToEntity(this typeofeepDto dto)
        {
            if (dto == null) return null;

            var entity = new typeofeep();

            entity.v_TypeofEEPId = dto.v_TypeofEEPId;
            entity.v_HistoryId = dto.v_HistoryId;
            entity.i_TypeofEEPId = dto.i_TypeofEEPId;
            entity.r_Percentage = dto.r_Percentage;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="typeofeep"/> to an instance of <see cref="typeofeepDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="typeofeep"/> to convert.</param>
        public static typeofeepDto ToDTO(this typeofeep entity)
        {
            if (entity == null) return null;

            var dto = new typeofeepDto();

            dto.v_TypeofEEPId = entity.v_TypeofEEPId;
            dto.v_HistoryId = entity.v_HistoryId;
            dto.i_TypeofEEPId = entity.i_TypeofEEPId;
            dto.r_Percentage = entity.r_Percentage;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="typeofeepDto"/> to an instance of <see cref="typeofeep"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<typeofeep> ToEntities(this IEnumerable<typeofeepDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="typeofeep"/> to an instance of <see cref="typeofeepDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<typeofeepDto> ToDTOs(this IEnumerable<typeofeep> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
