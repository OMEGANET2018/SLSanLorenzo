//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/09 - 17:46:24
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
    /// Assembler for <see cref="rolcuotadetalle"/> and <see cref="rolcuotadetalleDto"/>.
    /// </summary>
    public static partial class rolcuotadetalleAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="rolcuotadetalleDto"/> converted from <see cref="rolcuotadetalle"/>.</param>
        static partial void OnDTO(this rolcuotadetalle entity, rolcuotadetalleDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="rolcuotadetalle"/> converted from <see cref="rolcuotadetalleDto"/>.</param>
        static partial void OnEntity(this rolcuotadetalleDto dto, rolcuotadetalle entity);

        /// <summary>
        /// Converts this instance of <see cref="rolcuotadetalleDto"/> to an instance of <see cref="rolcuotadetalle"/>.
        /// </summary>
        /// <param name="dto"><see cref="rolcuotadetalleDto"/> to convert.</param>
        public static rolcuotadetalle ToEntity(this rolcuotadetalleDto dto)
        {
            if (dto == null) return null;

            var entity = new rolcuotadetalle();

            entity.v_RolCuotaDetalleId = dto.v_RolCuotaDetalleId;
            entity.v_IdProducto = dto.v_IdProducto;
            entity.v_ProductoNombre = dto.v_ProductoNombre;
            entity.v_RolCuotaId = dto.v_RolCuotaId;
            entity.i_Cuota = dto.i_Cuota;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="rolcuotadetalle"/> to an instance of <see cref="rolcuotadetalleDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="rolcuotadetalle"/> to convert.</param>
        public static rolcuotadetalleDto ToDTO(this rolcuotadetalle entity)
        {
            if (entity == null) return null;

            var dto = new rolcuotadetalleDto();

            dto.v_RolCuotaDetalleId = entity.v_RolCuotaDetalleId;
            dto.v_IdProducto = entity.v_IdProducto;
            dto.v_ProductoNombre = entity.v_ProductoNombre;
            dto.v_RolCuotaId = entity.v_RolCuotaId;
            dto.i_Cuota = entity.i_Cuota;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="rolcuotadetalleDto"/> to an instance of <see cref="rolcuotadetalle"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<rolcuotadetalle> ToEntities(this IEnumerable<rolcuotadetalleDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="rolcuotadetalle"/> to an instance of <see cref="rolcuotadetalleDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<rolcuotadetalleDto> ToDTOs(this IEnumerable<rolcuotadetalle> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
