using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;


namespace m5
{
    public partial class app : Form
    {
        string FileName, FileNameEdit;
        StreamWriter sw;
        OpenFileDialog ofd, ofde;
        public app() => InitializeComponent();
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'my_db1DataSet.Table1' Table. You can move, or remove it, as needed.
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
            // ( Char ) 13 =  Enter In The Keyboard
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
            if (e.KeyCode == Keys.Delete)
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
                    if (c1.ShowDialog() == DialogResult.OK)
                        pictureBox.Image = Image.FromFile(c1.FileName);
                    ofd = c1;
                }
            }
            catch (Exception rt)
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
        private void newline_Click(object sender, EventArgs e)
        {
            try
            {
                panel.Enabled = true;
                name.Focus();
                this.my_db1DataSet.Table1.AddTable1Row(this.my_db1DataSet.Table1.NewTable1Row());
                table1BindingSource.MoveLast();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exp", MessageBoxButtons.OK, MessageBoxIcon.Error);
                table1BindingSource.ResetBindings(false);
            }

        }
        public static int Count_Employee(string path)
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
            int id = Count_Employee(FileName);
            StreamWriter sw = new StreamWriter(FileName, true);
            sw.WriteLine("---------------[ Data Employee {" + (id + 1) + "} ]---------------");
            sw.WriteLine((id + 1));
            sw.WriteLine(name.Text + " : " + name.Text);
            sw.WriteLine(last_name.Text + " : " + textBox2.Text);
            sw.WriteLine(phone.Text + " : " + textBox3.Text);
            sw.WriteLine(addres.Text + " : " + textBox4.Text);
            sw.WriteLine(info.Text + " : " + richTextBox1.Text);
            sw.WriteLine("Image Path : " + ofd.FileName);
            sw.WriteLine("-----------------------------------------------------------");
            id++;
            sw.Close();
            table1BindingSource.EndEdit();
            MessageBox.Show("Done Save Successfully");
        }
        public void Editing()
        {
            sw = new StreamWriter(FileNameEdit, true);
            int New_ID = Convert.ToInt32(txt_Edit_ID.Text);
            sw.WriteLine("---------------[ Data Employee {" + (New_ID) + "} ]---------------");
            sw.WriteLine(name.Text + " : " + name.Text);
            sw.WriteLine(last_name.Text + " : " + textBox2.Text);
            sw.WriteLine(phone.Text + " : " + textBox3.Text);
            sw.WriteLine(addres.Text + " : " + textBox4.Text);
            sw.WriteLine(info.Text + " : " + richTextBox1.Text);
            sw.WriteLine("Image Path : " + ofd.FileName);
            sw.WriteLine("Edit Time : " + DateTime.Now);
            sw.WriteLine("-----------------------------------------------------------");
            sw.Close();
            table1BindingSource.EndEdit();
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
                {
                    Wrirting();
                    Empty();
                }
            }
            catch
            {
                MessageBox.Show("There Problem In Source File", "EXP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_Source())
                    MessageBox.Show("Don't Select Source File");
                else
                {
                    int n = Count_Employee(FileName);
                    MessageBox.Show("The Count Employee Is : " + n.ToString());
                }
            }
            catch
            {
                MessageBox.Show("There Problem In Source File", "EXP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_Count_Line_Click(object sender, EventArgs e)
        {
            try
            {
                if (Check_Source())
                    MessageBox.Show("Don't Select Source File");
                else
                {
                    int n = Count_Line(FileName);
                    MessageBox.Show("The Count Line In File Is : " + n.ToString());
                }
            }
            catch
            {
                MessageBox.Show("There Problem In Source File", "EXP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public bool Check_Source() => ofd == null;
        public bool Check_Source_Edit() => ofde == null;
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
            try
            {
                if (Check_Source())
                    MessageBox.Show("Don't Select Source File");
                else if (Check_Source_Edit())
                    MessageBox.Show("Don't Select Source File Edit");
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
            catch
            {
                MessageBox.Show("There Problem In Source File", "EXP", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btn_Select_Edit_Click(object sender, EventArgs e)
        {
            ofde = new OpenFileDialog();
            ofde.Title = "Select Edit File";
            ofde.Filter = "All files(*.*) | *.* | Text files (*.txt) | *.txt";
            ofde.FilterIndex = 1;
            if (ofde.ShowDialog() == DialogResult.OK)
            {
                FileNameEdit = ofde.FileName;
                MessageBox.Show("Done Select Source Successfully");
            }
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            txt_Edit_ID.Clear();
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name.Cut();
            textBox2.Cut();
            textBox3.Cut();
            textBox4.Cut();
            txt_Edit_ID.Cut();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name.Copy();
            textBox2.Copy();
            textBox3.Copy();
            textBox4.Copy();
            txt_Edit_ID.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name.Paste();
            textBox2.Paste();
            textBox3.Paste();
            textBox4.Paste();
        }
        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name.SelectAll();
            textBox2.SelectAll();
            textBox3.SelectAll();
            textBox4.SelectAll();
            txt_Edit_ID.SelectAll();
        }
        private void txt_Edit_ID_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            string str = txt.Text;
            for (int i = 0; i < str.Length; i++)
                if (!(str[i] >= 48 && str[i] <= 57) || str == "")
                {
                    MessageBox.Show("Please Just Enter Number");
                    txt.Text = str.Remove(i);
                    txt.SelectionStart = txt.Text.Length;
                }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dv = dataGridView1.Rows[e.RowIndex];
                name.Text = dv.Cells[1].Value.ToString();
                textBox2.Text = dv.Cells[2].Value.ToString();
                textBox3.Text = dv.Cells[3].Value.ToString();
                textBox4.Text = dv.Cells[4].Value.ToString();
                richTextBox1.Text = dv.Cells[6].Value.ToString();
                name.Focus();
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e) => Empty();
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            name.SelectedText = name.SelectedText.ToUpper();
            textBox2.SelectedText = textBox2.SelectedText.ToUpper();
            textBox4.SelectedText = textBox4.SelectedText.ToUpper();
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToUpper();
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            name.SelectedText = name.SelectedText.ToLower();
            textBox2.SelectedText = textBox2.SelectedText.ToLower();
            textBox4.SelectedText = textBox4.SelectedText.ToLower();
            richTextBox1.SelectedText = richTextBox1.SelectedText.ToLower();
        }
        private void app_FormClosing(object sender, FormClosingEventArgs e) => Application.Exit();
        void Empty()
        {
            name.Text = textBox2.Text = textBox3.Text = textBox4.Text = richTextBox1.Text = string.Empty;
            pictureBox.Image = null;
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            panel.Enabled = true;
            name.Focus();
        }
        private void inforamtionToolStripMenuItem_Click(object sender, EventArgs e) => MessageBox.Show("for detals visit https//:google.com ");
    }
}