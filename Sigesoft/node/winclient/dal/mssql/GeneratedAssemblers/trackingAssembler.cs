//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/05/24 - 17:49:39
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
    /// Assembler for <see cref="tracking"/> and <see cref="trackingDto"/>.
    /// </summary>
    public static partial class trackingAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="trackingDto"/> converted from <see cref="tracking"/>.</param>
        static partial void OnDTO(this tracking entity, trackingDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="tracking"/> converted from <see cref="trackingDto"/>.</param>
        static partial void OnEntity(this trackingDto dto, tracking entity);

        /// <summary>
        /// Converts this instance of <see cref="trackingDto"/> to an instance of <see cref="tracking"/>.
        /// </summary>
        /// <param name="dto"><see cref="trackingDto"/> to convert.</param>
        public static tracking ToEntity(this trackingDto dto)
        {
            if (dto == null) return null;

            var entity = new tracking();

            entity.v_SeguroId = dto.v_SeguroId;
            entity.v_PersonId = dto.v_PersonId;
            entity.i_Agenda = dto.i_Agenda;
            entity.i_CartaGarantia = dto.i_CartaGarantia;
            entity.i_AtencionMedica = dto.i_AtencionMedica;
            entity.i_PreLiquidacion = dto.i_PreLiquidacion;
            entity.i_ControlCalidad = dto.i_ControlCalidad;
            entity.i_Facturacion = dto.i_Facturacion;
            entity.i_Culminado = dto.i_Culminado;
            entity.v_ServiceId = dto.v_ServiceId;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="tracking"/> to an instance of <see cref="trackingDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="tracking"/> to convert.</param>
        public static trackingDto ToDTO(this tracking entity)
        {
            if (entity == null) return null;

            var dto = new trackingDto();

            dto.v_SeguroId = entity.v_SeguroId;
            dto.v_PersonId = entity.v_PersonId;
            dto.i_Agenda = entity.i_Agenda;
            dto.i_CartaGarantia = entity.i_CartaGarantia;
            dto.i_AtencionMedica = entity.i_AtencionMedica;
            dto.i_PreLiquidacion = entity.i_PreLiquidacion;
            dto.i_ControlCalidad = entity.i_ControlCalidad;
            dto.i_Facturacion = entity.i_Facturacion;
            dto.i_Culminado = entity.i_Culminado;
            dto.v_ServiceId = entity.v_ServiceId;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="trackingDto"/> to an instance of <see cref="tracking"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<tracking> ToEntities(this IEnumerable<trackingDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="tracking"/> to an instance of <see cref="trackingDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<trackingDto> ToDTOs(this IEnumerable<tracking> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
