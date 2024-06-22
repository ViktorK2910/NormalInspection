using System;
using System.Windows.Forms;
using Xceed.Words.NET;


namespace Sowt
{
    public partial class MainController : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;

        
        protected override void WndProc(ref Message message)
        {
            base.WndProc(ref message);

            if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
                message.Result = (IntPtr)HTCAPTION;
        }
        DocX doc;
        public MainController()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Function_But1();
            //button1.Hide();
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //button2.Hide();
            Function_But2();
            
        }
        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox.ResetText();
            if (doc != null)
            {
                Function_But2();
                Function_But6();
                Function_But1();
                Function_But7();
            }
            else richTextBox.AppendText("Нечего проверять! Попробуйте загрузить другой файл." + Environment.NewLine + Environment.NewLine);
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox.ResetText();
            button4();
        } 
        private void button5_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            Function_But6();  
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Function_But7();
        }

        private DocX button4()
        {

            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                var filePath = openFile.FileName;
                DocX docx = WordDocumentAnalysis.DocumentAnalysis.Add(filePath);


                doc = docx;
                return docx;

            }
            else richTextBox.AppendText("ERROR" + Environment.NewLine + Environment.NewLine);
            DocX docX = null;
            return docX;
        }
        private void Function_But1()
        {
            if (doc != null)
            {
                string a = null;
                a = WordDocumentAnalysis.DocumentAnalysis.AnalysisIndentation(doc);
                if (a != null)
                {
                    richTextBox.AppendText(a + Environment.NewLine + Environment.NewLine);
                }
                else richTextBox.AppendText("Ошибок отступов нет!" + Environment.NewLine + Environment.NewLine); ;
            }
            else richTextBox.AppendText("Нечего проверять! Попробуйте загрузить другой файл." + Environment.NewLine + Environment.NewLine);
        }
        private void Function_But7()
        {
            if (doc != null)
            {
                string a = null;
                a = WordDocumentAnalysis.DocumentAnalysis.AnalysisInterval(doc);
                if (a != null)
                {
                    richTextBox.AppendText(a + Environment.NewLine + Environment.NewLine);
                }
                else richTextBox.AppendText("Нарушений межстрочного интервала нет." + Environment.NewLine + Environment.NewLine); ;
            }
            else richTextBox.AppendText("Нечего проверять! Попробуйте загрузить другой файл." + Environment.NewLine + Environment.NewLine);
        }
        private void Function_But2()
        {
            if (doc != null)
            {
                string a = null;
                a = WordDocumentAnalysis.DocumentAnalysis.AnalysisFont(doc);
                if (a != null)
                {
                    richTextBox.AppendText(a + Environment.NewLine + Environment.NewLine);
                }
                else richTextBox.AppendText("Ошибок шрифта нет!" + Environment.NewLine + Environment.NewLine);
            }
            else richTextBox.AppendText("Нечего проверять! Попробуйте загрузить другой файл." + Environment.NewLine + Environment.NewLine);
        }
        private void Function_But6()
        {
            if (doc != null)
            {
                string a = null;
                a = WordDocumentAnalysis.DocumentAnalysis.AnalysisFontFamily(doc);
                if (a != null)
                {
                    richTextBox.AppendText(a + Environment.NewLine + Environment.NewLine);
                }
                else richTextBox.AppendText("Недопустимого типа шрифта нет." + Environment.NewLine + Environment.NewLine);
            }
            else richTextBox.AppendText("Нечего проверять! Попробуйте загрузить другой файл." + Environment.NewLine + Environment.NewLine);
        }
    }
}
