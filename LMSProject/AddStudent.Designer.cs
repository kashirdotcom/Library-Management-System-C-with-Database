﻿namespace LMSProject
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.circularPicture1 = new LMSProject.CircularPicture();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtstSemester = new System.Windows.Forms.TextBox();
            this.btnStInfoRefrsh = new FlatButton.JFlatButton();
            this.btnSaveStInfo = new FlatButton.JFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtstEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtstContact = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtstDepartment = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtstNumber = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtstName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.circularPicture1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1076, 105);
            this.panel1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(-2, 98);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 130);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-2, 98);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1083, 131);
            this.panel2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(591, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // circularPicture1
            // 
            this.circularPicture1.Image = ((System.Drawing.Image)(resources.GetObject("circularPicture1.Image")));
            this.circularPicture1.Location = new System.Drawing.Point(1004, 18);
            this.circularPicture1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.circularPicture1.Name = "circularPicture1";
            this.circularPicture1.Size = new System.Drawing.Size(64, 74);
            this.circularPicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.circularPicture1.TabIndex = 8;
            this.circularPicture1.TabStop = false;
            this.circularPicture1.Click += new System.EventHandler(this.circularPicture1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 39);
            this.label2.TabIndex = 6;
            this.label2.Text = "Add  Student";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.panel11);
            this.panel5.Controls.Add(this.txtstSemester);
            this.panel5.Controls.Add(this.btnStInfoRefrsh);
            this.panel5.Controls.Add(this.btnSaveStInfo);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.panel9);
            this.panel5.Controls.Add(this.txtstEmail);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.panel10);
            this.panel5.Controls.Add(this.txtstContact);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.txtstDepartment);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.txtstNumber);
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.txtstName);
            this.panel5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel5.Location = new System.Drawing.Point(18, 258);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1013, 334);
            this.panel5.TabIndex = 17;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel11.Location = new System.Drawing.Point(770, 66);
            this.panel11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(218, 3);
            this.panel11.TabIndex = 33;
            // 
            // txtstSemester
            // 
            this.txtstSemester.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtstSemester.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstSemester.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtstSemester.Location = new System.Drawing.Point(770, 32);
            this.txtstSemester.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstSemester.Name = "txtstSemester";
            this.txtstSemester.Size = new System.Drawing.Size(216, 31);
            this.txtstSemester.TabIndex = 32;
            // 
            // btnStInfoRefrsh
            // 
            this.btnStInfoRefrsh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStInfoRefrsh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnStInfoRefrsh.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.btnStInfoRefrsh.ButtonText = "Refresh";
            this.btnStInfoRefrsh.CausesValidation = false;
            this.btnStInfoRefrsh.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnStInfoRefrsh.ErrorImageLeft")));
            this.btnStInfoRefrsh.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnStInfoRefrsh.ErrorImageRight")));
            this.btnStInfoRefrsh.FocusBackground = System.Drawing.Color.Empty;
            this.btnStInfoRefrsh.FocusFontColor = System.Drawing.Color.Empty;
            this.btnStInfoRefrsh.ForeColors = System.Drawing.Color.White;
            this.btnStInfoRefrsh.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnStInfoRefrsh.HoverFontColor = System.Drawing.Color.White;
            this.btnStInfoRefrsh.ImageLeft = null;
            this.btnStInfoRefrsh.ImageRight = null;
            this.btnStInfoRefrsh.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnStInfoRefrsh.Location = new System.Drawing.Point(884, 248);
            this.btnStInfoRefrsh.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnStInfoRefrsh.Name = "btnStInfoRefrsh";
            this.btnStInfoRefrsh.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnStInfoRefrsh.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnStInfoRefrsh.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnStInfoRefrsh.Size = new System.Drawing.Size(104, 42);
            this.btnStInfoRefrsh.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnStInfoRefrsh.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnStInfoRefrsh.TabIndex = 31;
            this.btnStInfoRefrsh.Click += new System.EventHandler(this.btnStInfoRefrsh_Click);
            // 
            // btnSaveStInfo
            // 
            this.btnSaveStInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveStInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveStInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSaveStInfo.ButtonText = "Save Info";
            this.btnSaveStInfo.CausesValidation = false;
            this.btnSaveStInfo.ErrorImageLeft = ((System.Drawing.Image)(resources.GetObject("btnSaveStInfo.ErrorImageLeft")));
            this.btnSaveStInfo.ErrorImageRight = ((System.Drawing.Image)(resources.GetObject("btnSaveStInfo.ErrorImageRight")));
            this.btnSaveStInfo.FocusBackground = System.Drawing.Color.Empty;
            this.btnSaveStInfo.FocusFontColor = System.Drawing.Color.Empty;
            this.btnSaveStInfo.ForeColors = System.Drawing.Color.White;
            this.btnSaveStInfo.HoverBackground = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.btnSaveStInfo.HoverFontColor = System.Drawing.Color.White;
            this.btnSaveStInfo.ImageLeft = null;
            this.btnSaveStInfo.ImageRight = null;
            this.btnSaveStInfo.LeftPictureColor = System.Drawing.Color.Transparent;
            this.btnSaveStInfo.Location = new System.Drawing.Point(729, 248);
            this.btnSaveStInfo.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.btnSaveStInfo.Name = "btnSaveStInfo";
            this.btnSaveStInfo.PaddingLeftPicture = new System.Windows.Forms.Padding(0);
            this.btnSaveStInfo.PaddingRightPicture = new System.Windows.Forms.Padding(0);
            this.btnSaveStInfo.RightPictureColor = System.Drawing.Color.Transparent;
            this.btnSaveStInfo.Size = new System.Drawing.Size(129, 42);
            this.btnSaveStInfo.SizeModeLeft = System.Windows.Forms.PictureBoxSizeMode.Normal;
            this.btnSaveStInfo.SizeModeRight = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnSaveStInfo.TabIndex = 31;
            this.btnSaveStInfo.Click += new System.EventHandler(this.btnSaveStInfo_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(528, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 29);
            this.label7.TabIndex = 29;
            this.label7.Text = "Student Email";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel9.Location = new System.Drawing.Point(770, 214);
            this.panel9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(218, 3);
            this.panel9.TabIndex = 28;
            // 
            // txtstEmail
            // 
            this.txtstEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtstEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtstEmail.Location = new System.Drawing.Point(770, 180);
            this.txtstEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstEmail.Name = "txtstEmail";
            this.txtstEmail.Size = new System.Drawing.Size(216, 31);
            this.txtstEmail.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(528, 105);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 29);
            this.label8.TabIndex = 26;
            this.label8.Text = "Student Contact";
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel10.Location = new System.Drawing.Point(770, 138);
            this.panel10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(218, 3);
            this.panel10.TabIndex = 25;
            // 
            // txtstContact
            // 
            this.txtstContact.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtstContact.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstContact.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtstContact.Location = new System.Drawing.Point(770, 105);
            this.txtstContact.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstContact.Name = "txtstContact";
            this.txtstContact.Size = new System.Drawing.Size(216, 31);
            this.txtstContact.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(528, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 29);
            this.label9.TabIndex = 23;
            this.label9.Text = "Student Semester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 183);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Department\r\n";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel6.Location = new System.Drawing.Point(260, 212);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(218, 3);
            this.panel6.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Student Number";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel7.Location = new System.Drawing.Point(260, 137);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(218, 3);
            this.panel7.TabIndex = 17;
            // 
            // txtstDepartment
            // 
            this.txtstDepartment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtstDepartment.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstDepartment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtstDepartment.Location = new System.Drawing.Point(260, 178);
            this.txtstDepartment.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstDepartment.Name = "txtstDepartment";
            this.txtstDepartment.Size = new System.Drawing.Size(216, 31);
            this.txtstDepartment.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(103)))), ((int)(((byte)(178)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Student Name";
            // 
            // txtstNumber
            // 
            this.txtstNumber.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtstNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtstNumber.Location = new System.Drawing.Point(260, 103);
            this.txtstNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstNumber.Name = "txtstNumber";
            this.txtstNumber.Size = new System.Drawing.Size(216, 31);
            this.txtstNumber.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.panel8.Location = new System.Drawing.Point(260, 66);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(218, 3);
            this.panel8.TabIndex = 18;
            // 
            // txtstName
            // 
            this.txtstName.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtstName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(36)))), ((int)(((byte)(55)))));
            this.txtstName.Location = new System.Drawing.Point(260, 32);
            this.txtstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtstName.Name = "txtstName";
            this.txtstName.Size = new System.Drawing.Size(216, 31);
            this.txtstName.TabIndex = 15;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 666);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStudent";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.circularPicture1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private CircularPicture circularPicture1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtstSemester;
        private FlatButton.JFlatButton btnStInfoRefrsh;
        private FlatButton.JFlatButton btnSaveStInfo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtstEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtstContact;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtstDepartment;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtstNumber;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtstName;
    }
}