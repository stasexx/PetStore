using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetStore.Reports
{
    public class Docker
    {
        public static void DockerForSelling(int idFeed, int idClient, bool cheker)
        {
            DataTable dtwitRep = new DataTable();
            if (cheker)
            {
                dtwitRep = SQLCommandsForReport.SearchingForAnimal(idFeed, idClient);
            }
            if (!cheker)
            {
                dtwitRep = SQLCommandsForReport.SearchingForFeed(idFeed, idClient);
            }

            var helper = new WordHelper("D:\\Projects\\PetStore\\PetStore\\Reports\\repForSelling.docx");
            var items = new Dictionary<string, string>
            {
                {"<ORG>", "PetStore" },
                {"<DATA>", DateTime.Now.ToString("yyyy.MM.dd")},
                {"<CLIENT_EMAIL>", dtwitRep.Rows[0].ItemArray[0].ToString()},
                {"<NUMBER>", dtwitRep.Rows[0].ItemArray[1].ToString()},
                {"<FULL_NAME>", dtwitRep.Rows[0].ItemArray[2].ToString()},
                {"<SELLING_DATE>", dtwitRep.Rows[0].ItemArray[3].ToString()},
                {"<FEED_NAME>", dtwitRep.Rows[0].ItemArray[4].ToString()},
                {"<COST>", dtwitRep.Rows[0].ItemArray[5].ToString()},
                { "<TOTAL_PRICE>", ((Convert.ToDouble(dtwitRep.Rows[0].ItemArray[5]) - ((Convert.ToDouble(dtwitRep.Rows[0].ItemArray[5])* (Convert.ToDouble(dtwitRep.Rows[0].ItemArray[6])/100))))).ToString()},
                { "<DISCOUNT>", dtwitRep.Rows[0].ItemArray[6].ToString()},
            };
            MessageBox.Show("Документ успішно сформовано!");
            helper.CreatingDoc(items);
        }


        public static void DockerForSellingTable(DataTable dtwitRep)
        {
            var helper = new WordHelper("D:\\Projects\\PetStore\\PetStore\\Reports\\repForSelling.docx");
            var items = new Dictionary<string, string>
            {
                {"<ORG>", "PetStore" },
                {"<DATA>", DateTime.Now.ToString("yyyy.MM.dd")},
                {"<CLIENT_EMAIL>", dtwitRep.Rows[0].ItemArray[0].ToString()},
                {"<NUMBER>", dtwitRep.Rows[0].ItemArray[1].ToString()},
                {"<FULL_NAME>", dtwitRep.Rows[0].ItemArray[2].ToString()},
                {"<SELLING_DATE>", dtwitRep.Rows[0].ItemArray[3].ToString()},
                {"<FEED_NAME>", dtwitRep.Rows[0].ItemArray[4].ToString()},
                {"<COST>", dtwitRep.Rows[0].ItemArray[5].ToString()},
                { "<TOTAL_PRICE>", ((Convert.ToDouble(dtwitRep.Rows[0].ItemArray[5]) - ((Convert.ToDouble(dtwitRep.Rows[0].ItemArray[5])* (Convert.ToDouble(dtwitRep.Rows[0].ItemArray[6])/100))))).ToString()},
                { "<DISCOUNT>", dtwitRep.Rows[0].ItemArray[6].ToString()},
            };
            MessageBox.Show("Документ успішно сформовано!");
            helper.CreatingDoc(items);
        }

        public static void SelectorForSeasons(double aut, double winter, double spring, double summer)
        {
            List<double> doubles = new List<double>() {aut, winter, spring, summer };
            double max = doubles.Max();
            double sum = doubles.Sum();
            var helper = new WordHelper("D:\\Projects\\PetStore\\PetStore\\Reports\\repForSeasons.docx");
            var items = new Dictionary<string, string>
            {
                {"<ORG>", "PetStore" },
                {"<DATA>", DateTime.Now.ToString("yyyy.MM.dd")},
                {"<AUT>", aut.ToString()},
                {"<WINTER>", winter.ToString()},
                {"<SPRING>", spring.ToString()},
                {"<SUMMER>", summer.ToString()},
                {"<MAX>", max.ToString()},
                {"<SUM>", sum.ToString()},
            };
            MessageBox.Show("Документ успішно сформовано!");
            helper.CreatingDoc(items);
        }
    }


  


    public class WordHelper
    {
        private FileInfo _fileInfo;
        public WordHelper(string fileName)
        {
            if (File.Exists(fileName))
            {
                _fileInfo = new FileInfo(fileName);
            }
            else
            {
                throw new ArgumentException("File not found");
            }
        }

        internal bool CreatingDoc(Dictionary<string, string> items)
        {
            Microsoft.Office.Interop.Word.Application app = null;
            try
            {
                app = new Microsoft.Office.Interop.Word.Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;

                app.Documents.Open(file);
                foreach (var item in items)
                {
                    Microsoft.Office.Interop.Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Microsoft.Office.Interop.Word.WdFindWrap.wdFindContinue;
                    Object replace = Microsoft.Office.Interop.Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing, Replace: replace);


                }
                string path = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss ") + _fileInfo.Name);
                Object newFileName = Path.Combine(_fileInfo.DirectoryName, DateTime.Now.ToString("yyyy_MM_dd HH_mm_ss ") + _fileInfo.Name);
                app.ActiveDocument.SaveAs2(newFileName);
                app.Visible = true;

                return true;
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally
            {
                if (app != null)
                {
                }
            }
            return false;
        }
    }
}
