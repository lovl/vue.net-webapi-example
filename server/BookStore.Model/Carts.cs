//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Carts
    {
        public int CartId { get; set; }
        public string Username { get; set; }
        public int BookId { get; set; }
        public int Count { get; set; }
        public System.DateTime DateCreated { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
    
        public virtual Books Books { get; set; }
        public virtual Users Users { get; set; }
    }
}