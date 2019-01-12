using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Audir
{
    public class Resultat_type
    {
        private int oui;
        private int non;
        private int non_traité;
        private int score;
        private string type;

        public Resultat_type(int oui, int non, int non_traité, int score, string type)
        {
            this.Oui = oui;
            this.Non = non;
            this.Non_traité = non_traité;
            this.Score = score;
            this.Type = type;
        }

        public int Oui { get => oui; set => oui = value; }
        public int Non { get => non; set => non = value; }
        public int Non_traité { get => non_traité; set => non_traité = value; }
        public int Score { get => score; set => score = value; }
        public string Type { get => type; set => type = value; }
    }
}