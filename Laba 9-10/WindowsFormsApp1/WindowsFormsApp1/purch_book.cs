//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class purch_book
    {
        public int id_book { get; set; }
        public int id_publish { get; set; }
        public int id_purchase { get; set; }
        public Nullable<int> pb_count { get; set; }
    
        public virtual book book { get; set; }
        public virtual publish publish { get; set; }
        public virtual purchase purchase { get; set; }
    }
}
