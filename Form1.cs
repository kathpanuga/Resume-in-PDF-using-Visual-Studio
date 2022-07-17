using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using iTextSharp.text;
using Newtonsoft.Json;
using iTextSharp.text.pdf;

namespace Personal_Resume_in_PDF_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenFileBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog.FileName;
                textBox1.Text = filename;
                richTextBox1.Text = File.ReadAllText(filename);
            }
        }

        private void GenPDFBtn_Click(object sender, EventArgs e)
        {
            Document document = new Document();
            PdfWriter.GetInstance(document, new FileStream("PANUGA_KATHLENE ANN.pdf", FileMode.Create));
            document.Open();

            Paragraph paragraph = new Paragraph(richTextBox1.Text);
            document.Add(paragraph);
            document.Close();
            MessageBox.Show("PDF saved!");
        }

        public class Resume
        {
            public string Fullname { get; set; }
            public string Position { get; set; }
            public string Address { get; set; }
            public int PhoneNumber { get; set; }
            public string Email { get; set; }
            public string Profile { get; set; }
        }
        public class Education
        {
            public List<int> Year { get; set; }
            public List<string> School { get; set; }
            public List<string> DegreeTitle { get; set; }
        }
        public class Highlights
        {
            public List<string> Highlight { get; set; }
        }
        public class Experiences
        {
            public List<int> Year { get; set; }
            public List<string> JobTitle { get; set; }
            public List<string> Company { get; set; }
            public List<string> Description { get; set; }
        }
    }
}
