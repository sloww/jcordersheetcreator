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
        public int ID { get; set; }
        public string Barcode { get; set; }
        public int FactoryID { get; set; }
        public string FactoryName { get; set; }
        public string Material { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public Nullable<decimal> Price { get; set; }
        public System.DateTime CreateTime { get; set; }
    }
}