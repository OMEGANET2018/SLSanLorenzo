//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/11/23 - 16:15:33
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
    /// Assembler for <see cref="plan"/> and <see cref="planDto"/>.
    /// </summary>
    public static partial class planAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="planDto"/> converted from <see cref="plan"/>.</param>
        static partial void OnDTO(this plan entity, planDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="plan"/> converted from <see cref="planDto"/>.</param>
        static partial void OnEntity(this planDto dto, plan entity);

        /// <summary>
        /// Converts this instance of <see cref="planDto"/> to an instance of <see cref="plan"/>.
        /// </summary>
        /// <param name="dto"><see cref="planDto"/> to convert.</param>
        public static plan ToEntity(this planDto dto)
        {
            if (dto == null) return null;

            var entity = new plan();

            entity.i_PlanId = dto.i_PlanId;
            entity.v_OrganizationSeguroId = dto.v_OrganizationSeguroId;
            entity.v_ProtocoloId = dto.v_ProtocoloId;
            entity.v_IdUnidadProductiva = dto.v_IdUnidadProductiva;
            entity.i_EsDeducible = dto.i_EsDeducible;
            entity.i_EsCoaseguro = dto.i_EsCoaseguro;
            entity.d_Importe = dto.d_Importe;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="plan"/> to an instance of <see cref="planDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="plan"/> to convert.</param>
        public static planDto ToDTO(this plan entity)
        {
            if (entity == null) return null;

            var dto = new planDto();

            dto.i_PlanId = entity.i_PlanId;
            dto.v_OrganizationSeguroId = entity.v_OrganizationSeguroId;
            dto.v_ProtocoloId = entity.v_ProtocoloId;
            dto.v_IdUnidadProductiva = entity.v_IdUnidadProductiva;
            dto.i_EsDeducible = entity.i_EsDeducible;
            dto.i_EsCoaseguro = entity.i_EsCoaseguro;
            dto.d_Importe = entity.d_Importe;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="planDto"/> to an instance of <see cref="plan"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<plan> ToEntities(this IEnumerable<planDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="plan"/> to an instance of <see cref="planDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<planDto> ToDTOs(this IEnumerable<plan> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
