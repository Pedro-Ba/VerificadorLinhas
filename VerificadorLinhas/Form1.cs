using System.Windows.Forms;

namespace VerificadorLinhas
{
    public partial class Form1 : Form
    {
        StreamReader firstFile, secondFile;
        int lineCountFirstFile, lineCountSecondFile;
        public Form1()
        {
            InitializeComponent();
        }

        private void lookForDelimiter(StreamReader file)
        {
            while (file.Peek() != '\0')
            {
                char c = (char)file.Read();
                if (c == '>')
                {
                    file.ReadLine();//consume the remainder of this line
                    return;
                }
            }
        }

        private int readPage(StreamReader file)
        {
            int lineCounter = 0;
            while (file.Peek() != '<' && !file.EndOfStream)
            {
                char c = (char)file.Read();
                if (c == '<')
                {
                    return lineCounter;
                }
                file.ReadLine();
                lineCounter++;
            }
            return lineCounter;
        }

        private void checkPageDifferences()
        {
            int pageCounter = 0;
            while (!firstFile.EndOfStream)
            {
                pageCounter++;
                lookForDelimiter(firstFile);
                lookForDelimiter(secondFile);
                int lineCountFirstPage = readPage(firstFile);
                int lineCountSecondPage = readPage(secondFile);

                if(lineCountFirstPage != lineCountSecondPage)
                {
                    listBox1.Items.Add("Mismatch in page " + pageCounter.ToString() + "; " + (lineCountFirstPage - lineCountSecondPage).ToString() + " extra lines");
                }
            }
            if(listBox1.Items.Count == 0)
            {
                listBox1.Items.Add("No mismatch found.");
            }
        }
        private void btnFirstFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Selecione o arquivo";
                dlg.Filter = "Text Files|*.txt";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    labelFirstFile.Text = dlg.FileName;
                    firstFile = new StreamReader(dlg.OpenFile(), true);
                    lineCountFirstFile = File.ReadLines(dlg.FileName).Count();
                    lblLinesFirstFile.Text = "Total lines: " + lineCountFirstFile.ToString();
                    //MessageBox.Show(lineCountFirstFile.ToString());
                }
            }
        }

        private void btnSecondFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Selecione o arquivo";
                dlg.Filter = "Text Files|*.txt";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    labelSecondFile.Text = dlg.FileName;
                    secondFile = new StreamReader(dlg.OpenFile(), true);
                    lineCountSecondFile = File.ReadLines(dlg.FileName).Count();
                    lblLinesSecondFile.Text = "Total lines: " + lineCountSecondFile.ToString();
                    //MessageBox.Show(lineCountSecondFile.ToString());
                }
            }
        }

        private void btnCheckLines_Click(object sender, EventArgs e)
        {
            checkPageDifferences();
        }
    }
}
