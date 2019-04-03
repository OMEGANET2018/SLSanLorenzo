//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/04/03 - 00:49:58
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
    /// Assembler for <see cref="area"/> and <see cref="areaDto"/>.
    /// </summary>
    public static partial class areaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="areaDto"/> converted from <see cref="area"/>.</param>
        static partial void OnDTO(this area entity, areaDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="area"/> converted from <see cref="areaDto"/>.</param>
        static partial void OnEntity(this areaDto dto, area entity);

        /// <summary>
        /// Converts this instance of <see cref="areaDto"/> to an instance of <see cref="area"/>.
        /// </summary>
        /// <param name="dto"><see cref="areaDto"/> to convert.</param>
        public static area ToEntity(this areaDto dto)
        {
            if (dto == null) return null;

            var entity = new area();

            entity.v_AreaId = dto.v_AreaId;
            entity.v_LocationId = dto.v_LocationId;
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
        /// Converts this instance of <see cref="area"/> to an instance of <see cref="areaDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="area"/> to convert.</param>
        public static areaDto ToDTO(this area entity)
        {
            if (entity == null) return null;

            var dto = new areaDto();

            dto.v_AreaId = entity.v_AreaId;
            dto.v_LocationId = entity.v_LocationId;
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
        /// Converts each instance of <see cref="areaDto"/> to an instance of <see cref="area"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<area> ToEntities(this IEnumerable<areaDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="area"/> to an instance of <see cref="areaDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<areaDto> ToDTOs(this IEnumerable<area> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
