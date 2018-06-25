//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/06/25 - 12:35:18
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
    /// Assembler for <see cref="reporteatencionmedicaResult"/> and <see cref="reporteatencionmedicaResultDto"/>.
    /// </summary>
    public static partial class reporteatencionmedicaResultAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="reporteatencionmedicaResultDto"/> converted from <see cref="reporteatencionmedicaResult"/>.</param>
        static partial void OnDTO(this reporteatencionmedicaResult entity, reporteatencionmedicaResultDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="reporteatencionmedicaResult"/> converted from <see cref="reporteatencionmedicaResultDto"/>.</param>
        static partial void OnEntity(this reporteatencionmedicaResultDto dto, reporteatencionmedicaResult entity);

        /// <summary>
        /// Converts this instance of <see cref="reporteatencionmedicaResultDto"/> to an instance of <see cref="reporteatencionmedicaResult"/>.
        /// </summary>
        /// <param name="dto"><see cref="reporteatencionmedicaResultDto"/> to convert.</param>
        public static reporteatencionmedicaResult ToEntity(this reporteatencionmedicaResultDto dto)
        {
            if (dto == null) return null;

            var entity = new reporteatencionmedicaResult();

            entity.Trabajador = dto.Trabajador;
            entity.FechaServicio = dto.FechaServicio;
            entity.Producto = dto.Producto;
            entity.CantidadRecetada = dto.CantidadRecetada;
            entity.CantidadVendida = dto.CantidadVendida;
            entity.PrecioVenta = dto.PrecioVenta;
            entity.Importe = dto.Importe;
            entity.TipoDocVenta = dto.TipoDocVenta;
            entity.NroDocVenta = dto.NroDocVenta;
            entity.CondicionPago = dto.CondicionPago;
            entity.Vendedor = dto.Vendedor;
            entity.ProfesionalID = dto.ProfesionalID;
            entity.Profesional = dto.Profesional;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="reporteatencionmedicaResult"/> to an instance of <see cref="reporteatencionmedicaResultDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="reporteatencionmedicaResult"/> to convert.</param>
        public static reporteatencionmedicaResultDto ToDTO(this reporteatencionmedicaResult entity)
        {
            if (entity == null) return null;

            var dto = new reporteatencionmedicaResultDto();

            dto.Trabajador = entity.Trabajador;
            dto.FechaServicio = entity.FechaServicio;
            dto.Producto = entity.Producto;
            dto.CantidadRecetada = entity.CantidadRecetada;
            dto.CantidadVendida = entity.CantidadVendida;
            dto.PrecioVenta = entity.PrecioVenta;
            dto.Importe = entity.Importe;
            dto.TipoDocVenta = entity.TipoDocVenta;
            dto.NroDocVenta = entity.NroDocVenta;
            dto.CondicionPago = entity.CondicionPago;
            dto.Vendedor = entity.Vendedor;
            dto.ProfesionalID = entity.ProfesionalID;
            dto.Profesional = entity.Profesional;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="reporteatencionmedicaResultDto"/> to an instance of <see cref="reporteatencionmedicaResult"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<reporteatencionmedicaResult> ToEntities(this IEnumerable<reporteatencionmedicaResultDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="reporteatencionmedicaResult"/> to an instance of <see cref="reporteatencionmedicaResultDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<reporteatencionmedicaResultDto> ToDTOs(this IEnumerable<reporteatencionmedicaResult> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
