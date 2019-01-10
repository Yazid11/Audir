using Audir.Models;
using System.Collections.Generic;
using System.Web.Mvc;
using System.IO;

namespace Audir.Controllers
{
    public class QcmController : Controller
    {
        public List<Question> list_qst;
        private object pdf;

      
       
        public QcmController()
        {
            list_qst = new List<Question>
            {
                new Question(1, "est ce qu 'il a","physique"),
                new Question(2, "est ce qu 'il a","physique"),
                new Question(3, "est ce qu 'il a","physique"),
                new Question(4, "est ce qu 'il a","physique"),
                new Question(5, "est ce qu 'il a","physique"),
                new Question(6, "est ce qu 'il a","physique"),
                new Question(7, "est ce qu 'il a","physique"),
                new Question(8, "est ce qu 'il a","Loguique"),
                new Question(9, "est ce qu 'il a","Loguique"),
                new Question(10, "est ce qu 'il a","Loguique"),
                new Question(11, "est ce qu 'il a","Loguique"),
                new Question(12, "est ce qu 'il a","Loguique"),
                new Question(13, "est ce qu 'il a","Loguique")
            };
        }
        public ActionResult Index()
        {
         
            return View(list_qst);
        }
  
    }
}