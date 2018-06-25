//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/06/25 - 17:06:53
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
    /// Assembler for <see cref="ges"/> and <see cref="gesDto"/>.
    /// </summary>
    public static partial class gesAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="gesDto"/> converted from <see cref="ges"/>.</param>
        static partial void OnDTO(this ges entity, gesDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="ges"/> converted from <see cref="gesDto"/>.</param>
        static partial void OnEntity(this gesDto dto, ges entity);

        /// <summary>
        /// Converts this instance of <see cref="gesDto"/> to an instance of <see cref="ges"/>.
        /// </summary>
        /// <param name="dto"><see cref="gesDto"/> to convert.</param>
        public static ges ToEntity(this gesDto dto)
        {
            if (dto == null) return null;

            var entity = new ges();

            entity.v_GesId = dto.v_GesId;
            entity.v_AreaId = dto.v_AreaId;
            entity.v_Name = dto.v_Name;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="ges"/> to an instance of <see cref="gesDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="ges"/> to convert.</param>
        public static gesDto ToDTO(this ges entity)
        {
            if (entity == null) return null;

            var dto = new gesDto();

            dto.v_GesId = entity.v_GesId;
            dto.v_AreaId = entity.v_AreaId;
            dto.v_Name = entity.v_Name;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="gesDto"/> to an instance of <see cref="ges"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<ges> ToEntities(this IEnumerable<gesDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="ges"/> to an instance of <see cref="gesDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<gesDto> ToDTOs(this IEnumerable<ges> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
