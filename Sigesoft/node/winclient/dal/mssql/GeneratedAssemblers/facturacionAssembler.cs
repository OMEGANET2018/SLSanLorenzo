//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/29 - 10:20:46
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
    /// Assembler for <see cref="facturacion"/> and <see cref="facturacionDto"/>.
    /// </summary>
    public static partial class facturacionAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="facturacionDto"/> converted from <see cref="facturacion"/>.</param>
        static partial void OnDTO(this facturacion entity, facturacionDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="facturacion"/> converted from <see cref="facturacionDto"/>.</param>
        static partial void OnEntity(this facturacionDto dto, facturacion entity);

        /// <summary>
        /// Converts this instance of <see cref="facturacionDto"/> to an instance of <see cref="facturacion"/>.
        /// </summary>
        /// <param name="dto"><see cref="facturacionDto"/> to convert.</param>
        public static facturacion ToEntity(this facturacionDto dto)
        {
            if (dto == null) return null;

            var entity = new facturacion();

            entity.v_FacturacionId = dto.v_FacturacionId;
            entity.d_FechaRegistro = dto.d_FechaRegistro;
            entity.d_FechaCobro = dto.d_FechaCobro;
            entity.v_NumeroFactura = dto.v_NumeroFactura;
            entity.i_EstadoFacturacion = dto.i_EstadoFacturacion;
            entity.v_EmpresaCliente = dto.v_EmpresaCliente;
            entity.v_EmpresaSede = dto.v_EmpresaSede;
            entity.d_Detraccion = dto.d_Detraccion;
            entity.d_SubTotal = dto.d_SubTotal;
            entity.d_Igv = dto.d_Igv;
            entity.d_MontoTotal = dto.d_MontoTotal;
            entity.d_FechaInicio = dto.d_FechaInicio;
            entity.d_FechaFin = dto.d_FechaFin;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.v_Descripcion = dto.v_Descripcion;
            entity.d_Descuento = dto.d_Descuento;
            entity.v_ComentaryUpdate = dto.v_ComentaryUpdate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="facturacion"/> to an instance of <see cref="facturacionDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="facturacion"/> to convert.</param>
        public static facturacionDto ToDTO(this facturacion entity)
        {
            if (entity == null) return null;

            var dto = new facturacionDto();

            dto.v_FacturacionId = entity.v_FacturacionId;
            dto.d_FechaRegistro = entity.d_FechaRegistro;
            dto.d_FechaCobro = entity.d_FechaCobro;
            dto.v_NumeroFactura = entity.v_NumeroFactura;
            dto.i_EstadoFacturacion = entity.i_EstadoFacturacion;
            dto.v_EmpresaCliente = entity.v_EmpresaCliente;
            dto.v_EmpresaSede = entity.v_EmpresaSede;
            dto.d_Detraccion = entity.d_Detraccion;
            dto.d_SubTotal = entity.d_SubTotal;
            dto.d_Igv = entity.d_Igv;
            dto.d_MontoTotal = entity.d_MontoTotal;
            dto.d_FechaInicio = entity.d_FechaInicio;
            dto.d_FechaFin = entity.d_FechaFin;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.v_Descripcion = entity.v_Descripcion;
            dto.d_Descuento = entity.d_Descuento;
            dto.v_ComentaryUpdate = entity.v_ComentaryUpdate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="facturacionDto"/> to an instance of <see cref="facturacion"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<facturacion> ToEntities(this IEnumerable<facturacionDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="facturacion"/> to an instance of <see cref="facturacionDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<facturacionDto> ToDTOs(this IEnumerable<facturacion> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
