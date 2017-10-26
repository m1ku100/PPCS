using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BackEnd;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;

namespace FrontEnd
{
    public partial class Report_form : Form
    {
        Db db = new Db();

        MySqlConnection conn = new MySqlConnection("Server = localhost; Database=salwa_ppcs;Uid=root;Pwd=;");
        MySqlCommand cmd;
        MySqlDataReader mdr;

        public Report_form(string project_name,string project_code,decimal cash_in,decimal cash_out,decimal cash_in_out,string profit,string type)
        {
            InitializeComponent();

            conn.Open();
            string query = "SELECT client_name FROM client WHERE project_code='" + project_code + "'";
            cmd = new MySqlCommand(query, conn);
            mdr = cmd.ExecuteReader();
            if (mdr.Read())
            {
                string name = mdr.GetString("client_name");
                label1.Text = name;
            }

            label2.Text = project_name;
            txt_cash_inUSD.Text = cash_in.ToString();
            txt_Cash_in.Text = (cash_in * 13300).ToString();
            txt_Cash_out.Text = cash_out.ToString();
            txt_cash_inout.Text = cash_in_out.ToString();
            txt_profit.Text = profit.ToString();
            user_type.Text = type;
            conn.Close();
        }
        


        private void button1_Click(object sender, EventArgs e)
        {
            string id_client = db.single("SELECT id_client FROM client WHERE project_code ='" + label2.Text + "' ");
            string contractdate = db.single("SELECT contract_date FROM client WHERE id_client=" + id_client + "");
            string contractdeadline = db.single("SELECT contract_deadline FROM client WHERE id_client=" + id_client + "");
            string clientname = db.single("SELECT client_name FROM client WHERE id_client=" + id_client + "");
            string clientcode = db.single("SELECT client_code FROM client WHERE id_client=" + id_client + "");
            string projectname = db.single("SELECT project_name FROM client WHERE id_client=" + id_client + "");
            string projectcode = db.single("SELECT project_code FROM client WHERE id_client=" + id_client + "");
            string address = db.single("SELECT client_address FROM client WHERE id_client=" + id_client + "");

            string pathPDF = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            Document docs = new Document();
            docs.SetPageSize(iTextSharp.text.PageSize.A4);

            PdfWriter.GetInstance(docs, new FileStream(pathPDF+"/PPCS REPORT - "+clientname+" - "+projectcode+".pdf", FileMode.Create));

            DataTable dt = db.query("SELECT * FROM requierement WHERE id_client_fk="+ id_client + " ORDER BY type_cost DESC");


            docs.Open();
          
            //Report Header
            BaseFont headbase = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252,BaseFont.NOT_EMBEDDED);
            Font namecompany = new Font(headbase, 15,2);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new Chunk("REPORT", namecompany));
            docs.Add(prgHeading);

            //auothor
            BaseFont aut = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font auth = new Font(aut, 12, 1);
            Paragraph author = new Paragraph();
            author.Add(new Chunk("Author : "+user_type.Text, auth));
            docs.Add(author);

            //company profile
            BaseFont company = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font comp = new Font(company, 12, 1);
            Paragraph client = new Paragraph();
            client.Add(new Chunk(clientname+"("+clientcode+")\n",comp));
            docs.Add(client);

            Paragraph project = new Paragraph();
            project.Add(new Chunk(projectname + "(" + projectcode + ")", comp));
            docs.Add(project);

            Paragraph addressu = new Paragraph();
            addressu.Add(new Chunk(address, comp));
            docs.Add(addressu);

            Paragraph datecont = new Paragraph();
            datecont.Add(new Chunk("Contract Date : "+contractdate+"\n"+"Contract Deadline : "+contractdeadline, comp));
            docs.Add(datecont);

            Paragraph p = new Paragraph(new Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.BaseColor.BLACK, Element.ALIGN_LEFT, 1)));
            docs.Add(p);

            docs.Add(new Chunk("\n"));


            //table Content
            PdfPTable contents = new PdfPTable(dt.Columns.Count);
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            Font fntColumnHeader = new Font(btnColumnHeader, 10, 1, BaseColor.WHITE);
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = BaseColor.GRAY;
                cell.AddElement(new Chunk(dt.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                contents.AddCell(cell);
            }

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    contents.AddCell(dt.Rows[i][j].ToString());
                }
            }

            docs.Add(contents);

            Paragraph profitetc = new Paragraph();
            profitetc.Add(new Chunk("Cash-In : $ " + txt_cash_inUSD.Text + " ( Rp" + txt_Cash_in.Text +" )"+"\n"+"Cash-Out : Rp"+txt_Cash_out.Text+"\n"+"Cash In-Out : Rp"+txt_cash_inout.Text+"\n"+"Profit (%): "+txt_profit.Text, comp));
            docs.Add(profitetc);




            docs.Close();
            MessageBox.Show("PDF succesfully created in: "+pathPDF, "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
