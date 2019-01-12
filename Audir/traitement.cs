using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Audir
{
    public class traitement
    {
        private int nb_qst;
        private int nbqsttraité;
        private int nbqstnontrairé;
        private string type;

        public traitement(int nb_qst, int nbqsttraité, int nbqstnontrairé, string type)
        {
            this.nb_qst = nb_qst;
            this.nbqsttraité = nbqsttraité;
            this.nbqstnontrairé = nbqstnontrairé;
            this.type = type;
        }

        public int Nb_qst { get => nb_qst; set => nb_qst = value; }
        public int Nbqsttraité { get => nbqsttraité; set => nbqsttraité = value; }
        public int Nbqstnontrairé { get => nbqstnontrairé; set => nbqstnontrairé = value; }
        public string Type { get => type; set => type = value; }
    }
}