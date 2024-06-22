using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xceed.Words.NET;

namespace WordDocumentAnalysis
{
    public static class DocumentAnalysis
    {
        public static DocX Add(string filePath)
        { 
            DocX docx = DocX.Load(filePath);
            return docx;
        }

        public static string AnalysisFont(DocX docx)
        {
            bool flag = false;
            string a = null;
            var paraList = docx.Paragraphs;
            foreach (var text in paraList)
            {
            
                foreach (var magicText in text.MagicText)
                {
                    if (magicText.formatting == null)
                    {
                        continue;
                    }
                    else if (magicText.formatting.Size != 12 && magicText.formatting.Size != 14)
                    {
                        a = "В фрагменте текста: <" + text.Text.ToString().Substring(0,10) + "> Недопустимый размер шрифта";
                        flag = true;
                        break;
                        //Console.WriteLine("Обнаружен недопустимый размер шрифта: " + magicText.formatting.Size + " " + magicText.text);
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag == true)
            {
                return a;
            }
            else return a;
            
        }
        public static string AnalysisFontFamily(DocX docx)
        {
            bool flag = false;
            string a = null;
            var paraList = docx.Paragraphs;
            foreach (var text in paraList)
            {
                foreach (var magicText in text.MagicText)
                {  
                    if (magicText.formatting == null)
                    {
                        continue;
                    }
                    else if ((magicText.formatting.FontFamily.ToString() != "Times New Roman") && (magicText.formatting.FontFamily.ToString() != "Times New Roman Полужирный"))
                    {
                        a = "В фрагменте текста: <" + text.Text.ToString().Substring(0, 10) + "> Недопустимый шрифт: " + magicText.formatting.FontFamily.ToString();
                        flag = true;
                        break;
                        //Console.WriteLine(magicText.formatting.FontFamily.ToString());
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag == true)
            {
                return a;
            }
            else return a;
        }
        public static string AnalysisIndentation(DocX docx)
        {
            bool flag = false;
            string a = null;
            if ((docx.MarginLeft != 85) || (docx.MarginTop != 56) || (docx.MarginFooter != 35) || (docx.MarginRight != 42))
            {
                a = "Обнаружен недопустимый отступ!";
                flag = true;
                //Console.WriteLine("ERROR " + (int)docx.MarginLeft + " " + docx.MarginRight.ToString() + " " + docx.MarginTop.ToString() + " " + docx.MarginFooter.ToString());
            }
            
            if (flag == true)
            {
                return a;
            }
            else return a;
        }
        public static string AnalysisInterval(DocX docx)
        {
            bool flag = false;
            string a = null;
            foreach (var paraL in docx.Paragraphs)
            {
                if (paraL.LineSpacing != 12 && paraL.LineSpacing > 21 && paraL.LineSpacing < 18 && paraL.LineSpacing != 12.95)
                {
                    a = "Обнаружен недопустимый межстрочный интервал: " + int.Parse(paraL.LineSpacing.ToString())+ ". В слове: "+ paraL.Text.ToString();
                    flag = true;
                    //Console.WriteLine(paraL.Text.ToString() + "   " + paraL.LineSpacing.ToString());
                }
                if(flag == true)
                {
                    break;
                }
            }
            if (flag == true)
            {
                return a;
            }
            else return a;
        }
        public static void AnalysisStyle(DocX docx)
        {

        }
    }
}
