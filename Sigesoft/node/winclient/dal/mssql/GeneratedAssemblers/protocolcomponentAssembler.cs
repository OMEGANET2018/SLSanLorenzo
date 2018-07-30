//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/07/30 - 15:30:13
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
    /// Assembler for <see cref="protocolcomponent"/> and <see cref="protocolcomponentDto"/>.
    /// </summary>
    public static partial class protocolcomponentAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="protocolcomponentDto"/> converted from <see cref="protocolcomponent"/>.</param>
        static partial void OnDTO(this protocolcomponent entity, protocolcomponentDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="protocolcomponent"/> converted from <see cref="protocolcomponentDto"/>.</param>
        static partial void OnEntity(this protocolcomponentDto dto, protocolcomponent entity);

        /// <summary>
        /// Converts this instance of <see cref="protocolcomponentDto"/> to an instance of <see cref="protocolcomponent"/>.
        /// </summary>
        /// <param name="dto"><see cref="protocolcomponentDto"/> to convert.</param>
        public static protocolcomponent ToEntity(this protocolcomponentDto dto)
        {
            if (dto == null) return null;

            var entity = new protocolcomponent();

            entity.v_ProtocolComponentId = dto.v_ProtocolComponentId;
            entity.v_ProtocolId = dto.v_ProtocolId;
            entity.v_ComponentId = dto.v_ComponentId;
            entity.r_Price = dto.r_Price;
            entity.i_OperatorId = dto.i_OperatorId;
            entity.i_Age = dto.i_Age;
            entity.i_GenderId = dto.i_GenderId;
            entity.i_GrupoEtarioId = dto.i_GrupoEtarioId;
            entity.i_IsConditionalId = dto.i_IsConditionalId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.i_IsConditionalIMC = dto.i_IsConditionalIMC;
            entity.r_Imc = dto.r_Imc;
            entity.i_IsAdditional = dto.i_IsAdditional;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="protocolcomponent"/> to an instance of <see cref="protocolcomponentDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="protocolcomponent"/> to convert.</param>
        public static protocolcomponentDto ToDTO(this protocolcomponent entity)
        {
            if (entity == null) return null;

            var dto = new protocolcomponentDto();

            dto.v_ProtocolComponentId = entity.v_ProtocolComponentId;
            dto.v_ProtocolId = entity.v_ProtocolId;
            dto.v_ComponentId = entity.v_ComponentId;
            dto.r_Price = entity.r_Price;
            dto.i_OperatorId = entity.i_OperatorId;
            dto.i_Age = entity.i_Age;
            dto.i_GenderId = entity.i_GenderId;
            dto.i_GrupoEtarioId = entity.i_GrupoEtarioId;
            dto.i_IsConditionalId = entity.i_IsConditionalId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.i_IsConditionalIMC = entity.i_IsConditionalIMC;
            dto.r_Imc = entity.r_Imc;
            dto.i_IsAdditional = entity.i_IsAdditional;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="protocolcomponentDto"/> to an instance of <see cref="protocolcomponent"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<protocolcomponent> ToEntities(this IEnumerable<protocolcomponentDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="protocolcomponent"/> to an instance of <see cref="protocolcomponentDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<protocolcomponentDto> ToDTOs(this IEnumerable<protocolcomponent> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
