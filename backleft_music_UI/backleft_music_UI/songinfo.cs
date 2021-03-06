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
    
    public partial class songinfo
    {
        public songinfo()
        {
            this.userpurchases = new HashSet<userpurchas>();
            this.userplaylists = new HashSet<userplaylist>();
        }
    
        public int idSongInfo { get; set; }
        public string Title { get; set; }
        public Nullable<int> Artist { get; set; }
        public string Genre { get; set; }
        public Nullable<int> Album { get; set; }
        public string Location { get; set; }
        public Nullable<int> AlbumTrack { get; set; }
        public Nullable<int> Year { get; set; }
        public string Comment { get; set; }
        public Nullable<int> PlayCount { get; set; }
        public Nullable<int> BPM { get; set; }
    
        public virtual songalbum songalbum { get; set; }
        public virtual songartist songartist { get; set; }
        public virtual ICollection<userpurchas> userpurchases { get; set; }
        public virtual ICollection<userplaylist> userplaylists { get; set; }
    }
}
