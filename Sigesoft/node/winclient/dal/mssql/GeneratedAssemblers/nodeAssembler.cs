//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/06/25 - 17:06:57
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
    /// Assembler for <see cref="node"/> and <see cref="nodeDto"/>.
    /// </summary>
    public static partial class nodeAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="nodeDto"/> converted from <see cref="node"/>.</param>
        static partial void OnDTO(this node entity, nodeDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="node"/> converted from <see cref="nodeDto"/>.</param>
        static partial void OnEntity(this nodeDto dto, node entity);

        /// <summary>
        /// Converts this instance of <see cref="nodeDto"/> to an instance of <see cref="node"/>.
        /// </summary>
        /// <param name="dto"><see cref="nodeDto"/> to convert.</param>
        public static node ToEntity(this nodeDto dto)
        {
            if (dto == null) return null;

            var entity = new node();

            entity.i_NodeId = dto.i_NodeId;
            entity.v_Description = dto.v_Description;
            entity.v_GeografyLocationId = dto.v_GeografyLocationId;
            entity.v_GeografyLocationDescription = dto.v_GeografyLocationDescription;
            entity.i_NodeTypeId = dto.i_NodeTypeId;
            entity.d_BeginDate = dto.d_BeginDate;
            entity.d_EndDate = dto.d_EndDate;
            entity.v_PharmacyWarehouseId = dto.v_PharmacyWarehouseId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="node"/> to an instance of <see cref="nodeDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="node"/> to convert.</param>
        public static nodeDto ToDTO(this node entity)
        {
            if (entity == null) return null;

            var dto = new nodeDto();

            dto.i_NodeId = entity.i_NodeId;
            dto.v_Description = entity.v_Description;
            dto.v_GeografyLocationId = entity.v_GeografyLocationId;
            dto.v_GeografyLocationDescription = entity.v_GeografyLocationDescription;
            dto.i_NodeTypeId = entity.i_NodeTypeId;
            dto.d_BeginDate = entity.d_BeginDate;
            dto.d_EndDate = entity.d_EndDate;
            dto.v_PharmacyWarehouseId = entity.v_PharmacyWarehouseId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="nodeDto"/> to an instance of <see cref="node"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<node> ToEntities(this IEnumerable<nodeDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="node"/> to an instance of <see cref="nodeDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<nodeDto> ToDTOs(this IEnumerable<node> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
