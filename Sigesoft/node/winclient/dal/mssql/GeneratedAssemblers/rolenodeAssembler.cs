//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/04/03 - 00:50:43
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
    /// Assembler for <see cref="rolenode"/> and <see cref="rolenodeDto"/>.
    /// </summary>
    public static partial class rolenodeAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="rolenodeDto"/> converted from <see cref="rolenode"/>.</param>
        static partial void OnDTO(this rolenode entity, rolenodeDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="rolenode"/> converted from <see cref="rolenodeDto"/>.</param>
        static partial void OnEntity(this rolenodeDto dto, rolenode entity);

        /// <summary>
        /// Converts this instance of <see cref="rolenodeDto"/> to an instance of <see cref="rolenode"/>.
        /// </summary>
        /// <param name="dto"><see cref="rolenodeDto"/> to convert.</param>
        public static rolenode ToEntity(this rolenodeDto dto)
        {
            if (dto == null) return null;

            var entity = new rolenode();

            entity.i_NodeId = dto.i_NodeId;
            entity.i_RoleId = dto.i_RoleId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="rolenode"/> to an instance of <see cref="rolenodeDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="rolenode"/> to convert.</param>
        public static rolenodeDto ToDTO(this rolenode entity)
        {
            if (entity == null) return null;

            var dto = new rolenodeDto();

            dto.i_NodeId = entity.i_NodeId;
            dto.i_RoleId = entity.i_RoleId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="rolenodeDto"/> to an instance of <see cref="rolenode"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<rolenode> ToEntities(this IEnumerable<rolenodeDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="rolenode"/> to an instance of <see cref="rolenodeDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<rolenodeDto> ToDTOs(this IEnumerable<rolenode> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
