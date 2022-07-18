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
            
            // forda header

            PdfPTable name = new PdfPTable(1);
            name.DefaultCell.BorderWidth = 0;
            name.WidthPercentage = 80;
            BaseFont Ver = BaseFont.CreateFont(BaseFont.HELVETICA_BOLD, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font bold = new iTextSharp.text.Font(Ver, 20, iTextSharp.text.Font.BOLD);
            Chunk chunk = new Chunk("Kathlene Ann M. Panuga", bold);
            name.HorizontalAlignment = Element.ALIGN_LEFT;
            name.AddCell(new Phrase(chunk));
            document.Add(name);

            PdfPTable position = new PdfPTable(1);
            position.DefaultCell.BorderWidth = 0;
            position.WidthPercentage = 80;
            BaseFont poss = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font Normal11 = new iTextSharp.text.Font(poss, 11, iTextSharp.text.Font.NORMAL);
            Chunk pos = new Chunk ("Computer Engineer Intern", Normal11);
            position.HorizontalAlignment = Element.ALIGN_LEFT;
            position.AddCell(new Phrase(pos));
            document.Add(position);

            PdfPTable number = new PdfPTable(1);
            number.DefaultCell.BorderWidth = 0;
            number.WidthPercentage = 80;
            Chunk no = new Chunk("09357638995", Normal11);
            number.HorizontalAlignment = Element.ALIGN_LEFT;
            number.AddCell(new Phrase(no));
            document.Add(number);

            PdfPTable email = new PdfPTable(1);
            email.DefaultCell.BorderWidth = 0;
            email.WidthPercentage = 80;
            Chunk eml = new Chunk("kathlinnaaaa@gmail.com", Normal11);
            email.HorizontalAlignment = Element.ALIGN_LEFT;
            email.AddCell(new Phrase(eml));
            document.Add(email);

            // forda profile

            PdfPTable profile = new PdfPTable(1);
            profile.DefaultCell.BorderWidth = 0;
            profile.WidthPercentage = 100;
            BaseFont pro = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font Normal = new iTextSharp.text.Font(pro, 11, iTextSharp.text.Font.NORMAL);
            Chunk dp = new Chunk(" \n\n             A motivated student pursuing a Bachelor of Science in Computer Engineering at the Polytechnic University of the Philippines. Eager to join CTRL X Inc. as Computer Engineer intern to help establish quick and long-lasting relationships with co-workers. Willing to learn knowledge and skills.", Normal);
            profile.HorizontalAlignment = Element.ALIGN_JUSTIFIED_ALL;
            profile.AddCell(new Phrase(dp));
            document.Add(profile);

            // forda highlights

            PdfPTable Highlights = new PdfPTable(1);
            Highlights.DefaultCell.BorderWidth = 0;
            Highlights.WidthPercentage = 80;
            iTextSharp.text.Font bold16 = new iTextSharp.text.Font(Ver, 16, iTextSharp.text.Font.BOLD);
            Chunk HL = new Chunk("\nHIGHLIGHTS", bold16);
            Highlights.HorizontalAlignment = Element.ALIGN_LEFT;
            Highlights.AddCell(new Phrase(HL));
            document.Add(Highlights);


            PdfPTable Py = new PdfPTable(1);
            Py.DefaultCell.BorderWidth = 0;
            Py.WidthPercentage = 80;
            Chunk thon = new Chunk("\n• Python", Normal);
            Py.HorizontalAlignment = Element.ALIGN_LEFT;
            Py.AddCell(new Phrase(thon));
            document.Add(Py);

            PdfPTable Ht = new PdfPTable(1);
            Ht.DefaultCell.BorderWidth = 0;
            Ht.WidthPercentage = 80;
            Chunk ml = new Chunk("• HTML", Normal);
            Ht.HorizontalAlignment = Element.ALIGN_LEFT;
            Ht.AddCell(new Phrase(ml));
            document.Add(Ht);

            PdfPTable sharp = new PdfPTable(1);
            sharp.DefaultCell.BorderWidth = 0;
            sharp.WidthPercentage = 80;
            Chunk c = new Chunk("• C sharp", Normal);
            sharp.HorizontalAlignment = Element.ALIGN_LEFT;
            sharp.AddCell(new Phrase(c));
            document.Add(sharp);

            PdfPTable AutoC = new PdfPTable(1);
            AutoC.DefaultCell.BorderWidth = 0;
            AutoC.WidthPercentage = 80;
            Chunk card = new Chunk("• AutoCAD", Normal);
            AutoC.HorizontalAlignment = Element.ALIGN_LEFT;
            AutoC.AddCell(new Phrase(card));
            document.Add(AutoC);

            // forda education
            // present

            PdfPTable Education = new PdfPTable(1);
            Education.DefaultCell.BorderWidth = 0;
            Education.WidthPercentage = 80;
            Chunk edu = new Chunk("\nEDUCATION", bold16);
            Education.HorizontalAlignment = Element.ALIGN_LEFT;
            Education.AddCell(new Phrase(edu));
            document.Add(Education);

            PdfPTable Yr = new PdfPTable(1);
            Yr.DefaultCell.BorderWidth = 0;
            Yr.WidthPercentage = 80;
            Chunk year = new Chunk("\n2021 - 2022", Normal);
            Yr.HorizontalAlignment = Element.ALIGN_LEFT;
            Yr.AddCell(new Phrase(year));
            document.Add(Yr);

            PdfPTable School = new PdfPTable(1);
            School.DefaultCell.BorderWidth = 0;
            School.WidthPercentage = 80;
            Chunk univ = new Chunk("Polytechnic University of the Philippines", Normal);
            School.HorizontalAlignment = Element.ALIGN_LEFT;
            School.AddCell(new Phrase(univ));
            document.Add(School);

            PdfPTable Degree = new PdfPTable(1);
            Degree.DefaultCell.BorderWidth = 0;
            Degree.WidthPercentage = 80;
            Chunk Forda = new Chunk("Bachelor of Science in Computer Engineering", Normal);
            Degree.HorizontalAlignment = Element.ALIGN_LEFT;
            Degree.AddCell(new Phrase(Forda));
            document.Add(Degree);

            // forda shs

            PdfPTable Year = new PdfPTable(1);
            Year.DefaultCell.BorderWidth = 0;
            Year.WidthPercentage = 80;
            Chunk sy = new Chunk("\n2019 - 2020", Normal);
            Year.HorizontalAlignment = Element.ALIGN_LEFT;
            Year.AddCell(new Phrase(sy));
            document.Add(Year);

            PdfPTable LSAI = new PdfPTable(1);
            LSAI.DefaultCell.BorderWidth = 0;
            LSAI.WidthPercentage = 80;
            Chunk ay = new Chunk("Lakewood School of Alabang Inc.", Normal);
            LSAI.HorizontalAlignment = Element.ALIGN_LEFT;
            LSAI.AddCell(new Phrase(ay));
            document.Add(LSAI);

            PdfPTable Dgree = new PdfPTable(1);
            Dgree.DefaultCell.BorderWidth = 0;
            Dgree.WidthPercentage = 80;
            Chunk ict = new Chunk("Senior High School Graduate", Normal);
            Dgree.HorizontalAlignment = Element.ALIGN_LEFT;
            Dgree.AddCell(new Phrase(ict));
            document.Add(Dgree);

            // forda experiences gr12

            PdfPTable Experience = new PdfPTable(1);
            Experience.DefaultCell.BorderWidth = 0;
            Experience.WidthPercentage = 80;
            Chunk Expe = new Chunk("\nEXPERIENCES", bold16);
            Experience.HorizontalAlignment = Element.ALIGN_LEFT;
            Experience.AddCell(new Phrase(Expe));
            document.Add(Experience);

            PdfPTable ExpYear = new PdfPTable(1);
            ExpYear.DefaultCell.BorderWidth = 0;
            ExpYear.WidthPercentage = 80;
            Chunk xpyr = new Chunk("\n2019 - 2020", Normal);
            ExpYear.HorizontalAlignment = Element.ALIGN_LEFT;
            ExpYear.AddCell(new Phrase(xpyr));
            document.Add(ExpYear);

            PdfPTable JbTitle = new PdfPTable(1);
            JbTitle.DefaultCell.BorderWidth = 0;
            JbTitle.WidthPercentage = 80;
            Chunk jbt = new Chunk("Grade 12 Immersion", Normal);
            JbTitle.HorizontalAlignment = Element.ALIGN_LEFT;
            JbTitle.AddCell(new Phrase(jbt));
            document.Add(JbTitle);

            PdfPTable Company = new PdfPTable(1);
            Company.DefaultCell.BorderWidth = 0;
            Company.WidthPercentage = 80;
            Chunk tp = new Chunk("Teleperformance", Normal);
            Company.HorizontalAlignment = Element.ALIGN_LEFT;
            Company.AddCell(new Phrase(tp));
            document.Add(Company);

            // forda experience gr9

            PdfPTable ExpYear2 = new PdfPTable(1);
            ExpYear2.DefaultCell.BorderWidth = 0;
            ExpYear2.WidthPercentage = 80;
            Chunk xpyr2 = new Chunk("\n2016 - 2017", Normal);
            ExpYear2.HorizontalAlignment = Element.ALIGN_LEFT;
            ExpYear2.AddCell(new Phrase(xpyr2));
            document.Add(ExpYear2);

            PdfPTable JbTitle2 = new PdfPTable(1);
            JbTitle2.DefaultCell.BorderWidth = 0;
            JbTitle2.WidthPercentage = 80;
            Chunk jbt2 = new Chunk("Grade 9 On the job training", Normal);
            JbTitle2.HorizontalAlignment = Element.ALIGN_LEFT;
            JbTitle2.AddCell(new Phrase(jbt2));
            document.Add(JbTitle2);

            PdfPTable Company2 = new PdfPTable(1);
            Company2.DefaultCell.BorderWidth = 0;
            Company2.WidthPercentage = 80;
            Chunk tp2 = new Chunk("Petron", Normal);
            Company2.HorizontalAlignment = Element.ALIGN_LEFT;
            Company2.AddCell(new Phrase(tp2));
            document.Add(Company2);

            // forda additional

            PdfPTable AdditionalInfo = new PdfPTable(1);
            AdditionalInfo.DefaultCell.BorderWidth = 0;
            AdditionalInfo.WidthPercentage = 80;
            Chunk addons = new Chunk("\nADDITIONAL INFORMATION", bold16);
            AdditionalInfo.HorizontalAlignment = Element.ALIGN_LEFT;
            AdditionalInfo.AddCell(new Phrase(addons));
            document.Add(AdditionalInfo);

            PdfPTable Honor = new PdfPTable(1);
            Honor.DefaultCell.BorderWidth = 0;
            Honor.WidthPercentage = 80;
            Chunk hnr = new Chunk("• Honor Student", Normal);
            Honor.HorizontalAlignment = Element.ALIGN_LEFT;
            Honor.AddCell(new Phrase(hnr));
            document.Add(Honor);

            PdfPTable PL = new PdfPTable(1);
            PL.DefaultCell.BorderWidth = 0;
            PL.WidthPercentage = 80;
            Chunk piel = new Chunk("• President's Lister", Normal);
            PL.HorizontalAlignment = Element.ALIGN_LEFT;
            PL.AddCell(new Phrase(piel));
            document.Add(PL);

            PdfPTable award = new PdfPTable(1);
            award.DefaultCell.BorderWidth = 0;
            award.WidthPercentage = 80;
            Chunk eward = new Chunk("• Best in Immersion", Normal);
            award.HorizontalAlignment = Element.ALIGN_LEFT;
            award.AddCell(new Phrase(eward));
            document.Add(award);

            document.Close();
            MessageBox.Show("Your PDF is now saved!");
        }
    }
}