//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/04/01 - 14:37:06
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
    /// Assembler for <see cref="gerenciatipopagoResult"/> and <see cref="gerenciatipopagoResultDto"/>.
    /// </summary>
    public static partial class gerenciatipopagoResultAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="gerenciatipopagoResultDto"/> converted from <see cref="gerenciatipopagoResult"/>.</param>
        static partial void OnDTO(this gerenciatipopagoResult entity, gerenciatipopagoResultDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="gerenciatipopagoResult"/> converted from <see cref="gerenciatipopagoResultDto"/>.</param>
        static partial void OnEntity(this gerenciatipopagoResultDto dto, gerenciatipopagoResult entity);

        /// <summary>
        /// Converts this instance of <see cref="gerenciatipopagoResultDto"/> to an instance of <see cref="gerenciatipopagoResult"/>.
        /// </summary>
        /// <param name="dto"><see cref="gerenciatipopagoResultDto"/> to convert.</param>
        public static gerenciatipopagoResult ToEntity(this gerenciatipopagoResultDto dto)
        {
            if (dto == null) return null;

            var entity = new gerenciatipopagoResult();

            entity.IdCondicionPago = dto.IdCondicionPago;
            entity.CondicionPago = dto.CondicionPago;
            entity.FechaFactura = dto.FechaFactura;
            entity.Comprobante = dto.Comprobante;
            entity.FechaFactura1 = dto.FechaFactura1;
            entity.Empresa = dto.Empresa;
            entity.v_NroDocIdentificacion = dto.v_NroDocIdentificacion;
            entity.Importe = dto.Importe;
            entity.ServiceId = dto.ServiceId;
            entity.Trabajador = dto.Trabajador;
            entity.FechaServicio = dto.FechaServicio;
            entity.Compania = dto.Compania;
            entity.Contratista = dto.Contratista;
            entity.CostoExamen = dto.CostoExamen;
            entity.TipoEso = dto.TipoEso;
            entity.Agrupador = dto.Agrupador;
            entity.UsuarioAgenda = dto.UsuarioAgenda;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="gerenciatipopagoResult"/> to an instance of <see cref="gerenciatipopagoResultDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="gerenciatipopagoResult"/> to convert.</param>
        public static gerenciatipopagoResultDto ToDTO(this gerenciatipopagoResult entity)
        {
            if (entity == null) return null;

            var dto = new gerenciatipopagoResultDto();

            dto.IdCondicionPago = entity.IdCondicionPago;
            dto.CondicionPago = entity.CondicionPago;
            dto.FechaFactura = entity.FechaFactura;
            dto.Comprobante = entity.Comprobante;
            dto.FechaFactura1 = entity.FechaFactura1;
            dto.Empresa = entity.Empresa;
            dto.v_NroDocIdentificacion = entity.v_NroDocIdentificacion;
            dto.Importe = entity.Importe;
            dto.ServiceId = entity.ServiceId;
            dto.Trabajador = entity.Trabajador;
            dto.FechaServicio = entity.FechaServicio;
            dto.Compania = entity.Compania;
            dto.Contratista = entity.Contratista;
            dto.CostoExamen = entity.CostoExamen;
            dto.TipoEso = entity.TipoEso;
            dto.Agrupador = entity.Agrupador;
            dto.UsuarioAgenda = entity.UsuarioAgenda;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="gerenciatipopagoResultDto"/> to an instance of <see cref="gerenciatipopagoResult"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<gerenciatipopagoResult> ToEntities(this IEnumerable<gerenciatipopagoResultDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="gerenciatipopagoResult"/> to an instance of <see cref="gerenciatipopagoResultDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<gerenciatipopagoResultDto> ToDTOs(this IEnumerable<gerenciatipopagoResult> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
