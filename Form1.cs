using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ExamSystem
{
    public partial class Form1 : Form
    {
        private Control[] fields;

        public Form1()
        {
            InitializeComponent();
            fields = new Control[] { txtName, txtNumber, txtSdf1, txtSdf2, txtFf, txtSeminar, txtFinal };
            foreach (Control c in fields)
            {
                c.TextChanged += Field_TextChanged;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string path = Path.Combine(AppContext.BaseDirectory, "Images", "BMU.png");
            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    pictureBox1.Image = new Bitmap(fs);
                }
            }
            else
            {
                MessageBox.Show("Şəkil tapılmadı: " + path, "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            notifyIcon1.Visible = false;
        }

        private void Field_TextChanged(object sender, EventArgs e)
        {
            errorProvider1.SetError((Control)sender, "");
        }

        private string GetCategory(int total, int final)
        {
            if (final < 17)
            {
                return "F";
            }
            if (total >= 91)
            {
                return "A";
            }
            if (total >= 81)
            {
                return "B";
            }
            if (total >= 71)
            {
                return "C";
            }
            if (total >= 61)
            {
                return "D";
            }
            if (total >= 51)
            {
                return "E";
            }
            return "F";
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            bool hasEmpty = false;
            foreach (Control c in fields)
            {
                if (string.IsNullOrWhiteSpace(c.Text))
                {
                    errorProvider1.SetError(c, "Bu xana boş ola bilməz");
                    hasEmpty = true;
                }
                else
                {
                    errorProvider1.SetError(c, "");
                }
            }
            if (hasEmpty)
            {
                return;
            }

            int sdf1, sdf2, ff, seminar, final;
            bool parsed = int.TryParse(txtSdf1.Text.Trim(), out sdf1)
                & int.TryParse(txtSdf2.Text.Trim(), out sdf2)
                & int.TryParse(txtFf.Text.Trim(), out ff)
                & int.TryParse(txtSeminar.Text.Trim(), out seminar)
                & int.TryParse(txtFinal.Text.Trim(), out final);

            if (!parsed || sdf1 < 0 || sdf1 > 10 || sdf2 < 0 || sdf2 > 10 || ff < 0 || ff > 10
                || seminar < 0 || seminar > 20 || final < 0 || final > 50)
            {
                MessageBox.Show("Qiymətləndirmə yanlış aparılmışdır", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string number = txtNumber.Text.Trim();
            bool numberOk = number.Length == 9;
            foreach (char ch in number)
            {
                if (!char.IsDigit(ch))
                {
                    numberOk = false;
                }
            }
            if (!numberOk)
            {
                MessageBox.Show("Tələbə nömrəsi yanlışdır", "Xəta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Focus();
                txtNumber.SelectAll();
                return;
            }

            int entry = sdf1 + sdf2 + ff + seminar;
            int total = entry + final;
            string category = GetCategory(total, final);

            dataGridView1.Rows.Add(txtName.Text.Trim(), number, entry, final, total, category);

            notifyIcon1.ShowBalloonTip(8000);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control c in fields)
            {
                c.Text = "";
                errorProvider1.SetError(c, "");
            }
            txtName.Focus();
        }
    }
}
