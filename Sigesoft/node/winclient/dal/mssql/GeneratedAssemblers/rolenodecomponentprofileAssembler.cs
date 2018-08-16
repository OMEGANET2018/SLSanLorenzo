//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/08/16 - 15:30:39
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
    /// Assembler for <see cref="rolenodecomponentprofile"/> and <see cref="rolenodecomponentprofileDto"/>.
    /// </summary>
    public static partial class rolenodecomponentprofileAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="rolenodecomponentprofileDto"/> converted from <see cref="rolenodecomponentprofile"/>.</param>
        static partial void OnDTO(this rolenodecomponentprofile entity, rolenodecomponentprofileDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="rolenodecomponentprofile"/> converted from <see cref="rolenodecomponentprofileDto"/>.</param>
        static partial void OnEntity(this rolenodecomponentprofileDto dto, rolenodecomponentprofile entity);

        /// <summary>
        /// Converts this instance of <see cref="rolenodecomponentprofileDto"/> to an instance of <see cref="rolenodecomponentprofile"/>.
        /// </summary>
        /// <param name="dto"><see cref="rolenodecomponentprofileDto"/> to convert.</param>
        public static rolenodecomponentprofile ToEntity(this rolenodecomponentprofileDto dto)
        {
            if (dto == null) return null;

            var entity = new rolenodecomponentprofile();

            entity.v_RoleNodeComponentId = dto.v_RoleNodeComponentId;
            entity.i_NodeId = dto.i_NodeId;
            entity.i_RoleId = dto.i_RoleId;
            entity.v_ComponentId = dto.v_ComponentId;
            entity.i_Read = dto.i_Read;
            entity.i_Write = dto.i_Write;
            entity.i_Dx = dto.i_Dx;
            entity.i_Approved = dto.i_Approved;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="rolenodecomponentprofile"/> to an instance of <see cref="rolenodecomponentprofileDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="rolenodecomponentprofile"/> to convert.</param>
        public static rolenodecomponentprofileDto ToDTO(this rolenodecomponentprofile entity)
        {
            if (entity == null) return null;

            var dto = new rolenodecomponentprofileDto();

            dto.v_RoleNodeComponentId = entity.v_RoleNodeComponentId;
            dto.i_NodeId = entity.i_NodeId;
            dto.i_RoleId = entity.i_RoleId;
            dto.v_ComponentId = entity.v_ComponentId;
            dto.i_Read = entity.i_Read;
            dto.i_Write = entity.i_Write;
            dto.i_Dx = entity.i_Dx;
            dto.i_Approved = entity.i_Approved;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="rolenodecomponentprofileDto"/> to an instance of <see cref="rolenodecomponentprofile"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<rolenodecomponentprofile> ToEntities(this IEnumerable<rolenodecomponentprofileDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="rolenodecomponentprofile"/> to an instance of <see cref="rolenodecomponentprofileDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<rolenodecomponentprofileDto> ToDTOs(this IEnumerable<rolenodecomponentprofile> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
