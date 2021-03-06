
//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace entity
{

using System;
    using System.Collections.Generic;
    
public partial class CainzProduct
{

    public CainzProduct()
    {

        this.CainzOrderDetail = new HashSet<CainzOrderDetail>();

    }


    public System.Guid ProductID { get; set; }

    public string ProductBarcode { get; set; }

    public string ProductName { get; set; }

    public string ProductMaterial { get; set; }

    public string ProductSize { get; set; }

    public string ProductColor { get; set; }

    public Nullable<decimal> ProductPrice { get; set; }

    public System.DateTime CreateTime { get; set; }

    public int Deleted { get; set; }

    public System.DateTime ModifyTime { get; set; }

    public int Modified { get; set; }

    public Nullable<System.Guid> TraderID { get; set; }

    public string TraderName { get; set; }

    public System.Guid CainzTraderTraderID { get; set; }



    public virtual ICollection<CainzOrderDetail> CainzOrderDetail { get; set; }

    public virtual CainzTrader CainzTrader { get; set; }

}

}
