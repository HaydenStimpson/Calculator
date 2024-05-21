using System.Windows.Forms;

namespace Calculator
{
    partial class Calculator
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonC = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonSubtract = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonSquareRoot = new System.Windows.Forms.Button();
            this.buttonSquare = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonPlusSlashMinus = new System.Windows.Forms.Button();
            this.buttonDot = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonPercent = new System.Windows.Forms.Button();
            this.buttonOneOver = new System.Windows.Forms.Button();
            this.textBoxTop = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxBottom = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonC
            // 
            this.buttonC.AutoSize = true;
            this.buttonC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonC.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonC.FlatAppearance.BorderSize = 0;
            this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonC.Location = new System.Drawing.Point(167, 91);
            this.buttonC.Margin = new System.Windows.Forms.Padding(1);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(81, 76);
            this.buttonC.TabIndex = 2;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = false;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(167, 247);
            this.button9.Margin = new System.Windows.Forms.Padding(1);
            this.button9.Name = "button9";
            this.button9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button9.Size = new System.Drawing.Size(81, 76);
            this.button9.TabIndex = 10;
            this.button9.Text = "&9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.AutoSize = true;
            this.buttonMultiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMultiply.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonMultiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMultiply.FlatAppearance.BorderSize = 0;
            this.buttonMultiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiply.Location = new System.Drawing.Point(250, 247);
            this.buttonMultiply.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(82, 76);
            this.buttonMultiply.TabIndex = 11;
            this.buttonMultiply.Text = "&*";
            this.buttonMultiply.UseVisualStyleBackColor = false;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(84, 247);
            this.button8.Margin = new System.Windows.Forms.Padding(1);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 76);
            this.button8.TabIndex = 9;
            this.button8.Text = "&8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // buttonSubtract
            // 
            this.buttonSubtract.AutoSize = true;
            this.buttonSubtract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSubtract.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSubtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSubtract.FlatAppearance.BorderSize = 0;
            this.buttonSubtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubtract.Location = new System.Drawing.Point(250, 325);
            this.buttonSubtract.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.buttonSubtract.Name = "buttonSubtract";
            this.buttonSubtract.Size = new System.Drawing.Size(82, 76);
            this.buttonSubtract.TabIndex = 15;
            this.buttonSubtract.Text = "&-";
            this.buttonSubtract.UseVisualStyleBackColor = false;
            this.buttonSubtract.Click += new System.EventHandler(this.buttonSubtract_Click);
            // 
            // buttonDivide
            // 
            this.buttonDivide.AutoSize = true;
            this.buttonDivide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDivide.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDivide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDivide.FlatAppearance.BorderSize = 0;
            this.buttonDivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDivide.Location = new System.Drawing.Point(250, 169);
            this.buttonDivide.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(82, 76);
            this.buttonDivide.TabIndex = 7;
            this.buttonDivide.Text = "&/";
            this.buttonDivide.UseVisualStyleBackColor = false;
            this.buttonDivide.Click += new System.EventHandler(this.buttonDivide_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDelete.Location = new System.Drawing.Point(250, 91);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(82, 76);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "&⌫";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button5
            // 
            this.button5.AutoSize = true;
            this.button5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(84, 325);
            this.button5.Margin = new System.Windows.Forms.Padding(1);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(81, 76);
            this.button5.TabIndex = 13;
            this.button5.Text = "&5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAdd.FlatAppearance.BorderSize = 0;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(250, 403);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(1, 1, 0, 1);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(82, 76);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "&+";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button7
            // 
            this.button7.AutoSize = true;
            this.button7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button7.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(0, 247);
            this.button7.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 76);
            this.button7.TabIndex = 8;
            this.button7.Text = "&7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // buttonEqual
            // 
            this.buttonEqual.AutoSize = true;
            this.buttonEqual.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEqual.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(250, 481);
            this.buttonEqual.Margin = new System.Windows.Forms.Padding(1, 1, 0, 0);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(82, 77);
            this.buttonEqual.TabIndex = 23;
            this.buttonEqual.Text = "&=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(167, 325);
            this.button6.Margin = new System.Windows.Forms.Padding(1);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(81, 76);
            this.button6.TabIndex = 14;
            this.button6.Text = "&6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 325);
            this.button4.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 76);
            this.button4.TabIndex = 12;
            this.button4.Text = "&4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 403);
            this.button2.Margin = new System.Windows.Forms.Padding(1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 76);
            this.button2.TabIndex = 17;
            this.button2.Text = "&2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 403);
            this.button1.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 76);
            this.button1.TabIndex = 16;
            this.button1.Text = "&1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(167, 403);
            this.button3.Margin = new System.Windows.Forms.Padding(1);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 76);
            this.button3.TabIndex = 18;
            this.button3.Text = "&3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonSquareRoot
            // 
            this.buttonSquareRoot.AutoSize = true;
            this.buttonSquareRoot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSquareRoot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSquareRoot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSquareRoot.FlatAppearance.BorderSize = 0;
            this.buttonSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquareRoot.Location = new System.Drawing.Point(167, 169);
            this.buttonSquareRoot.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSquareRoot.Name = "buttonSquareRoot";
            this.buttonSquareRoot.Size = new System.Drawing.Size(81, 76);
            this.buttonSquareRoot.TabIndex = 6;
            this.buttonSquareRoot.Text = "√";
            this.buttonSquareRoot.UseVisualStyleBackColor = false;
            this.buttonSquareRoot.Click += new System.EventHandler(this.buttonSquareRoot_Click);
            // 
            // buttonSquare
            // 
            this.buttonSquare.AutoSize = true;
            this.buttonSquare.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSquare.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSquare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSquare.FlatAppearance.BorderSize = 0;
            this.buttonSquare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSquare.Location = new System.Drawing.Point(84, 169);
            this.buttonSquare.Margin = new System.Windows.Forms.Padding(1);
            this.buttonSquare.Name = "buttonSquare";
            this.buttonSquare.Size = new System.Drawing.Size(81, 76);
            this.buttonSquare.TabIndex = 5;
            this.buttonSquare.Text = "x²";
            this.buttonSquare.UseVisualStyleBackColor = false;
            this.buttonSquare.Click += new System.EventHandler(this.buttonSquare_Click);
            // 
            // button0
            // 
            this.button0.AutoSize = true;
            this.button0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button0.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button0.FlatAppearance.BorderSize = 0;
            this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(84, 481);
            this.button0.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(81, 77);
            this.button0.TabIndex = 21;
            this.button0.Text = "&0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // buttonPlusSlashMinus
            // 
            this.buttonPlusSlashMinus.AutoSize = true;
            this.buttonPlusSlashMinus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPlusSlashMinus.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPlusSlashMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPlusSlashMinus.FlatAppearance.BorderSize = 0;
            this.buttonPlusSlashMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlusSlashMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPlusSlashMinus.Location = new System.Drawing.Point(0, 481);
            this.buttonPlusSlashMinus.Margin = new System.Windows.Forms.Padding(0, 1, 1, 0);
            this.buttonPlusSlashMinus.Name = "buttonPlusSlashMinus";
            this.buttonPlusSlashMinus.Size = new System.Drawing.Size(82, 77);
            this.buttonPlusSlashMinus.TabIndex = 20;
            this.buttonPlusSlashMinus.Text = "+/-";
            this.buttonPlusSlashMinus.UseVisualStyleBackColor = false;
            this.buttonPlusSlashMinus.Click += new System.EventHandler(this.buttonAddSlashMinus_Click);
            // 
            // buttonDot
            // 
            this.buttonDot.AutoSize = true;
            this.buttonDot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDot.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonDot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDot.FlatAppearance.BorderSize = 0;
            this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDot.Location = new System.Drawing.Point(167, 481);
            this.buttonDot.Margin = new System.Windows.Forms.Padding(1, 1, 1, 0);
            this.buttonDot.Name = "buttonDot";
            this.buttonDot.Size = new System.Drawing.Size(81, 77);
            this.buttonDot.TabIndex = 22;
            this.buttonDot.Text = "&.";
            this.buttonDot.UseVisualStyleBackColor = false;
            this.buttonDot.Click += new System.EventHandler(this.buttonDot_Click);
            // 
            // buttonCE
            // 
            this.buttonCE.AutoSize = true;
            this.buttonCE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCE.FlatAppearance.BorderSize = 0;
            this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCE.Location = new System.Drawing.Point(84, 91);
            this.buttonCE.Margin = new System.Windows.Forms.Padding(1);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(81, 76);
            this.buttonCE.TabIndex = 1;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = false;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // buttonPercent
            // 
            this.buttonPercent.AutoSize = true;
            this.buttonPercent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonPercent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonPercent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPercent.FlatAppearance.BorderSize = 0;
            this.buttonPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPercent.Location = new System.Drawing.Point(0, 91);
            this.buttonPercent.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.buttonPercent.Name = "buttonPercent";
            this.buttonPercent.Size = new System.Drawing.Size(82, 76);
            this.buttonPercent.TabIndex = 0;
            this.buttonPercent.Text = "%";
            this.buttonPercent.UseVisualStyleBackColor = false;
            this.buttonPercent.Click += new System.EventHandler(this.buttonPercent_Click);
            // 
            // buttonOneOver
            // 
            this.buttonOneOver.AutoSize = true;
            this.buttonOneOver.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonOneOver.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonOneOver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonOneOver.FlatAppearance.BorderSize = 0;
            this.buttonOneOver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOneOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOneOver.Location = new System.Drawing.Point(0, 169);
            this.buttonOneOver.Margin = new System.Windows.Forms.Padding(0, 1, 1, 1);
            this.buttonOneOver.Name = "buttonOneOver";
            this.buttonOneOver.Size = new System.Drawing.Size(82, 76);
            this.buttonOneOver.TabIndex = 4;
            this.buttonOneOver.Text = "1/x";
            this.buttonOneOver.UseVisualStyleBackColor = false;
            this.buttonOneOver.Click += new System.EventHandler(this.buttonOneOver_Click);
            // 
            // textBoxTop
            // 
            this.textBoxTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxTop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxTop, 4);
            this.textBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTop.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxTop.Location = new System.Drawing.Point(0, 0);
            this.textBoxTop.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTop.Name = "textBoxTop";
            this.textBoxTop.ReadOnly = true;
            this.textBoxTop.Size = new System.Drawing.Size(332, 38);
            this.textBoxTop.TabIndex = 0;
            this.textBoxTop.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxBottom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonOneOver, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonPercent, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonCE, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDot, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonPlusSlashMinus, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.button0, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonSquare, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSquareRoot, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonEqual, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.button7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonAdd, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.button5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonDivide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonSubtract, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.button8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonMultiply, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.buttonC, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 1);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(332, 558);
            this.tableLayoutPanel1.TabIndex = 32;
            // 
            // textBoxBottom
            // 
            this.textBoxBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxBottom.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxBottom, 4);
            this.textBoxBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.textBoxBottom.ForeColor = System.Drawing.Color.LightGray;
            this.textBoxBottom.Location = new System.Drawing.Point(0, 45);
            this.textBoxBottom.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBottom.Name = "textBoxBottom";
            this.textBoxBottom.ReadOnly = true;
            this.textBoxBottom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxBottom.Size = new System.Drawing.Size(332, 38);
            this.textBoxBottom.TabIndex = 33;
            this.textBoxBottom.TabStop = false;
            this.textBoxBottom.Text = "0";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(350, 600);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculatorKeyPress);
            this.Resize += new System.EventHandler(this.CalculatorResize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button buttonC;
        private Button button9;
        private Button buttonMultiply;
        private Button button8;
        private Button buttonSubtract;
        private Button buttonDivide;
        private Button buttonDelete;
        private Button button5;
        private Button buttonAdd;
        private Button button7;
        private Button buttonEqual;
        private Button button6;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button buttonSquareRoot;
        private Button buttonSquare;
        private Button button0;
        private Button buttonPlusSlashMinus;
        private Button buttonDot;
        private Button buttonCE;
        private Button buttonPercent;
        private Button buttonOneOver;
        private TextBox textBoxTop;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox textBoxBottom;
    }
}

