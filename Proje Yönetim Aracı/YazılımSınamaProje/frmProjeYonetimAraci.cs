using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace YazılımSınamaProje
{
    public partial class frmProjeYonetimAraci : Form
    {
        public frmProjeYonetimAraci()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=BERIITAN;Initial Catalog=dbYazilimTest;Integrated Security=True");

        private void frmProjeYonetimAraci_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbYazilimTestDataSet.Work' table. You can move, or remove it, as needed.
            this.workTableAdapter.Fill(this.dbYazilimTestDataSet.Work);
            // TODO: This line of code loads data into the 'dbYazilimTestDataSet.Process' table. You can move, or remove it, as needed.
            this.processTableAdapter.Fill(this.dbYazilimTestDataSet.Process);
            // TODO: This line of code loads data into the 'dbYazilimTestDataSet.Project' table. You can move, or remove it, as needed.
            this.projectTableAdapter.Fill(this.dbYazilimTestDataSet.Project);
            tbProjeYonetimAraci.TabPages.Remove(tbIsDetaylandirma);
            tbProjeYonetimAraci.TabPages.Remove(tbRapor);
            tbProjeYonetimAraci.TabPages.Remove(tbIsSureci);
            tbProjeYonetimAraci.TabPages.Remove(tbYonetici);
            tbProjeYonetimAraci.TabPages.Remove(tbMusteriIslemleri);
            this.reportViewer1.RefreshReport();
        }
        private void btnYoneticiGiris_Click(object sender, EventArgs e)
        {
            bool giris = false;
            con.Open();
            string sql = "select * from Users where UserName = '" + txtYoneticiAd.Text +
                         "' and Password = '" + txtYoneticiSifre.Text + "'" ;

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                giris = true;

            }
            dr.Close();
            con.Close();
            if(giris == true)
            {
                
                tbProjeYonetimAraci.TabPages.Remove(tbGiris);
                tbProjeYonetimAraci.TabPages.Add(tbYonetici);
                tbProjeYonetimAraci.TabPages.Add(tbIsSureci);
                tbProjeYonetimAraci.TabPages.Add(tbIsDetaylandirma);
                tbProjeYonetimAraci.TabPages.Add(tbRapor);
                tbProjeYonetimAraci.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnMusteriGiris_Click(object sender, EventArgs e)
        {
          
            bool giris = false;
            con.Open();
            string sql = "select * from Users where UserName = '" + txtMusteriKulAd.Text +
                         "' and Password = '" + txtMusteriSifre.Text + "'";

            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                giris = true;

            }
            dr.Close();
            con.Close();
            if (giris == true)
            {
                tbProjeYonetimAraci.TabPages.Remove(tbIsDetaylandirma);
                tbProjeYonetimAraci.TabPages.Remove(tbGiris);
                tbProjeYonetimAraci.TabPages.Remove(tbYonetici);
                tbProjeYonetimAraci.TabPages.Remove(tbIsSureci);
                tbProjeYonetimAraci.TabPages.Remove(tbRapor);
                tbProjeYonetimAraci.TabPages.Add(tbMusteriIslemleri);
                tbProjeYonetimAraci.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void projectBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void projectDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {

        }

        private void btnIsSureciEkle_Click(object sender, EventArgs e)
        {
            tbProjeYonetimAraci.SelectedIndex = 1;
        }

        private void tbIsSureci_Click(object sender, EventArgs e)
        {
           
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            tbProjeYonetimAraci.SelectedIndex = 3;
        }

        private void workBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into Work(WorkStartDate,WorkFinishDate,WorkNameID,UserID,ComplateRate,Analiz,Tablo,Arayüz,Test) values (@WorkStartDate,@WorkFinishDate,@WorkNameID,@UserID,@ComplateRate,@Analiz,@Tablo,@Arayüz,@Test)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@WorkStartDate", workStartDateDateTimePicker.Value.TimeOfDay);
                komut.Parameters.AddWithValue("@WorkFinishDate", workFinishDateDateTimePicker.Value.TimeOfDay);
                komut.Parameters.AddWithValue("@WorkNameID", workNameIDTextBox.Text);
                komut.Parameters.AddWithValue("@UserID", userIDTextBox.Text);
                komut.Parameters.AddWithValue("@ComplateRate", complateRateTextBox1.Text);
                komut.Parameters.AddWithValue("@Analiz", analizTextBox.Text);
                komut.Parameters.AddWithValue("@Tablo", tabloTextBox.Text);
                komut.Parameters.AddWithValue("@Arayüz", arayüzTextBox.Text);
                komut.Parameters.AddWithValue("@Test", testTextBox.Text);
                komut.ExecuteNonQuery();
                MessageBox.Show(" Kayıt İşlemi Gerçekleşti.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + ex.Message);
            }

        }

        private void projectBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into Project(ProjectName,StartDate,FinishDate,IsActive,Budget) values (@ProjectName,@StartDate,@FinishDate,@IsActive,@Budget)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@ProjectName", projectNameTextBox.Text);
                komut.Parameters.AddWithValue("@StartDate", startDateDateTimePicker.Value.TimeOfDay);
                komut.Parameters.AddWithValue("@FinishDate", finishDateDateTimePicker.Value.TimeOfDay);
                komut.Parameters.AddWithValue("@IsActive", isActiveCheckBox.Checked);
                komut.Parameters.AddWithValue("@Budget", budgetTextBox.Text);
               
                komut.ExecuteNonQuery();
                MessageBox.Show(" Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + ex.Message);
            }
        }

        private void processBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string kayit = "insert into Process(ProcessName,StartDate,FinishDate,Duration,ComplateRate,Priority,Notes) values (@ProcessName,@StartDate,@FinishDate,@Duration,@ComplateRate,@Priority,@Notes)";
                SqlCommand komut = new SqlCommand(kayit, con);
                komut.Parameters.AddWithValue("@ProcessName", processNameTextBox.Text);
                komut.Parameters.AddWithValue("@StartDate", startDateDateTimePicker1.Value.TimeOfDay);
                komut.Parameters.AddWithValue("@FinishDate", finishDateDateTimePicker1.Value.TimeOfDay);
                komut.Parameters.AddWithValue("@Duration", durationTextBox.Text);
                komut.Parameters.AddWithValue("@ComplateRate", complateRateTextBox.Text);
                komut.Parameters.AddWithValue("@Priority", priorityTextBox.Text);
                komut.Parameters.AddWithValue("@Notes", notesTextBox.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show(" Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + ex.Message);
            }
        }

        private void projectNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
             //projectNameTextBox.Text = "";
        }

        private void budgetTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void processNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void durationTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void complateRateTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void priorityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void notesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void workNameIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void userIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void complateRateTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void analizTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void tabloTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void arayüzTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }

        private void testTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
               && !char.IsSeparator(e.KeyChar);
        }









       
       
    }

    public class ytesti
    {
        SqlConnection con = new SqlConnection("Data Source=BERIITAN;Initial Catalog=dbYazilimTest;Integrated Security=True");
        public int kullanıcıgirişikontrol(string ad,string sifre)
        {
            int şifre=0;
            string sql = "select UserName,Password from Users";
            con.Open();    
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader useroku = cmd.ExecuteReader();
            while(useroku .Read())
            {
                if(useroku["UserName"].ToString()==ad&&useroku["Password"].ToString()==sifre)
                {
                    şifre = Convert.ToInt32(useroku["Password"]);
                }
            }
            return şifre;
        }
    }

    public class yazilimtesti
    {
        SqlConnection con = new SqlConnection("Data Source=BERIITAN;Initial Catalog=dbYazilimTest;Integrated Security=True");
        public int musterigirisikontrol(string add,string sifree)
        {
            int sifre = 0;
            string sql = "select UserName,Password from Users";
            con.Open();
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            SqlDataReader userokuu = cmd.ExecuteReader();
            while(userokuu.Read())
            {
                if(userokuu["UserName"].ToString() == add && userokuu["Password"].ToString()==sifree)
                {
                    sifre = Convert.ToInt32(userokuu["Password"]);
                }
            }
            return sifre;
        }
    }
}
