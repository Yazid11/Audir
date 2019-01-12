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
        public List<traitement> traitements;
        public List<Resultat_type> result_type;
        public QcmController()
        {
            traitements = new List<traitement>();
            result_type=new List<Resultat_type> ();
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
            traitements.Add(new traitement(0, 0, 0, "Loguique"));
            traitements.Add(new traitement(0, 0, 0, "physique"));

            result_type.Add(new Resultat_type(0, 0,0, 0, "Loquique"));
            result_type.Add(new Resultat_type(0, 0, 0, 0, "physique"));
            foreach (var x in list_qst)
            {
                if(Request.Form[x.Id.ToString()]=="Oui/"+ x.Id.ToString())
                {
                    if (x.Type == "Loguique") {
                        traitements.ToArray()[0].Nbqsttraité++;
                        traitements.ToArray()[0].Nb_qst++;

                        result_type.ToArray()[0].Oui++;
                        
                    }
                    else if (x.Type == "physique")
                    {
                        traitements.ToArray()[1].Nbqsttraité++;
                        traitements.ToArray()[1].Nb_qst++;

                        result_type.ToArray()[1].Oui++;
                    }
                    else
                    {
                    }
                }
                else if(Request.Form[x.Id.ToString()] == "Non/" + x.Id.ToString())
                {
                    if (x.Type == "Loguique")
                    {
                        traitements.ToArray()[0].Nbqsttraité++;
                        traitements.ToArray()[0].Nb_qst++;

                        result_type.ToArray()[0].Non++;

                    }
                    else if (x.Type == "physique")
                    {
                        traitements.ToArray()[1].Nbqsttraité++;
                        traitements.ToArray()[1].Nb_qst++;

                        result_type.ToArray()[1].Non++;
                    }
                    else
                    {
                    }
                }
                else
                {
                    if (x.Type == "Loguique")
                    {
                        traitements.ToArray()[0].Nbqstnontrairé++;
                        traitements.ToArray()[0].Nb_qst++;

                        result_type.ToArray()[0].Non_traité++;

                    }
                    else if (x.Type == "physique")
                    {
                        traitements.ToArray()[1].Nbqstnontrairé++;
                        traitements.ToArray()[1].Nb_qst++;

                        result_type.ToArray()[1].Non_traité++;
                    }
                    else
                    {
                    }
                }
            }
            if (Request.Form["valider"] == "Résultats") {
                ReportDocument rd = new ReportDocument();
                rd.Load(Path.Combine(Server.MapPath("~/"), "CrystalReport1.rpt"));

                rd.SetDataSource(traitements);

                Response.Buffer = false;
                Response.ClearContent();
                Response.ClearHeaders();
                Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf", "QuestionList.pdf");
            }
            else if (Request.Form["valider"] == "Résumé")
            {
                ReportDocument rd = new ReportDocument();
                rd.Load(Path.Combine(Server.MapPath("~/"), "CrystalReport2.rpt"));

                rd.SetDataSource(result_type);

                Response.Buffer = false;
                Response.ClearContent();
                Response.ClearHeaders();
                Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf", "QuestionList.pdf");
            }
            else
            {
                ReportDocument rd = new ReportDocument();
                rd.Load(Path.Combine(Server.MapPath("~/"), "CrystalReport3.rpt"));

                rd.SetDataSource(result_type);

                Response.Buffer = false;
                Response.ClearContent();
                Response.ClearHeaders();
                Stream stream = rd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                return File(stream, "application/pdf", "QuestionList.pdf");
            }
           
        }
  
    }
}