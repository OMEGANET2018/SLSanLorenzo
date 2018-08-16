//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/08/16 - 16:09:11
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using Sigesoft.Server.WebClientAdmin.DAL;

namespace Sigesoft.Server.WebClientAdmin.BE
{

    /// <summary>
    /// Assembler for <see cref="codigoempresa"/> and <see cref="codigoempresaDto"/>.
    /// </summary>
    public static partial class codigoempresaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="codigoempresaDto"/> converted from <see cref="codigoempresa"/>.</param>
        static partial void OnDTO(this codigoempresa entity, codigoempresaDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="codigoempresa"/> converted from <see cref="codigoempresaDto"/>.</param>
        static partial void OnEntity(this codigoempresaDto dto, codigoempresa entity);

        /// <summary>
        /// Converts this instance of <see cref="codigoempresaDto"/> to an instance of <see cref="codigoempresa"/>.
        /// </summary>
        /// <param name="dto"><see cref="codigoempresaDto"/> to convert.</param>
        public static codigoempresa ToEntity(this codigoempresaDto dto)
        {
            if (dto == null) return null;

            var entity = new codigoempresa();

            entity.v_CodigoEmpresaId = dto.v_CodigoEmpresaId;
            entity.v_CIIUId = dto.v_CIIUId;
            entity.v_Name = dto.v_Name;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="codigoempresa"/> to an instance of <see cref="codigoempresaDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="codigoempresa"/> to convert.</param>
        public static codigoempresaDto ToDTO(this codigoempresa entity)
        {
            if (entity == null) return null;

            var dto = new codigoempresaDto();

            dto.v_CodigoEmpresaId = entity.v_CodigoEmpresaId;
            dto.v_CIIUId = entity.v_CIIUId;
            dto.v_Name = entity.v_Name;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="codigoempresaDto"/> to an instance of <see cref="codigoempresa"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<codigoempresa> ToEntities(this IEnumerable<codigoempresaDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="codigoempresa"/> to an instance of <see cref="codigoempresaDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<codigoempresaDto> ToDTOs(this IEnumerable<codigoempresa> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
