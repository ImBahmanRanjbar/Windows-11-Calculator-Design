namespace Windows_10_Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnltitle = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlHistory = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnclearhistory = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.btnHistory = new System.Windows.Forms.Button();
            this.txtDisplay2 = new System.Windows.Forms.TextBox();
            this.txtDisplay1 = new System.Windows.Forms.TextBox();
            this.btnPM = new BahmanButton.BahmanButtonControl();
            this.btn4 = new BahmanButton.BahmanButtonControl();
            this.btn1 = new BahmanButton.BahmanButtonControl();
            this.btn1dx = new BahmanButton.BahmanButtonControl();
            this.btn7 = new BahmanButton.BahmanButtonControl();
            this.btn0 = new BahmanButton.BahmanButtonControl();
            this.btnPercent = new BahmanButton.BahmanButtonControl();
            this.btn5 = new BahmanButton.BahmanButtonControl();
            this.btnDot = new BahmanButton.BahmanButtonControl();
            this.btnx2 = new BahmanButton.BahmanButtonControl();
            this.btn6 = new BahmanButton.BahmanButtonControl();
            this.btn2 = new BahmanButton.BahmanButtonControl();
            this.btnSqu = new BahmanButton.BahmanButtonControl();
            this.btn8 = new BahmanButton.BahmanButtonControl();
            this.btnEquals = new BahmanButton.BahmanButtonControl();
            this.btnCE = new BahmanButton.BahmanButtonControl();
            this.btn3 = new BahmanButton.BahmanButtonControl();
            this.btnMInes = new BahmanButton.BahmanButtonControl();
            this.btn9 = new BahmanButton.BahmanButtonControl();
            this.btnAdd = new BahmanButton.BahmanButtonControl();
            this.btnDiv = new BahmanButton.BahmanButtonControl();
            this.btnMult = new BahmanButton.BahmanButtonControl();
            this.btnC = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl8 = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl6 = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl5 = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl4 = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl3 = new BahmanButton.BahmanButtonControl();
            this.bahmanButtonControl1 = new BahmanButton.BahmanButtonControl();
            this.elipseForm1 = new BahmanElipse.ElipseControlBahman();
            this.btnBackSpace = new BahmanButton.BahmanButtonControl();
            this.pnltitle.SuspendLayout();
            this.pnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnltitle
            // 
            this.pnltitle.Controls.Add(this.button3);
            this.pnltitle.Controls.Add(this.button2);
            this.pnltitle.Controls.Add(this.button1);
            this.pnltitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltitle.Location = new System.Drawing.Point(0, 0);
            this.pnltitle.Margin = new System.Windows.Forms.Padding(0);
            this.pnltitle.Name = "pnltitle";
            this.pnltitle.Size = new System.Drawing.Size(350, 40);
            this.pnltitle.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = global::Windows_10_Calculator.Properties.Resources.maximize_16dp_CCCCCC_FILL0_wght400_GRAD0_opsz20;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(223, 12);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(40, 27);
            this.button3.TabIndex = 0;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = global::Windows_10_Calculator.Properties.Resources.crop_square_16dp_CCCCCC_FILL0_wght400_GRAD0_opsz201;
            this.button2.Location = new System.Drawing.Point(263, 5);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 31);
            this.button2.TabIndex = 0;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(303, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlHistory
            // 
            this.pnlHistory.Controls.Add(this.richTextBox1);
            this.pnlHistory.Controls.Add(this.btnclearhistory);
            this.pnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHistory.Location = new System.Drawing.Point(0, 521);
            this.pnlHistory.Margin = new System.Windows.Forms.Padding(0);
            this.pnlHistory.Name = "pnlHistory";
            this.pnlHistory.Size = new System.Drawing.Size(350, 5);
            this.pnlHistory.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.ForeColor = System.Drawing.Color.Silver;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBox1.Size = new System.Drawing.Size(350, 0);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnclearhistory
            // 
            this.btnclearhistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnclearhistory.FlatAppearance.BorderSize = 0;
            this.btnclearhistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclearhistory.Image = global::Windows_10_Calculator.Properties.Resources.delete_30dp_CCCCCC_FILL0_wght400_GRAD0_opsz24;
            this.btnclearhistory.Location = new System.Drawing.Point(0, -44);
            this.btnclearhistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnclearhistory.Name = "btnclearhistory";
            this.btnclearhistory.Size = new System.Drawing.Size(350, 49);
            this.btnclearhistory.TabIndex = 0;
            this.btnclearhistory.UseVisualStyleBackColor = true;
            this.btnclearhistory.Click += new System.EventHandler(this.btnclearhistory_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.btnHistory);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 40);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Windows_10_Calculator.Properties.Resources.menu_16dp_CCCCCC_FILL0_wght400_GRAD0_opsz20;
            this.button4.Location = new System.Drawing.Point(4, 5);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(40, 31);
            this.button4.TabIndex = 0;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.FlatAppearance.BorderSize = 0;
            this.btnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistory.Image = global::Windows_10_Calculator.Properties.Resources.history_30dp_CCCCCC_FILL0_wght400_GRAD0_opsz24;
            this.btnHistory.Location = new System.Drawing.Point(303, 5);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(40, 31);
            this.btnHistory.TabIndex = 0;
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // txtDisplay2
            // 
            this.txtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay2.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay2.ForeColor = System.Drawing.Color.Silver;
            this.txtDisplay2.Location = new System.Drawing.Point(0, 80);
            this.txtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay2.Multiline = true;
            this.txtDisplay2.Name = "txtDisplay2";
            this.txtDisplay2.Size = new System.Drawing.Size(350, 25);
            this.txtDisplay2.TabIndex = 3;
            this.txtDisplay2.Text = "Hi";
            this.txtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDisplay1
            // 
            this.txtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.txtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDisplay1.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDisplay1.Font = new System.Drawing.Font("Gadugi", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtDisplay1.Location = new System.Drawing.Point(0, 105);
            this.txtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.txtDisplay1.Multiline = true;
            this.txtDisplay1.Name = "txtDisplay1";
            this.txtDisplay1.Size = new System.Drawing.Size(350, 50);
            this.txtDisplay1.TabIndex = 4;
            this.txtDisplay1.Text = "0";
            this.txtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnPM
            // 
            this.btnPM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPM.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnPM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPM.BorderRadius = 20;
            this.btnPM.BorderSize = 0;
            this.btnPM.FlatAppearance.BorderSize = 0;
            this.btnPM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPM.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPM.ForeColor = System.Drawing.Color.White;
            this.btnPM.Location = new System.Drawing.Point(4, 454);
            this.btnPM.Margin = new System.Windows.Forms.Padding(0);
            this.btnPM.Name = "btnPM";
            this.btnPM.Size = new System.Drawing.Size(85, 50);
            this.btnPM.TabIndex = 5;
            this.btnPM.Text = "±";
            this.btnPM.TextColor = System.Drawing.Color.White;
            this.btnPM.UseVisualStyleBackColor = false;
            this.btnPM.Click += new System.EventHandler(this.BtnOps_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn4.BorderRadius = 20;
            this.btn4.BorderSize = 0;
            this.btn4.FlatAppearance.BorderSize = 0;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.ForeColor = System.Drawing.Color.White;
            this.btn4.Location = new System.Drawing.Point(4, 354);
            this.btn4.Margin = new System.Windows.Forms.Padding(0);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(85, 50);
            this.btn4.TabIndex = 5;
            this.btn4.Text = "4";
            this.btn4.TextColor = System.Drawing.Color.White;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn1.BorderRadius = 20;
            this.btn1.BorderSize = 0;
            this.btn1.FlatAppearance.BorderSize = 0;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.ForeColor = System.Drawing.Color.White;
            this.btn1.Location = new System.Drawing.Point(4, 404);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(85, 50);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.TextColor = System.Drawing.Color.White;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btn1dx
            // 
            this.btn1dx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn1dx.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btn1dx.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn1dx.BorderRadius = 20;
            this.btn1dx.BorderSize = 0;
            this.btn1dx.FlatAppearance.BorderSize = 0;
            this.btn1dx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1dx.ForeColor = System.Drawing.Color.White;
            this.btn1dx.Location = new System.Drawing.Point(4, 254);
            this.btn1dx.Margin = new System.Windows.Forms.Padding(0);
            this.btn1dx.Name = "btn1dx";
            this.btn1dx.Size = new System.Drawing.Size(85, 50);
            this.btn1dx.TabIndex = 5;
            this.btn1dx.Text = "1⁄x";
            this.btn1dx.TextColor = System.Drawing.Color.White;
            this.btn1dx.UseVisualStyleBackColor = false;
            this.btn1dx.Click += new System.EventHandler(this.BtnOps_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn7.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn7.BorderRadius = 20;
            this.btn7.BorderSize = 0;
            this.btn7.FlatAppearance.BorderSize = 0;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.ForeColor = System.Drawing.Color.White;
            this.btn7.Location = new System.Drawing.Point(4, 304);
            this.btn7.Margin = new System.Windows.Forms.Padding(0);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(85, 50);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.TextColor = System.Drawing.Color.White;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn0.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn0.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn0.BorderRadius = 20;
            this.btn0.BorderSize = 0;
            this.btn0.FlatAppearance.BorderSize = 0;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.ForeColor = System.Drawing.Color.White;
            this.btn0.Location = new System.Drawing.Point(89, 454);
            this.btn0.Margin = new System.Windows.Forms.Padding(0);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(85, 50);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.TextColor = System.Drawing.Color.White;
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btnPercent
            // 
            this.btnPercent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPercent.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPercent.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnPercent.BorderRadius = 20;
            this.btnPercent.BorderSize = 0;
            this.btnPercent.FlatAppearance.BorderSize = 0;
            this.btnPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPercent.ForeColor = System.Drawing.Color.White;
            this.btnPercent.Location = new System.Drawing.Point(4, 204);
            this.btnPercent.Margin = new System.Windows.Forms.Padding(0);
            this.btnPercent.Name = "btnPercent";
            this.btnPercent.Size = new System.Drawing.Size(85, 50);
            this.btnPercent.TabIndex = 5;
            this.btnPercent.Text = "%";
            this.btnPercent.TextColor = System.Drawing.Color.White;
            this.btnPercent.UseVisualStyleBackColor = false;
            this.btnPercent.Click += new System.EventHandler(this.BtnOps_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn5.BorderRadius = 20;
            this.btn5.BorderSize = 0;
            this.btn5.FlatAppearance.BorderSize = 0;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.ForeColor = System.Drawing.Color.White;
            this.btn5.Location = new System.Drawing.Point(89, 354);
            this.btn5.Margin = new System.Windows.Forms.Padding(0);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(85, 50);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.TextColor = System.Drawing.Color.White;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btnDot
            // 
            this.btnDot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnDot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDot.BorderRadius = 20;
            this.btnDot.BorderSize = 0;
            this.btnDot.FlatAppearance.BorderSize = 0;
            this.btnDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDot.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.ForeColor = System.Drawing.Color.White;
            this.btnDot.Location = new System.Drawing.Point(174, 454);
            this.btnDot.Margin = new System.Windows.Forms.Padding(0);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(85, 50);
            this.btnDot.TabIndex = 5;
            this.btnDot.Text = ".";
            this.btnDot.TextColor = System.Drawing.Color.White;
            this.btnDot.UseVisualStyleBackColor = false;
            this.btnDot.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btnx2
            // 
            this.btnx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnx2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnx2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnx2.BorderRadius = 20;
            this.btnx2.BorderSize = 0;
            this.btnx2.FlatAppearance.BorderSize = 0;
            this.btnx2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnx2.ForeColor = System.Drawing.Color.White;
            this.btnx2.Location = new System.Drawing.Point(89, 254);
            this.btnx2.Margin = new System.Windows.Forms.Padding(0);
            this.btnx2.Name = "btnx2";
            this.btnx2.Size = new System.Drawing.Size(85, 50);
            this.btnx2.TabIndex = 5;
            this.btnx2.Text = "^2";
            this.btnx2.TextColor = System.Drawing.Color.White;
            this.btnx2.UseVisualStyleBackColor = false;
            this.btnx2.Click += new System.EventHandler(this.BtnOps_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn6.BorderRadius = 20;
            this.btn6.BorderSize = 0;
            this.btn6.FlatAppearance.BorderSize = 0;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.ForeColor = System.Drawing.Color.White;
            this.btn6.Location = new System.Drawing.Point(174, 354);
            this.btn6.Margin = new System.Windows.Forms.Padding(0);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(85, 50);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.TextColor = System.Drawing.Color.White;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn2.BorderRadius = 20;
            this.btn2.BorderSize = 0;
            this.btn2.FlatAppearance.BorderSize = 0;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.ForeColor = System.Drawing.Color.White;
            this.btn2.Location = new System.Drawing.Point(89, 404);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(85, 50);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.TextColor = System.Drawing.Color.White;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btnSqu
            // 
            this.btnSqu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSqu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnSqu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSqu.BorderRadius = 20;
            this.btnSqu.BorderSize = 0;
            this.btnSqu.FlatAppearance.BorderSize = 0;
            this.btnSqu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSqu.ForeColor = System.Drawing.Color.White;
            this.btnSqu.Location = new System.Drawing.Point(174, 254);
            this.btnSqu.Margin = new System.Windows.Forms.Padding(0);
            this.btnSqu.Name = "btnSqu";
            this.btnSqu.Size = new System.Drawing.Size(85, 50);
            this.btnSqu.TabIndex = 5;
            this.btnSqu.Text = "√x";
            this.btnSqu.TextColor = System.Drawing.Color.White;
            this.btnSqu.UseVisualStyleBackColor = false;
            this.btnSqu.Click += new System.EventHandler(this.BtnOps_Click);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn8.BorderRadius = 20;
            this.btn8.BorderSize = 0;
            this.btn8.FlatAppearance.BorderSize = 0;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.ForeColor = System.Drawing.Color.White;
            this.btn8.Location = new System.Drawing.Point(89, 304);
            this.btn8.Margin = new System.Windows.Forms.Padding(0);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(85, 50);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.TextColor = System.Drawing.Color.White;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEquals.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.btnEquals.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnEquals.BorderRadius = 20;
            this.btnEquals.BorderSize = 0;
            this.btnEquals.FlatAppearance.BorderSize = 0;
            this.btnEquals.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEquals.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquals.ForeColor = System.Drawing.Color.White;
            this.btnEquals.Location = new System.Drawing.Point(260, 454);
            this.btnEquals.Margin = new System.Windows.Forms.Padding(0);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(85, 50);
            this.btnEquals.TabIndex = 5;
            this.btnEquals.Text = "=";
            this.btnEquals.TextColor = System.Drawing.Color.White;
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnCE
            // 
            this.btnCE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCE.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnCE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnCE.BorderRadius = 20;
            this.btnCE.BorderSize = 0;
            this.btnCE.FlatAppearance.BorderSize = 0;
            this.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCE.ForeColor = System.Drawing.Color.White;
            this.btnCE.Location = new System.Drawing.Point(89, 204);
            this.btnCE.Margin = new System.Windows.Forms.Padding(0);
            this.btnCE.Name = "btnCE";
            this.btnCE.Size = new System.Drawing.Size(85, 50);
            this.btnCE.TabIndex = 5;
            this.btnCE.Text = "CE";
            this.btnCE.TextColor = System.Drawing.Color.White;
            this.btnCE.UseVisualStyleBackColor = false;
            this.btnCE.Click += new System.EventHandler(this.btnCE_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn3.BorderRadius = 20;
            this.btn3.BorderSize = 0;
            this.btn3.FlatAppearance.BorderSize = 0;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.ForeColor = System.Drawing.Color.White;
            this.btn3.Location = new System.Drawing.Point(174, 404);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(85, 50);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.TextColor = System.Drawing.Color.White;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btnMInes
            // 
            this.btnMInes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMInes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMInes.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMInes.BorderRadius = 20;
            this.btnMInes.BorderSize = 0;
            this.btnMInes.FlatAppearance.BorderSize = 0;
            this.btnMInes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMInes.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMInes.ForeColor = System.Drawing.Color.White;
            this.btnMInes.Location = new System.Drawing.Point(260, 354);
            this.btnMInes.Margin = new System.Windows.Forms.Padding(0);
            this.btnMInes.Name = "btnMInes";
            this.btnMInes.Size = new System.Drawing.Size(85, 50);
            this.btnMInes.TabIndex = 5;
            this.btnMInes.Text = "-";
            this.btnMInes.TextColor = System.Drawing.Color.White;
            this.btnMInes.UseVisualStyleBackColor = false;
            this.btnMInes.Click += new System.EventHandler(this.BtnMathOp_Click);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn9.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btn9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btn9.BorderRadius = 20;
            this.btn9.BorderSize = 0;
            this.btn9.FlatAppearance.BorderSize = 0;
            this.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn9.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.ForeColor = System.Drawing.Color.White;
            this.btn9.Location = new System.Drawing.Point(174, 304);
            this.btn9.Margin = new System.Windows.Forms.Padding(0);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(85, 50);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.TextColor = System.Drawing.Color.White;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.BtnNum_click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnAdd.BorderRadius = 20;
            this.btnAdd.BorderSize = 0;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(260, 404);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.TextColor = System.Drawing.Color.White;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnMathOp_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDiv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnDiv.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnDiv.BorderRadius = 20;
            this.btnDiv.BorderSize = 0;
            this.btnDiv.FlatAppearance.BorderSize = 0;
            this.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiv.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiv.ForeColor = System.Drawing.Color.White;
            this.btnDiv.Location = new System.Drawing.Point(260, 254);
            this.btnDiv.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(85, 50);
            this.btnDiv.TabIndex = 5;
            this.btnDiv.Text = "÷";
            this.btnDiv.TextColor = System.Drawing.Color.White;
            this.btnDiv.UseVisualStyleBackColor = false;
            this.btnDiv.Click += new System.EventHandler(this.BtnMathOp_Click);
            // 
            // btnMult
            // 
            this.btnMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMult.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMult.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnMult.BorderRadius = 20;
            this.btnMult.BorderSize = 0;
            this.btnMult.FlatAppearance.BorderSize = 0;
            this.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMult.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMult.ForeColor = System.Drawing.Color.White;
            this.btnMult.Location = new System.Drawing.Point(260, 304);
            this.btnMult.Margin = new System.Windows.Forms.Padding(0);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(85, 50);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "x";
            this.btnMult.TextColor = System.Drawing.Color.White;
            this.btnMult.UseVisualStyleBackColor = false;
            this.btnMult.Click += new System.EventHandler(this.BtnMathOp_Click);
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnC.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnC.BorderRadius = 20;
            this.btnC.BorderSize = 0;
            this.btnC.FlatAppearance.BorderSize = 0;
            this.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.Location = new System.Drawing.Point(174, 204);
            this.btnC.Margin = new System.Windows.Forms.Padding(0);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(85, 50);
            this.btnC.TabIndex = 5;
            this.btnC.Text = "C";
            this.btnC.TextColor = System.Drawing.Color.White;
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.bahmanButtonControl7_Click);
            // 
            // bahmanButtonControl8
            // 
            this.bahmanButtonControl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl8.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl8.BorderRadius = 15;
            this.bahmanButtonControl8.BorderSize = 0;
            this.bahmanButtonControl8.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl8.ForeColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl8.Location = new System.Drawing.Point(0, 174);
            this.bahmanButtonControl8.Margin = new System.Windows.Forms.Padding(0);
            this.bahmanButtonControl8.Name = "bahmanButtonControl8";
            this.bahmanButtonControl8.Size = new System.Drawing.Size(50, 30);
            this.bahmanButtonControl8.TabIndex = 5;
            this.bahmanButtonControl8.Text = "MC";
            this.bahmanButtonControl8.TextColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl8.UseVisualStyleBackColor = false;
            // 
            // bahmanButtonControl6
            // 
            this.bahmanButtonControl6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl6.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl6.BorderRadius = 15;
            this.bahmanButtonControl6.BorderSize = 0;
            this.bahmanButtonControl6.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl6.ForeColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl6.Location = new System.Drawing.Point(60, 174);
            this.bahmanButtonControl6.Margin = new System.Windows.Forms.Padding(0);
            this.bahmanButtonControl6.Name = "bahmanButtonControl6";
            this.bahmanButtonControl6.Size = new System.Drawing.Size(50, 30);
            this.bahmanButtonControl6.TabIndex = 5;
            this.bahmanButtonControl6.Text = "MR";
            this.bahmanButtonControl6.TextColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl6.UseVisualStyleBackColor = false;
            // 
            // bahmanButtonControl5
            // 
            this.bahmanButtonControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl5.BorderRadius = 15;
            this.bahmanButtonControl5.BorderSize = 0;
            this.bahmanButtonControl5.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl5.ForeColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl5.Location = new System.Drawing.Point(120, 174);
            this.bahmanButtonControl5.Margin = new System.Windows.Forms.Padding(0);
            this.bahmanButtonControl5.Name = "bahmanButtonControl5";
            this.bahmanButtonControl5.Size = new System.Drawing.Size(50, 30);
            this.bahmanButtonControl5.TabIndex = 5;
            this.bahmanButtonControl5.Text = "M+";
            this.bahmanButtonControl5.TextColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl5.UseVisualStyleBackColor = false;
            // 
            // bahmanButtonControl4
            // 
            this.bahmanButtonControl4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl4.BorderRadius = 15;
            this.bahmanButtonControl4.BorderSize = 0;
            this.bahmanButtonControl4.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl4.ForeColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl4.Location = new System.Drawing.Point(180, 174);
            this.bahmanButtonControl4.Margin = new System.Windows.Forms.Padding(0);
            this.bahmanButtonControl4.Name = "bahmanButtonControl4";
            this.bahmanButtonControl4.Size = new System.Drawing.Size(50, 30);
            this.bahmanButtonControl4.TabIndex = 5;
            this.bahmanButtonControl4.Text = "M-";
            this.bahmanButtonControl4.TextColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl4.UseVisualStyleBackColor = false;
            // 
            // bahmanButtonControl3
            // 
            this.bahmanButtonControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl3.BorderRadius = 15;
            this.bahmanButtonControl3.BorderSize = 0;
            this.bahmanButtonControl3.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl3.ForeColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl3.Location = new System.Drawing.Point(240, 174);
            this.bahmanButtonControl3.Margin = new System.Windows.Forms.Padding(0);
            this.bahmanButtonControl3.Name = "bahmanButtonControl3";
            this.bahmanButtonControl3.Size = new System.Drawing.Size(50, 30);
            this.bahmanButtonControl3.TabIndex = 5;
            this.bahmanButtonControl3.Text = "MS";
            this.bahmanButtonControl3.TextColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl3.UseVisualStyleBackColor = false;
            // 
            // bahmanButtonControl1
            // 
            this.bahmanButtonControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.bahmanButtonControl1.BorderRadius = 15;
            this.bahmanButtonControl1.BorderSize = 0;
            this.bahmanButtonControl1.FlatAppearance.BorderSize = 0;
            this.bahmanButtonControl1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bahmanButtonControl1.ForeColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl1.Location = new System.Drawing.Point(300, 174);
            this.bahmanButtonControl1.Margin = new System.Windows.Forms.Padding(0);
            this.bahmanButtonControl1.Name = "bahmanButtonControl1";
            this.bahmanButtonControl1.Size = new System.Drawing.Size(50, 30);
            this.bahmanButtonControl1.TabIndex = 5;
            this.bahmanButtonControl1.Text = "M~";
            this.bahmanButtonControl1.TextColor = System.Drawing.Color.DarkGray;
            this.bahmanButtonControl1.UseVisualStyleBackColor = false;
            // 
            // elipseForm1
            // 
            this.elipseForm1.CornerRadius = 22;
            this.elipseForm1.TargetControl = this;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBackSpace.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnBackSpace.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnBackSpace.BorderRadius = 20;
            this.btnBackSpace.BorderSize = 0;
            this.btnBackSpace.FlatAppearance.BorderSize = 0;
            this.btnBackSpace.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackSpace.ForeColor = System.Drawing.Color.White;
            this.btnBackSpace.Image = global::Windows_10_Calculator.Properties.Resources.backspace_30dp_CCCCCC_FILL0_wght400_GRAD0_opsz24;
            this.btnBackSpace.Location = new System.Drawing.Point(260, 204);
            this.btnBackSpace.Margin = new System.Windows.Forms.Padding(0);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(85, 50);
            this.btnBackSpace.TabIndex = 5;
            this.btnBackSpace.TextColor = System.Drawing.Color.White;
            this.btnBackSpace.UseVisualStyleBackColor = false;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBackSpace_Click);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(350, 526);
            this.Controls.Add(this.pnlHistory);
            this.Controls.Add(this.btnPM);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn1dx);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnPercent);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btnx2);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnSqu);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnCE);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnMInes);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btnBackSpace);
            this.Controls.Add(this.bahmanButtonControl8);
            this.Controls.Add(this.bahmanButtonControl6);
            this.Controls.Add(this.bahmanButtonControl5);
            this.Controls.Add(this.bahmanButtonControl4);
            this.Controls.Add(this.bahmanButtonControl3);
            this.Controls.Add(this.bahmanButtonControl1);
            this.Controls.Add(this.txtDisplay1);
            this.Controls.Add(this.txtDisplay2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnltitle);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnltitle.ResumeLayout(false);
            this.pnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnltitle;
        private System.Windows.Forms.Panel pnlHistory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnclearhistory;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TextBox txtDisplay2;
        private System.Windows.Forms.TextBox txtDisplay1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private BahmanElipse.ElipseControlBahman elipseForm1;
        private BahmanButton.BahmanButtonControl bahmanButtonControl1;
        private BahmanButton.BahmanButtonControl btnBackSpace;
        private BahmanButton.BahmanButtonControl bahmanButtonControl3;
        private BahmanButton.BahmanButtonControl bahmanButtonControl4;
        private BahmanButton.BahmanButtonControl bahmanButtonControl5;
        private BahmanButton.BahmanButtonControl bahmanButtonControl6;
        private BahmanButton.BahmanButtonControl bahmanButtonControl8;
        private BahmanButton.BahmanButtonControl btnPercent;
        private BahmanButton.BahmanButtonControl btnCE;
        private BahmanButton.BahmanButtonControl btnC;
        private BahmanButton.BahmanButtonControl btn1dx;
        private BahmanButton.BahmanButtonControl btnx2;
        private BahmanButton.BahmanButtonControl btnSqu;
        private BahmanButton.BahmanButtonControl btnDiv;
        private BahmanButton.BahmanButtonControl btnPM;
        private BahmanButton.BahmanButtonControl btn4;
        private BahmanButton.BahmanButtonControl btn1;
        private BahmanButton.BahmanButtonControl btn7;
        private BahmanButton.BahmanButtonControl btn0;
        private BahmanButton.BahmanButtonControl btn5;
        private BahmanButton.BahmanButtonControl btnDot;
        private BahmanButton.BahmanButtonControl btn6;
        private BahmanButton.BahmanButtonControl btn2;
        private BahmanButton.BahmanButtonControl btn8;
        private BahmanButton.BahmanButtonControl btnEquals;
        private BahmanButton.BahmanButtonControl btn3;
        private BahmanButton.BahmanButtonControl btnMInes;
        private BahmanButton.BahmanButtonControl btn9;
        private BahmanButton.BahmanButtonControl btnAdd;
        private BahmanButton.BahmanButtonControl btnMult;
        private System.Windows.Forms.Button button4;
    }
}

