using System.Drawing;
using System.Windows.Forms;

namespace ExamSystem
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlHeader = new Panel();
            pictureBox1 = new PictureBox();
            lblTitle = new Label();
            lblSdf1 = new Label();
            lblSdf2 = new Label();
            lblFf = new Label();
            lblSeminar = new Label();
            lblFinal = new Label();
            txtSdf1 = new MaskedTextBox();
            txtSdf2 = new MaskedTextBox();
            txtFf = new MaskedTextBox();
            txtSeminar = new MaskedTextBox();
            txtFinal = new MaskedTextBox();
            groupBox1 = new GroupBox();
            lblName = new Label();
            txtName = new TextBox();
            lblNumber = new Label();
            txtNumber = new TextBox();
            btnResult = new Button();
            btnClear = new Button();
            dataGridView1 = new DataGridView();
            colName = new DataGridViewTextBoxColumn();
            colNumber = new DataGridViewTextBoxColumn();
            colEntry = new DataGridViewTextBoxColumn();
            colFinal = new DataGridViewTextBoxColumn();
            colResult = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            toolTip1 = new ToolTip(components);
            notifyIcon1 = new NotifyIcon(components);
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(3, 4, 3, 4);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1515, 141);
            pnlHeader.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2026_10_15_222140;
            pictureBox1.Location = new Point(33, 3);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 127);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Microsoft Sans Serif", 21.75F, FontStyle.Bold);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(794, 45);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(357, 42);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "İMTAHAN SİSTEMİ";
            // 
            // lblSdf1
            // 
            lblSdf1.AutoSize = true;
            lblSdf1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSdf1.ForeColor = Color.White;
            lblSdf1.Location = new Point(17, 185);
            lblSdf1.Name = "lblSdf1";
            lblSdf1.Size = new Size(65, 28);
            lblSdf1.TabIndex = 11;
            lblSdf1.Text = "SDF1:";
            // 
            // lblSdf2
            // 
            lblSdf2.AutoSize = true;
            lblSdf2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSdf2.ForeColor = Color.White;
            lblSdf2.Location = new Point(17, 281);
            lblSdf2.Name = "lblSdf2";
            lblSdf2.Size = new Size(65, 28);
            lblSdf2.TabIndex = 10;
            lblSdf2.Text = "SDF2:";
            // 
            // lblFf
            // 
            lblFf.AutoSize = true;
            lblFf.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFf.ForeColor = Color.White;
            lblFf.Location = new Point(17, 383);
            lblFf.Name = "lblFf";
            lblFf.Size = new Size(37, 28);
            lblFf.TabIndex = 9;
            lblFf.Text = "FF:";
            // 
            // lblSeminar
            // 
            lblSeminar.AutoSize = true;
            lblSeminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSeminar.ForeColor = Color.White;
            lblSeminar.Location = new Point(17, 481);
            lblSeminar.Name = "lblSeminar";
            lblSeminar.Size = new Size(95, 28);
            lblSeminar.TabIndex = 8;
            lblSeminar.Text = "Seminar:";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblFinal.ForeColor = Color.White;
            lblFinal.Location = new Point(17, 588);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(62, 28);
            lblFinal.TabIndex = 7;
            lblFinal.Text = "Final:";
            // 
            // txtSdf1
            // 
            txtSdf1.BorderStyle = BorderStyle.FixedSingle;
            txtSdf1.Font = new Font("Segoe UI", 10.5F);
            txtSdf1.Location = new Point(146, 184);
            txtSdf1.Margin = new Padding(3, 4, 3, 4);
            txtSdf1.Mask = "99";
            txtSdf1.Name = "txtSdf1";
            txtSdf1.Size = new Size(92, 31);
            txtSdf1.TabIndex = 0;
            txtSdf1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(txtSdf1, "SDF1 imtahanı 0-10 bal arasında qiymətləndirilir.");
            // 
            // txtSdf2
            // 
            txtSdf2.BorderStyle = BorderStyle.FixedSingle;
            txtSdf2.Font = new Font("Segoe UI", 10.5F);
            txtSdf2.Location = new Point(146, 279);
            txtSdf2.Margin = new Padding(3, 4, 3, 4);
            txtSdf2.Mask = "99";
            txtSdf2.Name = "txtSdf2";
            txtSdf2.Size = new Size(92, 31);
            txtSdf2.TabIndex = 1;
            txtSdf2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(txtSdf2, "SDF2 imtahanı 0-10 bal arasında qiymətləndirilir.");
            // 
            // txtFf
            // 
            txtFf.BorderStyle = BorderStyle.FixedSingle;
            txtFf.Font = new Font("Segoe UI", 10.5F);
            txtFf.Location = new Point(146, 380);
            txtFf.Margin = new Padding(3, 4, 3, 4);
            txtFf.Mask = "99";
            txtFf.Name = "txtFf";
            txtFf.Size = new Size(92, 31);
            txtFf.TabIndex = 2;
            txtFf.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(txtFf, "FF imtahanı 0-10 bal arasında qiymətləndirilir.");
            // 
            // txtSeminar
            // 
            txtSeminar.BorderStyle = BorderStyle.FixedSingle;
            txtSeminar.Font = new Font("Segoe UI", 10.5F);
            txtSeminar.Location = new Point(146, 480);
            txtSeminar.Margin = new Padding(3, 4, 3, 4);
            txtSeminar.Mask = "99";
            txtSeminar.Name = "txtSeminar";
            txtSeminar.Size = new Size(92, 31);
            txtSeminar.TabIndex = 3;
            txtSeminar.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(txtSeminar, "Seminar 0-20 bal arasında qiymətləndirilir.");
            // 
            // txtFinal
            // 
            txtFinal.BorderStyle = BorderStyle.FixedSingle;
            txtFinal.Font = new Font("Segoe UI", 10.5F);
            txtFinal.Location = new Point(146, 588);
            txtFinal.Margin = new Padding(3, 4, 3, 4);
            txtFinal.Mask = "99";
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(92, 31);
            txtFinal.TabIndex = 4;
            txtFinal.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            toolTip1.SetToolTip(txtFinal, "Final imtahanı (SSİ) 0-50 bal arasında qiymətləndirilir.");
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblName);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(lblNumber);
            groupBox1.Controls.Add(txtNumber);
            groupBox1.Controls.Add(btnResult);
            groupBox1.Controls.Add(btnClear);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(271, 187);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(322, 439);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tələbə məlumatları";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblName.ForeColor = Color.White;
            lblName.Location = new Point(27, 67);
            lblName.Name = "lblName";
            lblName.Size = new Size(119, 25);
            lblName.TabIndex = 0;
            lblName.Text = "Ad və soyad";
            // 
            // txtName
            // 
            txtName.BorderStyle = BorderStyle.FixedSingle;
            txtName.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtName.Location = new Point(25, 117);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(265, 32);
            txtName.TabIndex = 0;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            lblNumber.ForeColor = Color.White;
            lblNumber.Location = new Point(27, 195);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(147, 25);
            lblNumber.TabIndex = 1;
            lblNumber.Text = "Tələbə nömrəsi";
            // 
            // txtNumber
            // 
            txtNumber.BorderStyle = BorderStyle.FixedSingle;
            txtNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            txtNumber.Location = new Point(25, 248);
            txtNumber.Margin = new Padding(3, 4, 3, 4);
            txtNumber.MaxLength = 9;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(265, 32);
            txtNumber.TabIndex = 1;
            // 
            // btnResult
            // 
            btnResult.BackColor = Color.Green;
            btnResult.FlatAppearance.BorderColor = Color.White;
            btnResult.FlatStyle = FlatStyle.Flat;
            btnResult.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnResult.ForeColor = Color.White;
            btnResult.Location = new Point(24, 341);
            btnResult.Margin = new Padding(3, 4, 3, 4);
            btnResult.Name = "btnResult";
            btnResult.Size = new Size(106, 59);
            btnResult.TabIndex = 2;
            btnResult.Text = "Nəticə";
            btnResult.UseVisualStyleBackColor = false;
            btnResult.Click += btnResult_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 0, 0);
            btnClear.FlatAppearance.BorderColor = Color.White;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(163, 341);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(127, 59);
            btnClear.TabIndex = 3;
            btnClear.Text = "Təmizlə";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.BackgroundColor = Color.FromArgb(160, 160, 160);
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeight = 44;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { colName, colNumber, colEntry, colFinal, colResult, colCategory });
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.FromArgb(160, 160, 160);
            dataGridView1.Location = new Point(615, 183);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 50;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(874, 435);
            dataGridView1.TabIndex = 6;
            dataGridView1.TabStop = false;
            // 
            // colName
            // 
            colName.HeaderText = "Ad və soyad";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.SortMode = DataGridViewColumnSortMode.NotSortable;
            colName.Width = 125;
            // 
            // colNumber
            // 
            colNumber.HeaderText = "Tələbə nömrəsi";
            colNumber.MinimumWidth = 6;
            colNumber.Name = "colNumber";
            colNumber.ReadOnly = true;
            colNumber.SortMode = DataGridViewColumnSortMode.NotSortable;
            colNumber.Width = 125;
            // 
            // colEntry
            // 
            colEntry.HeaderText = "Giriş balı";
            colEntry.MinimumWidth = 6;
            colEntry.Name = "colEntry";
            colEntry.ReadOnly = true;
            colEntry.SortMode = DataGridViewColumnSortMode.NotSortable;
            colEntry.Width = 125;
            // 
            // colFinal
            // 
            colFinal.HeaderText = "SSİ";
            colFinal.MinimumWidth = 6;
            colFinal.Name = "colFinal";
            colFinal.ReadOnly = true;
            colFinal.SortMode = DataGridViewColumnSortMode.NotSortable;
            colFinal.Width = 125;
            // 
            // colResult
            // 
            colResult.HeaderText = "Nəticə";
            colResult.MinimumWidth = 6;
            colResult.Name = "colResult";
            colResult.ReadOnly = true;
            colResult.SortMode = DataGridViewColumnSortMode.NotSortable;
            colResult.Width = 125;
            // 
            // colCategory
            // 
            colCategory.HeaderText = "Kateqorya";
            colCategory.MinimumWidth = 6;
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            colCategory.SortMode = DataGridViewColumnSortMode.NotSortable;
            colCategory.Width = 85;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // toolTip1
            // 
            toolTip1.AutoPopDelay = 6000;
            toolTip1.InitialDelay = 300;
            toolTip1.ReshowDelay = 100;
            toolTip1.ShowAlways = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Qiymət aralığı";
            // 
            // notifyIcon1
            // 
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.BalloonTipText = "Tələbənin məlumatları sistemə əlavə edildi";
            notifyIcon1.BalloonTipTitle = "Proqram bildirişi";
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Exam system";
            notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 128, 128);
            ClientSize = new Size(1515, 637);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(txtFinal);
            Controls.Add(txtSeminar);
            Controls.Add(txtFf);
            Controls.Add(txtSdf2);
            Controls.Add(txtSdf1);
            Controls.Add(lblFinal);
            Controls.Add(lblSeminar);
            Controls.Add(lblFf);
            Controls.Add(lblSdf2);
            Controls.Add(lblSdf1);
            Controls.Add(pnlHeader);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exam system";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel pnlHeader;
        private PictureBox pictureBox1;
        private Label lblTitle;
        private Label lblSdf1;
        private Label lblSdf2;
        private Label lblFf;
        private Label lblSeminar;
        private Label lblFinal;
        private MaskedTextBox txtSdf1;
        private MaskedTextBox txtSdf2;
        private MaskedTextBox txtFf;
        private MaskedTextBox txtSeminar;
        private MaskedTextBox txtFinal;
        private GroupBox groupBox1;
        private Label lblName;
        private TextBox txtName;
        private Label lblNumber;
        private TextBox txtNumber;
        private Button btnResult;
        private Button btnClear;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colNumber;
        private DataGridViewTextBoxColumn colEntry;
        private DataGridViewTextBoxColumn colFinal;
        private DataGridViewTextBoxColumn colResult;
        private DataGridViewTextBoxColumn colCategory;
        private ErrorProvider errorProvider1;
        private ToolTip toolTip1;
        private NotifyIcon notifyIcon1;
    }
}
