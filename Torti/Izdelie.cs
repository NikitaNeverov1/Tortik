//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Torti
{
    using System;
    using System.Collections.Generic;
    
    public partial class Izdelie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Izdelie()
        {
            this.Specific_operation = new HashSet<Specific_operation>();
            this.Zakaz = new HashSet<Zakaz>();
            this.Specific_tort_decoration = new HashSet<Specific_tort_decoration>();
            this.Specific_ingredienty = new HashSet<Specific_ingredienty>();
            this.Specific_PFabricat = new HashSet<Specific_PFabricat>();
            this.Specific_PFabricat1 = new HashSet<Specific_PFabricat>();
        }
    
        public string Name { get; set; }
        public int Size { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specific_operation> Specific_operation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zakaz> Zakaz { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specific_tort_decoration> Specific_tort_decoration { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specific_ingredienty> Specific_ingredienty { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specific_PFabricat> Specific_PFabricat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specific_PFabricat> Specific_PFabricat1 { get; set; }
    }
}