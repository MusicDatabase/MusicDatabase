//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace backleft_music_UI
{
    using System;
    using System.Collections.Generic;
    
    public partial class userpurchas
    {
        public userpurchas()
        {
            this.userinfoes = new HashSet<userinfo>();
        }
    
        public int userPurchasesID { get; set; }
        public Nullable<int> idSongInfo { get; set; }
    
        public virtual songinfo songinfo { get; set; }
        public virtual ICollection<userinfo> userinfoes { get; set; }
    }
}
