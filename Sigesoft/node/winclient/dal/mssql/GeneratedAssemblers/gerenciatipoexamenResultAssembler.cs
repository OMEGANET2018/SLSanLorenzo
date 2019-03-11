//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/03/11 - 15:30:39
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
    /// Assembler for <see cref="gerenciatipoexamenResult"/> and <see cref="gerenciatipoexamenResultDto"/>.
    /// </summary>
    public static partial class gerenciatipoexamenResultAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="gerenciatipoexamenResultDto"/> converted from <see cref="gerenciatipoexamenResult"/>.</param>
        static partial void OnDTO(this gerenciatipoexamenResult entity, gerenciatipoexamenResultDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="gerenciatipoexamenResult"/> converted from <see cref="gerenciatipoexamenResultDto"/>.</param>
        static partial void OnEntity(this gerenciatipoexamenResultDto dto, gerenciatipoexamenResult entity);

        /// <summary>
        /// Converts this instance of <see cref="gerenciatipoexamenResultDto"/> to an instance of <see cref="gerenciatipoexamenResult"/>.
        /// </summary>
        /// <param name="dto"><see cref="gerenciatipoexamenResultDto"/> to convert.</param>
        public static gerenciatipoexamenResult ToEntity(this gerenciatipoexamenResultDto dto)
        {
            if (dto == null) return null;

            var entity = new gerenciatipoexamenResult();

            entity.TipoEso = dto.TipoEso;
            entity.Empresa = dto.Empresa;
            entity.Trabajador = dto.Trabajador;
            entity.CostoExamen = dto.CostoExamen;
            entity.Comprobante = dto.Comprobante;
            entity.FechaFactura = dto.FechaFactura;
            entity.ServiceId = dto.ServiceId;
            entity.FechaServicio = dto.FechaServicio;
            entity.UsuarioAgenda = dto.UsuarioAgenda;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="gerenciatipoexamenResult"/> to an instance of <see cref="gerenciatipoexamenResultDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="gerenciatipoexamenResult"/> to convert.</param>
        public static gerenciatipoexamenResultDto ToDTO(this gerenciatipoexamenResult entity)
        {
            if (entity == null) return null;

            var dto = new gerenciatipoexamenResultDto();

            dto.TipoEso = entity.TipoEso;
            dto.Empresa = entity.Empresa;
            dto.Trabajador = entity.Trabajador;
            dto.CostoExamen = entity.CostoExamen;
            dto.Comprobante = entity.Comprobante;
            dto.FechaFactura = entity.FechaFactura;
            dto.ServiceId = entity.ServiceId;
            dto.FechaServicio = entity.FechaServicio;
            dto.UsuarioAgenda = entity.UsuarioAgenda;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="gerenciatipoexamenResultDto"/> to an instance of <see cref="gerenciatipoexamenResult"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<gerenciatipoexamenResult> ToEntities(this IEnumerable<gerenciatipoexamenResultDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="gerenciatipoexamenResult"/> to an instance of <see cref="gerenciatipoexamenResultDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<gerenciatipoexamenResultDto> ToDTOs(this IEnumerable<gerenciatipoexamenResult> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
