//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/07/30 - 15:30:25
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
    /// Assembler for <see cref="servicemultimedia"/> and <see cref="servicemultimediaDto"/>.
    /// </summary>
    public static partial class servicemultimediaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="servicemultimediaDto"/> converted from <see cref="servicemultimedia"/>.</param>
        static partial void OnDTO(this servicemultimedia entity, servicemultimediaDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="servicemultimedia"/> converted from <see cref="servicemultimediaDto"/>.</param>
        static partial void OnEntity(this servicemultimediaDto dto, servicemultimedia entity);

        /// <summary>
        /// Converts this instance of <see cref="servicemultimediaDto"/> to an instance of <see cref="servicemultimedia"/>.
        /// </summary>
        /// <param name="dto"><see cref="servicemultimediaDto"/> to convert.</param>
        public static servicemultimedia ToEntity(this servicemultimediaDto dto)
        {
            if (dto == null) return null;

            var entity = new servicemultimedia();

            entity.v_ServiceMultimediaId = dto.v_ServiceMultimediaId;
            entity.v_ServiceId = dto.v_ServiceId;
            entity.v_MultimediaFileId = dto.v_MultimediaFileId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="servicemultimedia"/> to an instance of <see cref="servicemultimediaDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="servicemultimedia"/> to convert.</param>
        public static servicemultimediaDto ToDTO(this servicemultimedia entity)
        {
            if (entity == null) return null;

            var dto = new servicemultimediaDto();

            dto.v_ServiceMultimediaId = entity.v_ServiceMultimediaId;
            dto.v_ServiceId = entity.v_ServiceId;
            dto.v_MultimediaFileId = entity.v_MultimediaFileId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="servicemultimediaDto"/> to an instance of <see cref="servicemultimedia"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<servicemultimedia> ToEntities(this IEnumerable<servicemultimediaDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="servicemultimedia"/> to an instance of <see cref="servicemultimediaDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<servicemultimediaDto> ToDTOs(this IEnumerable<servicemultimedia> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
