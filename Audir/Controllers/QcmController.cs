using Audir.Models;
using CrystalDecisions.CrystalReports.Engine;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Web.Mvc;
namespace Audir.Controllers
{
    public class QcmController : Controller
    {
        public List<Question> list_qst;       
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
        public ActionResult pdf()
        {

            foreach (var x in list_qst)
            {
                

            }
            ReportDocument rd = new ReportDocument();
            rd.Load(Path.Combine(Server.MapPath("~/"), "CrystalReport1.rpt"));

            rd.SetDataSource(list_qst);

            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);
            return File(stream, "application/pdf", "QuestionList.pdf");
        }
  
    }
}