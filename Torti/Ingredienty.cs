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
    
    public partial class Ingredienty
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Ingredienty()
        {
            this.Specific_ingredienty = new HashSet<Specific_ingredienty>();
        }
    
        public int Arctikul { get; set; }
        public string Name { get; set; }
        public string Edinitsa_izmereniya { get; set; }
        public string Amount { get; set; }
        public string Main_postavshik { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public string GOST { get; set; }
        public string Fasovka { get; set; }
        public string Characteristic { get; set; }
    
        public virtual Postavshik Postavshik { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specific_ingredienty> Specific_ingredienty { get; set; }
    }
}
