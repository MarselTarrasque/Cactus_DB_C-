//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lesson2_Cactus.DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cactus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cactus()
        {
            this.Contestant = new HashSet<Contestant>();
            this.Rewarded_Cactuses = new HashSet<Rewarded_Cactuses>();
        }
    
        public int ID_Cactus { get; set; }
        public string Name_Cactus { get; set; }
        public string Type_of_cactus { get; set; }
        public Nullable<int> Age_cactus { get; set; }
        public string Origins_cactus { get; set; }
        public Nullable<int> Cost_cactus { get; set; }
        public string Manuals_cactus { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Contestant> Contestant { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rewarded_Cactuses> Rewarded_Cactuses { get; set; }
    }
}
