//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2019/02/09 - 20:48:30
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
    /// Assembler for <see cref="serviceorderdetail"/> and <see cref="serviceorderdetailDto"/>.
    /// </summary>
    public static partial class serviceorderdetailAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="serviceorderdetailDto"/> converted from <see cref="serviceorderdetail"/>.</param>
        static partial void OnDTO(this serviceorderdetail entity, serviceorderdetailDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="serviceorderdetail"/> converted from <see cref="serviceorderdetailDto"/>.</param>
        static partial void OnEntity(this serviceorderdetailDto dto, serviceorderdetail entity);

        /// <summary>
        /// Converts this instance of <see cref="serviceorderdetailDto"/> to an instance of <see cref="serviceorderdetail"/>.
        /// </summary>
        /// <param name="dto"><see cref="serviceorderdetailDto"/> to convert.</param>
        public static serviceorderdetail ToEntity(this serviceorderdetailDto dto)
        {
            if (dto == null) return null;

            var entity = new serviceorderdetail();

            entity.v_ServiceOrderDetailId = dto.v_ServiceOrderDetailId;
            entity.v_ServiceOrderId = dto.v_ServiceOrderId;
            entity.v_ProtocolId = dto.v_ProtocolId;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.r_ProtocolPrice = dto.r_ProtocolPrice;
            entity.i_NumberOfWorkerProtocol = dto.i_NumberOfWorkerProtocol;
            entity.r_Total = dto.r_Total;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="serviceorderdetail"/> to an instance of <see cref="serviceorderdetailDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="serviceorderdetail"/> to convert.</param>
        public static serviceorderdetailDto ToDTO(this serviceorderdetail entity)
        {
            if (entity == null) return null;

            var dto = new serviceorderdetailDto();

            dto.v_ServiceOrderDetailId = entity.v_ServiceOrderDetailId;
            dto.v_ServiceOrderId = entity.v_ServiceOrderId;
            dto.v_ProtocolId = entity.v_ProtocolId;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.r_ProtocolPrice = entity.r_ProtocolPrice;
            dto.i_NumberOfWorkerProtocol = entity.i_NumberOfWorkerProtocol;
            dto.r_Total = entity.r_Total;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="serviceorderdetailDto"/> to an instance of <see cref="serviceorderdetail"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<serviceorderdetail> ToEntities(this IEnumerable<serviceorderdetailDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="serviceorderdetail"/> to an instance of <see cref="serviceorderdetailDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<serviceorderdetailDto> ToDTOs(this IEnumerable<serviceorderdetail> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
