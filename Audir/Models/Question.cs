using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Audir.Models
{
    public class Question
    {
        private int id;
        private string text;
        private bool reponse;
        private string type;
        public Question()
        {

        }

        public Question(int id, string text,string type)
        {
            this.id = id;
            this.text = text;
            this.Type = type;
        }

        public int Id { get => id; set => id = value; }
        public string Text { get => text; set => text = value; }
        public bool Reponse { get => reponse; set => reponse = value; }
        public string Type { get => type; set => type = value; }
    }
}