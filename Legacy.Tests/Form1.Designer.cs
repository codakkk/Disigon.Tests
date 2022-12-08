namespace Cyberneid.Disigon.Legacy.Tests
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
            this.signTextButton = new System.Windows.Forms.Button();
            this.textToSign = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxAddCA = new System.Windows.Forms.CheckBox();
            this.checkBoxTimeStamp = new System.Windows.Forms.CheckBox();
            this.checkBoxMultisignature = new System.Windows.Forms.CheckBox();
            this.browse = new System.Windows.Forms.Button();
            this.signFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fileToSign = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkBoxPDFAddCA = new System.Windows.Forms.CheckBox();
            this.checkBoxPDFTimeStamp = new System.Windows.Forms.CheckBox();
            this.checkBoxPDFLTV = new System.Windows.Forms.CheckBox();
            this.browsePDFButton = new System.Windows.Forms.Button();
            this.signPDF = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxToSignPDF = new System.Windows.Forms.TextBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxCRL = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.verifyButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxFileToVerify = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxP11 = new System.Windows.Forms.TextBox();
            this.browseP11 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPIN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxPDFToVerify = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBoxPDFCRL = new System.Windows.Forms.CheckBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // signTextButton
            // 
            this.signTextButton.Location = new System.Drawing.Point(83, 172);
            this.signTextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signTextButton.Name = "signTextButton";
            this.signTextButton.Size = new System.Drawing.Size(100, 35);
            this.signTextButton.TabIndex = 1;
            this.signTextButton.Text = "Sign";
            this.signTextButton.UseVisualStyleBackColor = true;
            this.signTextButton.Click += new System.EventHandler(this.signTextButton_Click);
            // 
            // textToSign
            // 
            this.textToSign.Location = new System.Drawing.Point(10, 59);
            this.textToSign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textToSign.Multiline = true;
            this.textToSign.Name = "textToSign";
            this.textToSign.Size = new System.Drawing.Size(249, 103);
            this.textToSign.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Text to Sign";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.signTextButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textToSign);
            this.groupBox1.Location = new System.Drawing.Point(16, 192);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(267, 211);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Digital Signature";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxAddCA);
            this.groupBox2.Controls.Add(this.checkBoxTimeStamp);
            this.groupBox2.Controls.Add(this.checkBoxMultisignature);
            this.groupBox2.Controls.Add(this.browse);
            this.groupBox2.Controls.Add(this.signFileButton);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.fileToSign);
            this.groupBox2.Location = new System.Drawing.Point(303, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(267, 222);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Digital Signature on a File";
            // 
            // checkBoxAddCA
            // 
            this.checkBoxAddCA.AutoSize = true;
            this.checkBoxAddCA.Location = new System.Drawing.Point(8, 160);
            this.checkBoxAddCA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxAddCA.Name = "checkBoxAddCA";
            this.checkBoxAddCA.Size = new System.Drawing.Size(111, 24);
            this.checkBoxAddCA.TabIndex = 8;
            this.checkBoxAddCA.Text = "Add CA cert";
            this.checkBoxAddCA.UseVisualStyleBackColor = true;
            // 
            // checkBoxTimeStamp
            // 
            this.checkBoxTimeStamp.AutoSize = true;
            this.checkBoxTimeStamp.Location = new System.Drawing.Point(8, 134);
            this.checkBoxTimeStamp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxTimeStamp.Name = "checkBoxTimeStamp";
            this.checkBoxTimeStamp.Size = new System.Drawing.Size(107, 24);
            this.checkBoxTimeStamp.TabIndex = 7;
            this.checkBoxTimeStamp.Text = "TimeStamp";
            this.checkBoxTimeStamp.UseVisualStyleBackColor = true;
            // 
            // checkBoxMultisignature
            // 
            this.checkBoxMultisignature.AutoSize = true;
            this.checkBoxMultisignature.Location = new System.Drawing.Point(8, 108);
            this.checkBoxMultisignature.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxMultisignature.Name = "checkBoxMultisignature";
            this.checkBoxMultisignature.Size = new System.Drawing.Size(126, 24);
            this.checkBoxMultisignature.TabIndex = 6;
            this.checkBoxMultisignature.Text = "Multisignature";
            this.checkBoxMultisignature.UseVisualStyleBackColor = true;
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(180, 69);
            this.browse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(77, 35);
            this.browse.TabIndex = 4;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_Click);
            // 
            // signFileButton
            // 
            this.signFileButton.Location = new System.Drawing.Point(180, 129);
            this.signFileButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signFileButton.Name = "signFileButton";
            this.signFileButton.Size = new System.Drawing.Size(77, 35);
            this.signFileButton.TabIndex = 1;
            this.signFileButton.Text = "Sign";
            this.signFileButton.UseVisualStyleBackColor = true;
            this.signFileButton.Click += new System.EventHandler(this.signFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "File to Sign";
            // 
            // fileToSign
            // 
            this.fileToSign.Location = new System.Drawing.Point(8, 68);
            this.fileToSign.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fileToSign.Multiline = true;
            this.fileToSign.Name = "fileToSign";
            this.fileToSign.Size = new System.Drawing.Size(163, 35);
            this.fileToSign.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkBoxPDFAddCA);
            this.groupBox3.Controls.Add(this.checkBoxPDFTimeStamp);
            this.groupBox3.Controls.Add(this.checkBoxPDFLTV);
            this.groupBox3.Controls.Add(this.browsePDFButton);
            this.groupBox3.Controls.Add(this.signPDF);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.textBoxToSignPDF);
            this.groupBox3.Location = new System.Drawing.Point(592, 19);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(267, 212);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "PDF Digital Signature";
            // 
            // checkBoxPDFAddCA
            // 
            this.checkBoxPDFAddCA.AutoSize = true;
            this.checkBoxPDFAddCA.Location = new System.Drawing.Point(8, 165);
            this.checkBoxPDFAddCA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPDFAddCA.Name = "checkBoxPDFAddCA";
            this.checkBoxPDFAddCA.Size = new System.Drawing.Size(111, 24);
            this.checkBoxPDFAddCA.TabIndex = 11;
            this.checkBoxPDFAddCA.Text = "Add CA cert";
            this.checkBoxPDFAddCA.UseVisualStyleBackColor = true;
            // 
            // checkBoxPDFTimeStamp
            // 
            this.checkBoxPDFTimeStamp.AutoSize = true;
            this.checkBoxPDFTimeStamp.Location = new System.Drawing.Point(8, 136);
            this.checkBoxPDFTimeStamp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPDFTimeStamp.Name = "checkBoxPDFTimeStamp";
            this.checkBoxPDFTimeStamp.Size = new System.Drawing.Size(107, 24);
            this.checkBoxPDFTimeStamp.TabIndex = 10;
            this.checkBoxPDFTimeStamp.Text = "TimeStamp";
            this.checkBoxPDFTimeStamp.UseVisualStyleBackColor = true;
            // 
            // checkBoxPDFLTV
            // 
            this.checkBoxPDFLTV.AutoSize = true;
            this.checkBoxPDFLTV.Location = new System.Drawing.Point(8, 109);
            this.checkBoxPDFLTV.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPDFLTV.Name = "checkBoxPDFLTV";
            this.checkBoxPDFLTV.Size = new System.Drawing.Size(54, 24);
            this.checkBoxPDFLTV.TabIndex = 8;
            this.checkBoxPDFLTV.Text = "LTV";
            this.checkBoxPDFLTV.UseVisualStyleBackColor = true;
            // 
            // browsePDFButton
            // 
            this.browsePDFButton.Location = new System.Drawing.Point(180, 69);
            this.browsePDFButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browsePDFButton.Name = "browsePDFButton";
            this.browsePDFButton.Size = new System.Drawing.Size(77, 35);
            this.browsePDFButton.TabIndex = 4;
            this.browsePDFButton.Text = "Browse";
            this.browsePDFButton.UseVisualStyleBackColor = true;
            this.browsePDFButton.Click += new System.EventHandler(this.browsePDFButton_Click);
            // 
            // signPDF
            // 
            this.signPDF.Location = new System.Drawing.Point(180, 129);
            this.signPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signPDF.Name = "signPDF";
            this.signPDF.Size = new System.Drawing.Size(77, 35);
            this.signPDF.TabIndex = 1;
            this.signPDF.Text = "Sign";
            this.signPDF.UseVisualStyleBackColor = true;
            this.signPDF.Click += new System.EventHandler(this.signPDF_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "PDF to Sign";
            // 
            // textBoxToSignPDF
            // 
            this.textBoxToSignPDF.Location = new System.Drawing.Point(8, 68);
            this.textBoxToSignPDF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxToSignPDF.Multiline = true;
            this.textBoxToSignPDF.Name = "textBoxToSignPDF";
            this.textBoxToSignPDF.Size = new System.Drawing.Size(163, 35);
            this.textBoxToSignPDF.TabIndex = 2;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(786, 431);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(100, 35);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxCRL);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.verifyButton);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.textBoxFileToVerify);
            this.groupBox4.Location = new System.Drawing.Point(303, 251);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(267, 151);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Verify Digital Signature on a File";
            // 
            // checkBoxCRL
            // 
            this.checkBoxCRL.AutoSize = true;
            this.checkBoxCRL.Location = new System.Drawing.Point(8, 120);
            this.checkBoxCRL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxCRL.Name = "checkBoxCRL";
            this.checkBoxCRL.Size = new System.Drawing.Size(98, 24);
            this.checkBoxCRL.TabIndex = 8;
            this.checkBoxCRL.Text = "CRL/OCSP";
            this.checkBoxCRL.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 69);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // verifyButton
            // 
            this.verifyButton.Location = new System.Drawing.Point(180, 116);
            this.verifyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(77, 35);
            this.verifyButton.TabIndex = 1;
            this.verifyButton.Text = "Verify";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "File to Verify";
            // 
            // textBoxFileToVerify
            // 
            this.textBoxFileToVerify.Location = new System.Drawing.Point(8, 68);
            this.textBoxFileToVerify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxFileToVerify.Multiline = true;
            this.textBoxFileToVerify.Name = "textBoxFileToVerify";
            this.textBoxFileToVerify.Size = new System.Drawing.Size(163, 35);
            this.textBoxFileToVerify.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "PKCS#11 module";
            // 
            // textBoxP11
            // 
            this.textBoxP11.Location = new System.Drawing.Point(26, 81);
            this.textBoxP11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxP11.Multiline = true;
            this.textBoxP11.Name = "textBoxP11";
            this.textBoxP11.Size = new System.Drawing.Size(163, 35);
            this.textBoxP11.TabIndex = 8;
            this.textBoxP11.Text = "bit4xpki";
            // 
            // browseP11
            // 
            this.browseP11.Location = new System.Drawing.Point(198, 82);
            this.browseP11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseP11.Name = "browseP11";
            this.browseP11.Size = new System.Drawing.Size(77, 35);
            this.browseP11.TabIndex = 8;
            this.browseP11.Text = "Browse";
            this.browseP11.UseVisualStyleBackColor = true;
            this.browseP11.Click += new System.EventHandler(this.browseP11_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 122);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "PIN";
            // 
            // textBoxPIN
            // 
            this.textBoxPIN.Location = new System.Drawing.Point(26, 146);
            this.textBoxPIN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPIN.Multiline = true;
            this.textBoxPIN.Name = "textBoxPIN";
            this.textBoxPIN.Size = new System.Drawing.Size(249, 35);
            this.textBoxPIN.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(180, 69);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(77, 35);
            this.button2.TabIndex = 4;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxPDFToVerify
            // 
            this.textBoxPDFToVerify.Location = new System.Drawing.Point(8, 68);
            this.textBoxPDFToVerify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxPDFToVerify.Multiline = true;
            this.textBoxPDFToVerify.Name = "textBoxPDFToVerify";
            this.textBoxPDFToVerify.Size = new System.Drawing.Size(163, 35);
            this.textBoxPDFToVerify.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBoxPDFCRL);
            this.groupBox5.Controls.Add(this.button2);
            this.groupBox5.Controls.Add(this.button3);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBoxPDFToVerify);
            this.groupBox5.Location = new System.Drawing.Point(592, 246);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox5.Size = new System.Drawing.Size(267, 151);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Verify PDF Digital Signature on a File";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // checkBoxPDFCRL
            // 
            this.checkBoxPDFCRL.AutoSize = true;
            this.checkBoxPDFCRL.Location = new System.Drawing.Point(8, 120);
            this.checkBoxPDFCRL.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBoxPDFCRL.Name = "checkBoxPDFCRL";
            this.checkBoxPDFCRL.Size = new System.Drawing.Size(98, 24);
            this.checkBoxPDFCRL.TabIndex = 8;
            this.checkBoxPDFCRL.Text = "CRL/OCSP";
            this.checkBoxPDFCRL.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(180, 116);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(77, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Verify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 39);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "PDF to Verify";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 470);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPIN);
            this.Controls.Add(this.browseP11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxP11);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = ".NET Framework 4.8: NDigitSign Full Test and Example";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signTextButton;
        private System.Windows.Forms.TextBox textToSign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.Button signFileButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fileToSign;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button browsePDFButton;
        private System.Windows.Forms.Button signPDF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxToSignPDF;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxFileToVerify;
        private System.Windows.Forms.CheckBox checkBoxMultisignature;
        private System.Windows.Forms.CheckBox checkBoxTimeStamp;
        private System.Windows.Forms.CheckBox checkBoxPDFTimeStamp;
        private System.Windows.Forms.CheckBox checkBoxPDFLTV;
        private System.Windows.Forms.CheckBox checkBoxCRL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxP11;
        private System.Windows.Forms.Button browseP11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxPIN;
        private System.Windows.Forms.CheckBox checkBoxAddCA;
        private System.Windows.Forms.CheckBox checkBoxPDFAddCA;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxPDFToVerify;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBoxPDFCRL;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;

    }
}

