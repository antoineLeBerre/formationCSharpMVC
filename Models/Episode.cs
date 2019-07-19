using System.Collections.Generic;

namespace jeuDontVousEtesLeHeros.Models
{
    public class Episode
    {
        #region Proprieter

        public int Id { get; set; }
        public Paragraphe Paragraphe { get; set; }
        public Question Question { get; set; }    

        #endregion
    }
}