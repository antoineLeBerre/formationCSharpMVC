using System.Collections.Generic;

namespace jeuDontVousEtesLeHeros.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Titre { get; set; }
        public List<Reponse> Reponses { get; set; }
    }
}