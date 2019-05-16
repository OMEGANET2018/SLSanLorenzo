//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/16 - 16:35:14
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
    /// Assembler for <see cref="liquidacion"/> and <see cref="liquidacionDto"/>.
    /// </summary>
    public static partial class liquidacionAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="liquidacionDto"/> converted from <see cref="liquidacion"/>.</param>
        static partial void OnDTO(this liquidacion entity, liquidacionDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="liquidacion"/> converted from <see cref="liquidacionDto"/>.</param>
        static partial void OnEntity(this liquidacionDto dto, liquidacion entity);

        /// <summary>
        /// Converts this instance of <see cref="liquidacionDto"/> to an instance of <see cref="liquidacion"/>.
        /// </summary>
        /// <param name="dto"><see cref="liquidacionDto"/> to convert.</param>
        public static liquidacion ToEntity(this liquidacionDto dto)
        {
            if (dto == null) return null;

            var entity = new liquidacion();

            entity.v_LiquidacionId = dto.v_LiquidacionId;
            entity.v_NroLiquidacion = dto.v_NroLiquidacion;
            entity.v_OrganizationId = dto.v_OrganizationId;
            entity.d_Monto = dto.d_Monto;
            entity.d_FechaVencimiento = dto.d_FechaVencimiento;
            entity.v_NroFactura = dto.v_NroFactura;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.v_ServiceId = dto.v_ServiceId;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="liquidacion"/> to an instance of <see cref="liquidacionDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="liquidacion"/> to convert.</param>
        public static liquidacionDto ToDTO(this liquidacion entity)
        {
            if (entity == null) return null;

            var dto = new liquidacionDto();

            dto.v_LiquidacionId = entity.v_LiquidacionId;
            dto.v_NroLiquidacion = entity.v_NroLiquidacion;
            dto.v_OrganizationId = entity.v_OrganizationId;
            dto.d_Monto = entity.d_Monto;
            dto.d_FechaVencimiento = entity.d_FechaVencimiento;
            dto.v_NroFactura = entity.v_NroFactura;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.v_ServiceId = entity.v_ServiceId;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="liquidacionDto"/> to an instance of <see cref="liquidacion"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<liquidacion> ToEntities(this IEnumerable<liquidacionDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="liquidacion"/> to an instance of <see cref="liquidacionDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<liquidacionDto> ToDTOs(this IEnumerable<liquidacion> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
