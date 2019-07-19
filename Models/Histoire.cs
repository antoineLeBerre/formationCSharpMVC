using System.Collections.Generic;

namespace jeuDontVousEtesLeHeros.Models
{
    public class Histoire
    {
        #region Propriete

        public int Id { get; set; }
        public List<Episode> Episodes { get; set; }

        #endregion
    }
}