//-------------------------------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by EntitiesToDTOs.v3.1 (entitiestodtos.codeplex.com).
//     Timestamp: 2018/04/08 - 16:37:09
//
//     Changes to this file may cause incorrect behavior and will be lost if the code is regenerated.
// </auto-generated>
//-------------------------------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Sigesoft.Node.WinClient.BE
{
    [DataContract()]
    public partial class movementdetailDto
    {
        [DataMember()]
        public String v_MovementId { get; set; }

        [DataMember()]
        public String v_ProductId { get; set; }

        [DataMember()]
        public String v_WarehouseId { get; set; }

        [DataMember()]
        public Nullable<Single> r_StockMax { get; set; }

        [DataMember()]
        public Nullable<Single> r_StockMin { get; set; }

        [DataMember()]
        public Nullable<Int32> i_MovementTypeId { get; set; }

        [DataMember()]
        public Nullable<Single> r_Quantity { get; set; }

        [DataMember()]
        public Nullable<Single> r_Price { get; set; }

        [DataMember()]
        public Nullable<Single> r_SubTotal { get; set; }

        [DataMember()]
        public Nullable<DateTime> d_UpdateDate { get; set; }

        [DataMember()]
        public movementDto movement { get; set; }

        [DataMember()]
        public productDto product { get; set; }

        [DataMember()]
        public warehouseDto warehouse { get; set; }

        public movementdetailDto()
        {
        }

        public movementdetailDto(String v_MovementId, String v_ProductId, String v_WarehouseId, Nullable<Single> r_StockMax, Nullable<Single> r_StockMin, Nullable<Int32> i_MovementTypeId, Nullable<Single> r_Quantity, Nullable<Single> r_Price, Nullable<Single> r_SubTotal, Nullable<DateTime> d_UpdateDate, movementDto movement, productDto product, warehouseDto warehouse)
        {
			this.v_MovementId = v_MovementId;
			this.v_ProductId = v_ProductId;
			this.v_WarehouseId = v_WarehouseId;
			this.r_StockMax = r_StockMax;
			this.r_StockMin = r_StockMin;
			this.i_MovementTypeId = i_MovementTypeId;
			this.r_Quantity = r_Quantity;
			this.r_Price = r_Price;
			this.r_SubTotal = r_SubTotal;
			this.d_UpdateDate = d_UpdateDate;
			this.movement = movement;
			this.product = product;
			this.warehouse = warehouse;
        }
    }
}
