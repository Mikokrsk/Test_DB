//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test_DB_2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Agreements
    {
        public int ID { get; set; }
        public System.DateTime Date_of_holding { get; set; }
        public int ApartmentsID { get; set; }
        public int BuyersID { get; set; }
        public int WorkersID { get; set; }
    
        public virtual Apartments Apartments { get; set; }
        public virtual Buyers Buyers { get; set; }
        public virtual Workers Workers { get; set; }
    }
}
