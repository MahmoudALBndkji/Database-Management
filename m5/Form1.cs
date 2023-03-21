using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace m5
{
    public partial class Form1 : Form
    {
        int id;
        string FileNameEdit;
        string FileName;
        StreamWriter sw;
        OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_db1DataSet.Table1' table. You can move, or remove it, as needed.
            try
            {
                this.table1TableAdapter.Fill(this.my_db1DataSet.Table1);
                table1BindingSource.DataSource = this.my_db1DataSet.Table1;
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            //(char)13 = enter in the keybord ;)
            if (e.KeyChar == (char)13)
            {
                if (string.IsNullOrEmpty(textBox6.Text))
                {
                    this.table1TableAdapter.Fill(this.my_db1DataSet.Table1);
                    table1BindingSource.DataSource = this.my_db1DataSet.Table1;
              
                }
                else
                {
                    var quary = from a in this.my_db1DataSet.Table1
                                where a.fname == textBox6.Text || a.lname == textBox6.Text || a.phone_number == textBox6.Text || a.addreas == textBox6.Text
                                select a;
                    table1BindingSource.DataSource = this.my_db1DataSet.Table1;
                 
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode== Keys.Delete)
            {
                if (MessageBox.Show("are you sure", "delet!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    table1BindingSource.RemoveCurrent();
            }

        }

        private void brw_Click(object sender, EventArgs e)
        {
           
            try
            {
                using (OpenFileDialog c1 = new OpenFileDialog() { Filter = "PNG |*.png", Multiselect = false })
                {
                    if (c1.ShowDialog()==DialogResult.OK)
                    {
                        pictureBox.Image = Image.FromFile(c1.FileName);
                    }
                    ofd = c1;
                }
            }
            catch ( Exception rt)
            {

                MessageBox.Show(rt.Message, "Exp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                table1BindingSource.EndEdit();
                table1TableAdapter.Update(this.my_db1DataSet.Table1);
                panel.Enabled = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                table1BindingSource.ResetBindings(false);
            }
        }

        private void edite_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            textBox1.Focus();
        }

        private void newline_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                textBox1.Focus();
                this.my_db1DataSet.Table1.AddTable1Row(this.my_db1DataSet.Table1.NewTable1Row());
                table1BindingSource.MoveLast();

               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                table1BindingSource.ResetBindings(false);
            }

        }
        public static int Count_Student(string path)
        {
            int count = 0;
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                while (sr.ReadLine() != null)
                {
                    for (int i = 0; i < 9; i++)
                    sr.ReadLine();
                    count++;
                }
                sr.Close();
            }
            else
                MessageBox.Show("The File Not Found");
            return count;
        }
        public static int Count_Line(string path)
        {
            int count = 0;
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                while (sr.ReadLine() != null)
                    count++;
                sr.Close();
            }
            else
                MessageBox.Show("The File Not Found");
            return count;
        }
        public void Wrirting()
        {
            {
                id = Count_Student(FileName);
                StreamWriter sw = new StreamWriter(FileName, true);
                sw.WriteLine("---------------[ Data Employee {" + (id + 1) + "} ]---------------");
                sw.WriteLine((id + 1));
                sw.WriteLine(name.Text + " : " + textBox1.Text);
                sw.WriteLine(last_name.Text + " : " + textBox2.Text);
                sw.WriteLine(phone.Text + " : " + textBox3.Text);
                sw.WriteLine(addres.Text + " : " + textBox4.Text);
                sw.WriteLine(info.Text + " : " + richTextBox1.Text);
                sw.WriteLine("Image Path : " + ofd.FileName);
                sw.WriteLine("-----------------------------------------------------------");
                id++;
                sw.Close();
                table1BindingSource.EndEdit();
                table1TableAdapter.Update(this.my_db1DataSet.Table1);
                MessageBox.Show("Done Save Successfully");
            }
        }
        public void Editing()
        {
            sw = new StreamWriter(FileNameEdit, true);
            int New_ID = Convert.ToInt32(txt_Edit_ID.Text);
            sw.WriteLine("---------------[ Data Employee {" + (New_ID) + "} ]---------------");
            sw.WriteLine(name.Text + " : " + textBox1.Text);
            sw.WriteLine(last_name.Text + " : " + textBox2.Text);
            sw.WriteLine(phone.Text + " : " + textBox3.Text);
            sw.WriteLine(addres.Text + " : " + textBox4.Text);
            sw.WriteLine(info.Text + " : " + richTextBox1.Text);
            sw.WriteLine("Image Path : " + ofd.FileName);
            sw.WriteLine("-----------------------------------------------------------");
            sw.Close();
            table1BindingSource.EndEdit();
            table1TableAdapter.Update(this.my_db1DataSet.Table1);
        }

        private void btn_SaveAs_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select Text File";
            ofd.Filter = "All files(*.*) | *.* | Text files (*.txt) | *.txt";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileName = ofd.FileName;
                MessageBox.Show("Done Select Source Successfully");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_Source())
                    MessageBox.Show("Don't Select Source File");
                else
                    Wrirting();
            }
            catch
            {
                MessageBox.Show("There Problem In Source File");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Check_Source())
                MessageBox.Show("Don't Select Source File");
            else
            {
                int n = Count_Student(FileName);
                MessageBox.Show("The Count Student Is : " + n.ToString());
            }
        }

        private void btn_Count_Line_Click(object sender, EventArgs e)
        {
            if (Check_Source())
                MessageBox.Show("Don't Select Source File");
            else
            {
                int n = Count_Line(FileName);
                MessageBox.Show("The Count Line In File Is : " + n.ToString());
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (File.Exists(FileName))
            {
                DialogResult res = MessageBox.Show("Are you Sure Delete File", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (res == DialogResult.Yes)
                {
                    File.Delete(FileName);
                    MessageBox.Show("Done Delete Successfully");
                    
                }
            }
            else
                MessageBox.Show("The File Not Found");
        }
        public bool Check_Source()
        {
            return ofd == null;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.Title = "Create Text File";
            ofd.Filter = "All files (*.*) |*.*| Text files (*.txt) | *.txt";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                File.CreateText(ofd.FileName);
                MessageBox.Show("Done Create File Successfully");
            }
        }
        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (Check_Source())
                MessageBox.Show("Don't Select Source File");
            else
            {
                StreamReader sr = new StreamReader(FileName);
                int NewId = Convert.ToInt32(txt_Edit_ID.Text);
                int number_id;
                bool Message = true;
                while (sr.ReadLine() != null)
                {
                    number_id = Convert.ToInt32(sr.ReadLine());
                    if (number_id == NewId)
                    {
                        Message = false;
                        Editing();
                        MessageBox.Show("Done Edit For Data Employee {" + (number_id) + "} Successfully");
                        sr.Close();
                        break;
                    }
                    else
                    {
                        for (int i = 0; i < 7; i++)
                            sr.ReadLine();
                    }
                }
                if (Message)
                    MessageBox.Show("Sorry Not Found Id In File");
            }
        }

        private void btn_Select_Edit_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Title = "Select Edit File";
            ofd.Filter = "All files(*.*) | *.* | Text files (*.txt) | *.txt";
            ofd.FilterIndex = 1;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileNameEdit = ofd.FileName;
                MessageBox.Show("Done Select Source Successfully");
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            txt_Edit_ID.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        string u = "";
        
        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
  
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
            textBox2.Cut();
            textBox3.Cut();
            textBox4.Cut();
            txt_Edit_ID.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
            textBox2.Copy();
            textBox3.Copy();
            textBox4.Copy();
            txt_Edit_ID.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
            textBox2.Paste();
            textBox3.Paste();
            textBox4.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
            textBox2.SelectAll();
            textBox3.SelectAll();
            textBox4.SelectAll();
            txt_Edit_ID.SelectAll();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mainToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
