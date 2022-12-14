using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
namespace ZH_CM8IHC
{
    public partial class Form1 : Form
    {
        //nem tudtam csatlakozni az sql szerveremre mert nincs azurom
        Models.Diak context = new Diak();
        Excel.Application xlApp;
        Excel.Workbook xlWB;
        Excel.Worksheet xlSheet;
        public Form1()
        {
            InitializeComponent();
            studentbindingsource.DataSource = context.Student.Tolist();
            try
            {
                xlApp = new Excel.Application();
                xlWB = new Excel.Workbook();
                xlSheet = new Excel.Worksheet();
                xlApp.Worksheets.Add(xlSheet);
                CreateTable();
                xlApp.Visible = true;
                xlApp.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Diakhozzaad newStudentForm = new Diakhozzaad();
            if (newStudentForm.ShowDialog() == DialogResult.OK)
            {
                Models.Student diakok = new Models.Student();
                diakok.Id = int.Parse(newStudentForm.textBoxid.Text);
                diakok.Nev = newStudentForm.textBoxnev.Text;
                diakok.Jeles = int.Parse(newStudentForm.textBox1.Text);
                diakok.Jo = int.Parse(newStudentForm.textBox2.Text);
                diakok.Kozepes = int.Parse(newStudentForm.textBox3.Text);
                diakok.Elegseges = int.Parse(newStudentForm.textBox4.Text);
                diakok.Elegtelen = int.Parse(newStudentForm.textBox5.Text);
                diakok.Szuletesev = newStudentForm.dateTimePicker1.Value;

                context.Student.Add(diakok);
                try
                {
                    context.SaveChanges();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                studentBindingSource.DataSource = context.Student.ToList();
            }
        }

        private void buttondel_Click(object sender, EventArgs e)
        {
            var selecteditem = studentBindingSource.Current;
            studentBindingSource.Remove(selecteditem);
        }
        void CreateTable()
        {
            Models.Diak exel = new Models.Diak();
            var adat = exel.Students.ToList();
            Fejlec[]=
            {
                "ID",
                "Nev",
                "Jeles",
                "Jo",
                "Kozepes",
                "Elegseges",
                "Elegtelen",
                "Szuletesev"
            };
            object[,] tömb = (adat.Count(), Fejlec.Count());
            for (int i = 0; i < Fejlec.Lenght; i++)
            {
                xlSheet.Cells[1, i + 1] = Fejlec[i];
            }
            //itt valami math.min mûveletet kellett használni de nem jut eszembe, mert engedtem hogy legyenek null értékek és sztem azt nem szereti
            for(int i = 0; i <= adat.Length; i++)
            {
                adat[i, 0] = tömb[i].Id;
                adat[i, 1] = tömb[i].Nev;
                adat[i, 2] = tömb[i].Jeles;
                adat[i, 3] = tömb[i].Jo;
                adat[i, 4] = tömb[i].Kozepes;
                adat[i, 5] = tömb[i].Elegseges;
                adat[i, 6] = tömb[i].Elegtelen;
                adat[i, 7] = tömb[i].Szuletesev;
            }

            int sor = tömb.Count();
            int oszlop = Fejlec.Count();
            Excel.Range data_range = xlSheet.get_Range("A2", Type.Missing).get_Resize(sor, oszlop);
            data_range.Value2 = adat;
        }

        private void textBoxszur_TextChanged(object sender, EventArgs e)
        {
            NewMethod();
        }

        private void NewMethod()
        {
            var szures = from x in context.Student
                         where x.Nev.Contains(textBoxszuro.Text)
                         select x;
            listBoxdiak.DataSource = Students.ToList();
            listBoxdiak.DisplayMember = "Nev";
        }
    }
}
