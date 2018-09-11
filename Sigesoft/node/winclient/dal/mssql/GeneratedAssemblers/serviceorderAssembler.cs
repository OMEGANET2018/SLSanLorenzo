//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/09/10 - 11:18:45
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
    /// Assembler for <see cref="serviceorder"/> and <see cref="serviceorderDto"/>.
    /// </summary>
    public static partial class serviceorderAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="serviceorderDto"/> converted from <see cref="serviceorder"/>.</param>
        static partial void OnDTO(this serviceorder entity, serviceorderDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="serviceorder"/> converted from <see cref="serviceorderDto"/>.</param>
        static partial void OnEntity(this serviceorderDto dto, serviceorder entity);

        /// <summary>
        /// Converts this instance of <see cref="serviceorderDto"/> to an instance of <see cref="serviceorder"/>.
        /// </summary>
        /// <param name="dto"><see cref="serviceorderDto"/> to convert.</param>
        public static serviceorder ToEntity(this serviceorderDto dto)
        {
            if (dto == null) return null;

            var entity = new serviceorder();

            entity.v_ServiceOrderId = dto.v_ServiceOrderId;
            entity.v_CustomServiceOrderId = dto.v_CustomServiceOrderId;
            entity.v_Description = dto.v_Description;
            entity.v_Comentary = dto.v_Comentary;
            entity.i_NumberOfWorker = dto.i_NumberOfWorker;
            entity.r_TotalCost = dto.r_TotalCost;
            entity.d_DeliveryDate = dto.d_DeliveryDate;
            entity.i_ServiceOrderStatusId = dto.i_ServiceOrderStatusId;
            entity.i_LineaCreditoId = dto.i_LineaCreditoId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.i_MostrarPrecio = dto.i_MostrarPrecio;
            entity.i_EsProtocoloEspecial = dto.i_EsProtocoloEspecial;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="serviceorder"/> to an instance of <see cref="serviceorderDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="serviceorder"/> to convert.</param>
        public static serviceorderDto ToDTO(this serviceorder entity)
        {
            if (entity == null) return null;

            var dto = new serviceorderDto();

            dto.v_ServiceOrderId = entity.v_ServiceOrderId;
            dto.v_CustomServiceOrderId = entity.v_CustomServiceOrderId;
            dto.v_Description = entity.v_Description;
            dto.v_Comentary = entity.v_Comentary;
            dto.i_NumberOfWorker = entity.i_NumberOfWorker;
            dto.r_TotalCost = entity.r_TotalCost;
            dto.d_DeliveryDate = entity.d_DeliveryDate;
            dto.i_ServiceOrderStatusId = entity.i_ServiceOrderStatusId;
            dto.i_LineaCreditoId = entity.i_LineaCreditoId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.i_MostrarPrecio = entity.i_MostrarPrecio;
            dto.i_EsProtocoloEspecial = entity.i_EsProtocoloEspecial;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="serviceorderDto"/> to an instance of <see cref="serviceorder"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<serviceorder> ToEntities(this IEnumerable<serviceorderDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="serviceorder"/> to an instance of <see cref="serviceorderDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<serviceorderDto> ToDTOs(this IEnumerable<serviceorder> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
