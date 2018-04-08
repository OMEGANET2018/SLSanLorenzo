//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/04/08 - 16:38:08
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
    /// Assembler for <see cref="history"/> and <see cref="historyDto"/>.
    /// </summary>
    public static partial class historyAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="historyDto"/> converted from <see cref="history"/>.</param>
        static partial void OnDTO(this history entity, historyDto dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="history"/> converted from <see cref="historyDto"/>.</param>
        static partial void OnEntity(this historyDto dto, history entity);

        /// <summary>
        /// Converts this instance of <see cref="historyDto"/> to an instance of <see cref="history"/>.
        /// </summary>
        /// <param name="dto"><see cref="historyDto"/> to convert.</param>
        public static history ToEntity(this historyDto dto)
        {
            if (dto == null) return null;

            var entity = new history();

            entity.v_HistoryId = dto.v_HistoryId;
            entity.v_PersonId = dto.v_PersonId;
            entity.d_StartDate = dto.d_StartDate;
            entity.d_EndDate = dto.d_EndDate;
            entity.v_Organization = dto.v_Organization;
            entity.v_TypeActivity = dto.v_TypeActivity;
            entity.i_GeografixcaHeight = dto.i_GeografixcaHeight;
            entity.v_workstation = dto.v_workstation;
            entity.b_RubricImage = dto.b_RubricImage;
            entity.b_FingerPrintImage = dto.b_FingerPrintImage;
            entity.t_RubricImageText = dto.t_RubricImageText;
            entity.i_IsDeleted = dto.i_IsDeleted;
            entity.i_InsertUserId = dto.i_InsertUserId;
            entity.d_InsertDate = dto.d_InsertDate;
            entity.i_UpdateUserId = dto.i_UpdateUserId;
            entity.d_UpdateDate = dto.d_UpdateDate;
            entity.i_TypeOperationId = dto.i_TypeOperationId;
            entity.i_TrabajoActual = dto.i_TrabajoActual;
            entity.v_FechaUltimaMamo = dto.v_FechaUltimaMamo;
            entity.v_FechaUltimoPAP = dto.v_FechaUltimoPAP;
            entity.v_ResultadoMamo = dto.v_ResultadoMamo;
            entity.v_ResultadosPAP = dto.v_ResultadosPAP;
            entity.i_SoloAnio = dto.i_SoloAnio;
            entity.v_ActividadEmpresa = dto.v_ActividadEmpresa;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="history"/> to an instance of <see cref="historyDto"/>.
        /// </summary>
        /// <param name="entity"><see cref="history"/> to convert.</param>
        public static historyDto ToDTO(this history entity)
        {
            if (entity == null) return null;

            var dto = new historyDto();

            dto.v_HistoryId = entity.v_HistoryId;
            dto.v_PersonId = entity.v_PersonId;
            dto.d_StartDate = entity.d_StartDate;
            dto.d_EndDate = entity.d_EndDate;
            dto.v_Organization = entity.v_Organization;
            dto.v_TypeActivity = entity.v_TypeActivity;
            dto.i_GeografixcaHeight = entity.i_GeografixcaHeight;
            dto.v_workstation = entity.v_workstation;
            dto.b_RubricImage = entity.b_RubricImage;
            dto.b_FingerPrintImage = entity.b_FingerPrintImage;
            dto.t_RubricImageText = entity.t_RubricImageText;
            dto.i_IsDeleted = entity.i_IsDeleted;
            dto.i_InsertUserId = entity.i_InsertUserId;
            dto.d_InsertDate = entity.d_InsertDate;
            dto.i_UpdateUserId = entity.i_UpdateUserId;
            dto.d_UpdateDate = entity.d_UpdateDate;
            dto.i_TypeOperationId = entity.i_TypeOperationId;
            dto.i_TrabajoActual = entity.i_TrabajoActual;
            dto.v_FechaUltimaMamo = entity.v_FechaUltimaMamo;
            dto.v_FechaUltimoPAP = entity.v_FechaUltimoPAP;
            dto.v_ResultadoMamo = entity.v_ResultadoMamo;
            dto.v_ResultadosPAP = entity.v_ResultadosPAP;
            dto.i_SoloAnio = entity.i_SoloAnio;
            dto.v_ActividadEmpresa = entity.v_ActividadEmpresa;

            entity.OnDTO(dto);

            return dto;
        }

        /// <summary>
        /// Converts each instance of <see cref="historyDto"/> to an instance of <see cref="history"/>.
        /// </summary>
        /// <param name="dtos"></param>
        /// <returns></returns>
        public static List<history> ToEntities(this IEnumerable<historyDto> dtos)
        {
            if (dtos == null) return null;

            return dtos.Select(e => e.ToEntity()).ToList();
        }

        /// <summary>
        /// Converts each instance of <see cref="history"/> to an instance of <see cref="historyDto"/>.
        /// </summary>
        /// <param name="entities"></param>
        /// <returns></returns>
        public static List<historyDto> ToDTOs(this IEnumerable<history> entities)
        {
            if (entities == null) return null;

            return entities.Select(e => e.ToDTO()).ToList();
        }

    }
}
