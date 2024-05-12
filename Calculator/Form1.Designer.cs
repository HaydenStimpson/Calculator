﻿using System.Windows.Forms;

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
            this.textBoxTop = new System.Windows.Forms.TextBox();
            this.button_1 = new System.Windows.Forms.Button();
            this.button_5 = new System.Windows.Forms.Button();
            this.button_2 = new System.Windows.Forms.Button();
            this.button_9 = new System.Windows.Forms.Button();
            this.button_8 = new System.Windows.Forms.Button();
            this.button_6 = new System.Windows.Forms.Button();
            this.button_3 = new System.Windows.Forms.Button();
            this.button_7 = new System.Windows.Forms.Button();
            this.button_4 = new System.Windows.Forms.Button();
            this.button_subtract = new System.Windows.Forms.Button();
            this.button_multiply = new System.Windows.Forms.Button();
            this.button_divide = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_C = new System.Windows.Forms.Button();
            this.button_CE = new System.Windows.Forms.Button();
            this.button_square = new System.Windows.Forms.Button();
            this.button_square_root = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxBottom = new System.Windows.Forms.TextBox();
            this.button_One_Over = new System.Windows.Forms.Button();
            this.button_Percent = new System.Windows.Forms.Button();
            this.button_dot = new System.Windows.Forms.Button();
            this.button_plus_slash_minus = new System.Windows.Forms.Button();
            this.button_0 = new System.Windows.Forms.Button();
            this.button_equal = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxTop
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxTop, 4);
            this.textBoxTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTop.Location = new System.Drawing.Point(0, 0);
            this.textBoxTop.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxTop.Name = "textBoxTop";
            this.textBoxTop.ReadOnly = true;
            this.textBoxTop.Size = new System.Drawing.Size(332, 45);
            this.textBoxTop.TabIndex = 0;
            this.textBoxTop.TabStop = false;
            // 
            // button_1
            // 
            this.button_1.AutoSize = true;
            this.button_1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_1.Location = new System.Drawing.Point(1, 403);
            this.button_1.Margin = new System.Windows.Forms.Padding(1);
            this.button_1.Name = "button_1";
            this.button_1.Size = new System.Drawing.Size(81, 76);
            this.button_1.TabIndex = 16;
            this.button_1.Text = "&1";
            this.button_1.UseVisualStyleBackColor = true;
            this.button_1.Click += new System.EventHandler(this.button_1_Click);
            // 
            // button_5
            // 
            this.button_5.AutoSize = true;
            this.button_5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_5.Location = new System.Drawing.Point(84, 325);
            this.button_5.Margin = new System.Windows.Forms.Padding(1);
            this.button_5.Name = "button_5";
            this.button_5.Size = new System.Drawing.Size(81, 76);
            this.button_5.TabIndex = 13;
            this.button_5.Text = "&5";
            this.button_5.UseVisualStyleBackColor = true;
            this.button_5.Click += new System.EventHandler(this.button_5_Click);
            // 
            // button_2
            // 
            this.button_2.AutoSize = true;
            this.button_2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_2.Location = new System.Drawing.Point(84, 403);
            this.button_2.Margin = new System.Windows.Forms.Padding(1);
            this.button_2.Name = "button_2";
            this.button_2.Size = new System.Drawing.Size(81, 76);
            this.button_2.TabIndex = 17;
            this.button_2.Text = "&2";
            this.button_2.UseVisualStyleBackColor = true;
            this.button_2.Click += new System.EventHandler(this.button_2_Click);
            // 
            // button_9
            // 
            this.button_9.AutoSize = true;
            this.button_9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_9.Location = new System.Drawing.Point(167, 247);
            this.button_9.Margin = new System.Windows.Forms.Padding(1);
            this.button_9.Name = "button_9";
            this.button_9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_9.Size = new System.Drawing.Size(81, 76);
            this.button_9.TabIndex = 10;
            this.button_9.Text = "&9";
            this.button_9.UseVisualStyleBackColor = true;
            this.button_9.Click += new System.EventHandler(this.button_9_Click);
            // 
            // button_8
            // 
            this.button_8.AutoSize = true;
            this.button_8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_8.Location = new System.Drawing.Point(84, 247);
            this.button_8.Margin = new System.Windows.Forms.Padding(1);
            this.button_8.Name = "button_8";
            this.button_8.Size = new System.Drawing.Size(81, 76);
            this.button_8.TabIndex = 9;
            this.button_8.Text = "&8";
            this.button_8.UseVisualStyleBackColor = true;
            this.button_8.Click += new System.EventHandler(this.button_8_Click);
            // 
            // button_6
            // 
            this.button_6.AutoSize = true;
            this.button_6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_6.Location = new System.Drawing.Point(167, 325);
            this.button_6.Margin = new System.Windows.Forms.Padding(1);
            this.button_6.Name = "button_6";
            this.button_6.Size = new System.Drawing.Size(81, 76);
            this.button_6.TabIndex = 14;
            this.button_6.Text = "&6";
            this.button_6.UseVisualStyleBackColor = true;
            this.button_6.Click += new System.EventHandler(this.button_6_Click);
            // 
            // button_3
            // 
            this.button_3.AutoSize = true;
            this.button_3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_3.Location = new System.Drawing.Point(167, 403);
            this.button_3.Margin = new System.Windows.Forms.Padding(1);
            this.button_3.Name = "button_3";
            this.button_3.Size = new System.Drawing.Size(81, 76);
            this.button_3.TabIndex = 18;
            this.button_3.Text = "&3";
            this.button_3.UseVisualStyleBackColor = true;
            this.button_3.Click += new System.EventHandler(this.button_3_Click);
            // 
            // button_7
            // 
            this.button_7.AutoSize = true;
            this.button_7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_7.Location = new System.Drawing.Point(1, 247);
            this.button_7.Margin = new System.Windows.Forms.Padding(1);
            this.button_7.Name = "button_7";
            this.button_7.Size = new System.Drawing.Size(81, 76);
            this.button_7.TabIndex = 8;
            this.button_7.Text = "&7";
            this.button_7.UseVisualStyleBackColor = true;
            this.button_7.Click += new System.EventHandler(this.button_7_Click);
            // 
            // button_4
            // 
            this.button_4.AutoSize = true;
            this.button_4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_4.Location = new System.Drawing.Point(1, 325);
            this.button_4.Margin = new System.Windows.Forms.Padding(1);
            this.button_4.Name = "button_4";
            this.button_4.Size = new System.Drawing.Size(81, 76);
            this.button_4.TabIndex = 12;
            this.button_4.Text = "&4";
            this.button_4.UseVisualStyleBackColor = true;
            this.button_4.Click += new System.EventHandler(this.button_4_Click);
            // 
            // button_subtract
            // 
            this.button_subtract.AutoSize = true;
            this.button_subtract.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_subtract.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_subtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_subtract.Location = new System.Drawing.Point(250, 325);
            this.button_subtract.Margin = new System.Windows.Forms.Padding(1);
            this.button_subtract.Name = "button_subtract";
            this.button_subtract.Size = new System.Drawing.Size(81, 76);
            this.button_subtract.TabIndex = 15;
            this.button_subtract.Text = "&-";
            this.button_subtract.UseVisualStyleBackColor = true;
            this.button_subtract.Click += new System.EventHandler(this.button_subtract_Click);
            // 
            // button_multiply
            // 
            this.button_multiply.AutoSize = true;
            this.button_multiply.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_multiply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_multiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_multiply.Location = new System.Drawing.Point(250, 247);
            this.button_multiply.Margin = new System.Windows.Forms.Padding(1);
            this.button_multiply.Name = "button_multiply";
            this.button_multiply.Size = new System.Drawing.Size(81, 76);
            this.button_multiply.TabIndex = 11;
            this.button_multiply.Text = "&*";
            this.button_multiply.UseVisualStyleBackColor = true;
            this.button_multiply.Click += new System.EventHandler(this.button_multiply_Click);
            // 
            // button_divide
            // 
            this.button_divide.AutoSize = true;
            this.button_divide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_divide.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_divide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_divide.Location = new System.Drawing.Point(250, 169);
            this.button_divide.Margin = new System.Windows.Forms.Padding(1);
            this.button_divide.Name = "button_divide";
            this.button_divide.Size = new System.Drawing.Size(81, 76);
            this.button_divide.TabIndex = 7;
            this.button_divide.Text = "&/";
            this.button_divide.UseVisualStyleBackColor = true;
            this.button_divide.Click += new System.EventHandler(this.button_divide_Click);
            // 
            // button_add
            // 
            this.button_add.AutoSize = true;
            this.button_add.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(250, 403);
            this.button_add.Margin = new System.Windows.Forms.Padding(1);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(81, 76);
            this.button_add.TabIndex = 19;
            this.button_add.Text = "&+";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_delete
            // 
            this.button_delete.AutoSize = true;
            this.button_delete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_delete.Location = new System.Drawing.Point(250, 91);
            this.button_delete.Margin = new System.Windows.Forms.Padding(1);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(81, 76);
            this.button_delete.TabIndex = 3;
            this.button_delete.Text = "&⌫";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_C
            // 
            this.button_C.AutoSize = true;
            this.button_C.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_C.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_C.Location = new System.Drawing.Point(167, 91);
            this.button_C.Margin = new System.Windows.Forms.Padding(1);
            this.button_C.Name = "button_C";
            this.button_C.Size = new System.Drawing.Size(81, 76);
            this.button_C.TabIndex = 2;
            this.button_C.Text = "C";
            this.button_C.UseVisualStyleBackColor = true;
            this.button_C.Click += new System.EventHandler(this.button_C_Click);
            // 
            // button_CE
            // 
            this.button_CE.AutoSize = true;
            this.button_CE.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_CE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_CE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CE.Location = new System.Drawing.Point(84, 91);
            this.button_CE.Margin = new System.Windows.Forms.Padding(1);
            this.button_CE.Name = "button_CE";
            this.button_CE.Size = new System.Drawing.Size(81, 76);
            this.button_CE.TabIndex = 1;
            this.button_CE.Text = "CE";
            this.button_CE.UseVisualStyleBackColor = true;
            this.button_CE.Click += new System.EventHandler(this.button_CE_Click);
            // 
            // button_square
            // 
            this.button_square.AutoSize = true;
            this.button_square.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_square.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_square.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_square.Location = new System.Drawing.Point(84, 169);
            this.button_square.Margin = new System.Windows.Forms.Padding(1);
            this.button_square.Name = "button_square";
            this.button_square.Size = new System.Drawing.Size(81, 76);
            this.button_square.TabIndex = 5;
            this.button_square.Text = "x²";
            this.button_square.UseVisualStyleBackColor = true;
            this.button_square.Click += new System.EventHandler(this.button_square_Click);
            // 
            // button_square_root
            // 
            this.button_square_root.AutoSize = true;
            this.button_square_root.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_square_root.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_square_root.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_square_root.Location = new System.Drawing.Point(167, 169);
            this.button_square_root.Margin = new System.Windows.Forms.Padding(1);
            this.button_square_root.Name = "button_square_root";
            this.button_square_root.Size = new System.Drawing.Size(81, 76);
            this.button_square_root.TabIndex = 6;
            this.button_square_root.Text = "√";
            this.button_square_root.UseVisualStyleBackColor = true;
            this.button_square_root.Click += new System.EventHandler(this.button_square_root_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxBottom, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button_One_Over, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_Percent, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_CE, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_dot, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.button_plus_slash_minus, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.button_0, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.button_square, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_square_root, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_3, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_4, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_6, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_equal, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.button_7, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_add, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.button_5, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_delete, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_divide, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button_subtract, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_8, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_multiply, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_9, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_C, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 3);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1);
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
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxBottom, 4);
            this.textBoxBottom.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBottom.Location = new System.Drawing.Point(0, 45);
            this.textBoxBottom.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxBottom.Name = "textBoxBottom";
            this.textBoxBottom.ReadOnly = true;
            this.textBoxBottom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxBottom.Size = new System.Drawing.Size(332, 45);
            this.textBoxBottom.TabIndex = 33;
            this.textBoxBottom.TabStop = false;
            this.textBoxBottom.Text = "0";
            // 
            // button_One_Over
            // 
            this.button_One_Over.AutoSize = true;
            this.button_One_Over.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_One_Over.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_One_Over.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_One_Over.Location = new System.Drawing.Point(1, 169);
            this.button_One_Over.Margin = new System.Windows.Forms.Padding(1);
            this.button_One_Over.Name = "button_One_Over";
            this.button_One_Over.Size = new System.Drawing.Size(81, 76);
            this.button_One_Over.TabIndex = 4;
            this.button_One_Over.Text = "1/x";
            this.button_One_Over.UseVisualStyleBackColor = true;
            this.button_One_Over.Click += new System.EventHandler(this.button_One_Over_Click);
            // 
            // button_Percent
            // 
            this.button_Percent.AutoSize = true;
            this.button_Percent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_Percent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_Percent.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Percent.Location = new System.Drawing.Point(1, 91);
            this.button_Percent.Margin = new System.Windows.Forms.Padding(1);
            this.button_Percent.Name = "button_Percent";
            this.button_Percent.Size = new System.Drawing.Size(81, 76);
            this.button_Percent.TabIndex = 0;
            this.button_Percent.Text = "%";
            this.button_Percent.UseVisualStyleBackColor = true;
            this.button_Percent.Click += new System.EventHandler(this.button_Percent_Click);
            // 
            // button_dot
            // 
            this.button_dot.AutoSize = true;
            this.button_dot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_dot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_dot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dot.Location = new System.Drawing.Point(167, 481);
            this.button_dot.Margin = new System.Windows.Forms.Padding(1);
            this.button_dot.Name = "button_dot";
            this.button_dot.Size = new System.Drawing.Size(81, 76);
            this.button_dot.TabIndex = 22;
            this.button_dot.Text = "&.";
            this.button_dot.UseVisualStyleBackColor = true;
            this.button_dot.Click += new System.EventHandler(this.button_dot_Click);
            // 
            // button_plus_slash_minus
            // 
            this.button_plus_slash_minus.AutoSize = true;
            this.button_plus_slash_minus.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_plus_slash_minus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_plus_slash_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_plus_slash_minus.Location = new System.Drawing.Point(1, 481);
            this.button_plus_slash_minus.Margin = new System.Windows.Forms.Padding(1);
            this.button_plus_slash_minus.Name = "button_plus_slash_minus";
            this.button_plus_slash_minus.Size = new System.Drawing.Size(81, 76);
            this.button_plus_slash_minus.TabIndex = 20;
            this.button_plus_slash_minus.Text = "+/-";
            this.button_plus_slash_minus.UseVisualStyleBackColor = true;
            this.button_plus_slash_minus.Click += new System.EventHandler(this.button_Add_Slash_Minus_Click);
            // 
            // button_0
            // 
            this.button_0.AutoSize = true;
            this.button_0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_0.Location = new System.Drawing.Point(84, 481);
            this.button_0.Margin = new System.Windows.Forms.Padding(1);
            this.button_0.Name = "button_0";
            this.button_0.Size = new System.Drawing.Size(81, 76);
            this.button_0.TabIndex = 21;
            this.button_0.Text = "&0";
            this.button_0.UseVisualStyleBackColor = true;
            this.button_0.Click += new System.EventHandler(this.button_0_Click);
            // 
            // button_equal
            // 
            this.button_equal.AutoSize = true;
            this.button_equal.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button_equal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_equal.Location = new System.Drawing.Point(250, 481);
            this.button_equal.Margin = new System.Windows.Forms.Padding(1);
            this.button_equal.Name = "button_equal";
            this.button_equal.Size = new System.Drawing.Size(81, 76);
            this.button_equal.TabIndex = 23;
            this.button_equal.Text = "&=";
            this.button_equal.UseVisualStyleBackColor = true;
            this.button_equal.Click += new System.EventHandler(this.button_equal_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(350, 600);
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(Calculator_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTop;
        private System.Windows.Forms.Button button_1;
        private System.Windows.Forms.Button button_5;
        private System.Windows.Forms.Button button_2;
        private System.Windows.Forms.Button button_9;
        private System.Windows.Forms.Button button_8;
        private System.Windows.Forms.Button button_6;
        private System.Windows.Forms.Button button_3;
        private System.Windows.Forms.Button button_7;
        private System.Windows.Forms.Button button_4;
        private System.Windows.Forms.Button button_subtract;
        private System.Windows.Forms.Button button_multiply;
        private System.Windows.Forms.Button button_divide;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_C;
        private System.Windows.Forms.Button button_CE;
        private System.Windows.Forms.Button button_square;
        private System.Windows.Forms.Button button_square_root;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_dot;
        private System.Windows.Forms.Button button_plus_slash_minus;
        private System.Windows.Forms.Button button_0;
        private System.Windows.Forms.Button button_equal;
        private System.Windows.Forms.Button button_Percent;
        private System.Windows.Forms.Button button_One_Over;
        private System.Windows.Forms.TextBox textBoxBottom;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

