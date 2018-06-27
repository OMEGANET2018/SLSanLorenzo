//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/06/27 - 09:22:37
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
    /// Assembler for <see cref="servicecomponentfields"/> and <see cref="servicecomponentfieldsDto"/>.
    /// </summary>
    public static partial class servicecomponentfieldsAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="servicecomponentfieldsDto"/> converted from <see cref="servicecomponentfields"/>.</param>
        static partial void OnDTO(this servicecomponentfields entity, servicecomponentfieldsDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="servicecomponentfields"/> converted from <see cref="servicecomponentfieldsDto"/>.</param>
        static partial void OnEntity(this servicecomponentfieldsDto dto, servicecomponentfields entity);

        /// <summary>
        /// Converts this instance of <see cref="servicecomponentfieldsDto"/> to an instance of <see cref="servicecomponentfields"/>.
        /// </summary>
        /// <param name="dto"><see cref="servicecomponentfieldsDto"/> to convert.</param>
        public static servicecomponentfields ToEntity(this servicecomponentfieldsDto dto)
        {
            if (dto == null) return null;

            var entity = new servicecomponentfields();

            entity.v_ServiceComponentFieldsId = dto.v_ServiceComponentFieldsId;
            entity.v_ServiceComponentId = dto.v_ServiceComponentId;
            entity.v_ComponentId = dto.v_ComponentId;
            entity.v_ComponentFieldId = dto.v_ComponentFieldId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="servicecomponentfields"/> to an instance of <see cref="servicecomponentfieldsDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="servicecomponentfields"/> to convert.</param>
        public static servicecomponentfieldsDto ToDTO(this servicecomponentfields entity)
        {
            if (entity == null) return null;

            var dto = new servicecomponentfieldsDto();

            dto.v_ServiceComponentFieldsId = entity.v_ServiceComponentFieldsId;
            dto.v_ServiceComponentId = entity.v_ServiceComponentId;
            dto.v_ComponentId = entity.v_ComponentId;
            dto.v_ComponentFieldId = entity.v_ComponentFieldId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="servicecomponentfieldsDto"/> to an instance of <see cref="servicecomponentfields"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<servicecomponentfields> ToEntities(this IEnumerable<servicecomponentfieldsDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="servicecomponentfields"/> to an instance of <see cref="servicecomponentfieldsDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<servicecomponentfieldsDto> ToDTOs(this IEnumerable<servicecomponentfields> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
