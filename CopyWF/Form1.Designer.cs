using System;
using System.IO;
using System.Text.RegularExpressions;

namespace CopyWF
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Save = new System.Windows.Forms.Button();
            this.SelTargetPath1 = new System.Windows.Forms.Button();
            this.Copy1 = new System.Windows.Forms.Button();
            this.SelSourcePath1 = new System.Windows.Forms.Button();
            this.SelTargetPath3 = new System.Windows.Forms.Button();
            this.Copy3 = new System.Windows.Forms.Button();
            this.SelSourcePath3 = new System.Windows.Forms.Button();
            this.SelTargetPath2 = new System.Windows.Forms.Button();
            this.Copy2 = new System.Windows.Forms.Button();
            this.SelSourcePath2 = new System.Windows.Forms.Button();
            this.TargetPath1 = new System.Windows.Forms.TextBox();
            this.TargetPath3 = new System.Windows.Forms.TextBox();
            this.SourcePath1 = new System.Windows.Forms.TextBox();
            this.TargetPath2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SourcePath3 = new System.Windows.Forms.TextBox();
            this.SourcePath2 = new System.Windows.Forms.TextBox();
            this.checkDLL = new System.Windows.Forms.CheckBox();
            this.checkEXE = new System.Windows.Forms.CheckBox();
            this.checkAll = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.USB2 = new System.Windows.Forms.CheckBox();
            this.USB1 = new System.Windows.Forms.CheckBox();
            this.USB3 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Save
            // 
            this.Save.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Save.Location = new System.Drawing.Point(57, 236);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(59, 22);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // SelTargetPath1
            // 
            this.SelTargetPath1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelTargetPath1.Location = new System.Drawing.Point(564, 45);
            this.SelTargetPath1.Name = "SelTargetPath1";
            this.SelTargetPath1.Size = new System.Drawing.Size(51, 25);
            this.SelTargetPath1.TabIndex = 22;
            this.SelTargetPath1.Text = "Select";
            this.SelTargetPath1.UseVisualStyleBackColor = true;
            this.SelTargetPath1.Click += new System.EventHandler(this.SelTargetPath1_Click);
            // 
            // Copy1
            // 
            this.Copy1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Copy1.Location = new System.Drawing.Point(633, 13);
            this.Copy1.Name = "Copy1";
            this.Copy1.Size = new System.Drawing.Size(60, 56);
            this.Copy1.TabIndex = 21;
            this.Copy1.Text = "Copy";
            this.Copy1.UseVisualStyleBackColor = true;
            this.Copy1.Click += new System.EventHandler(this.Copy1_Click);
            // 
            // SelSourcePath1
            // 
            this.SelSourcePath1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelSourcePath1.Location = new System.Drawing.Point(564, 13);
            this.SelSourcePath1.Name = "SelSourcePath1";
            this.SelSourcePath1.Size = new System.Drawing.Size(50, 26);
            this.SelSourcePath1.TabIndex = 19;
            this.SelSourcePath1.Text = "Select";
            this.SelSourcePath1.UseVisualStyleBackColor = true;
            this.SelSourcePath1.Click += new System.EventHandler(this.SelSourcePath1_Click);
            // 
            // SelTargetPath3
            // 
            this.SelTargetPath3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelTargetPath3.Location = new System.Drawing.Point(562, 204);
            this.SelTargetPath3.Name = "SelTargetPath3";
            this.SelTargetPath3.Size = new System.Drawing.Size(51, 25);
            this.SelTargetPath3.TabIndex = 28;
            this.SelTargetPath3.Text = "Select";
            this.SelTargetPath3.UseVisualStyleBackColor = true;
            this.SelTargetPath3.Click += new System.EventHandler(this.SelTargetPath3_Click);
            // 
            // Copy3
            // 
            this.Copy3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Copy3.Location = new System.Drawing.Point(633, 172);
            this.Copy3.Name = "Copy3";
            this.Copy3.Size = new System.Drawing.Size(60, 57);
            this.Copy3.TabIndex = 27;
            this.Copy3.Text = "Copy";
            this.Copy3.UseVisualStyleBackColor = true;
            this.Copy3.Click += new System.EventHandler(this.Copy3_Click);
            // 
            // SelSourcePath3
            // 
            this.SelSourcePath3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelSourcePath3.Location = new System.Drawing.Point(563, 172);
            this.SelSourcePath3.Name = "SelSourcePath3";
            this.SelSourcePath3.Size = new System.Drawing.Size(50, 26);
            this.SelSourcePath3.TabIndex = 25;
            this.SelSourcePath3.Text = "Select";
            this.SelSourcePath3.UseVisualStyleBackColor = true;
            this.SelSourcePath3.Click += new System.EventHandler(this.SelSourcePath3_Click);
            // 
            // SelTargetPath2
            // 
            this.SelTargetPath2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelTargetPath2.Location = new System.Drawing.Point(563, 123);
            this.SelTargetPath2.Name = "SelTargetPath2";
            this.SelTargetPath2.Size = new System.Drawing.Size(51, 25);
            this.SelTargetPath2.TabIndex = 34;
            this.SelTargetPath2.Text = "Select";
            this.SelTargetPath2.UseVisualStyleBackColor = true;
            this.SelTargetPath2.Click += new System.EventHandler(this.SelTargetPath2_Click);
            // 
            // Copy2
            // 
            this.Copy2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Copy2.Location = new System.Drawing.Point(633, 86);
            this.Copy2.Name = "Copy2";
            this.Copy2.Size = new System.Drawing.Size(60, 64);
            this.Copy2.TabIndex = 33;
            this.Copy2.Text = "Copy";
            this.Copy2.UseVisualStyleBackColor = true;
            this.Copy2.Click += new System.EventHandler(this.Copy2_Click);
            // 
            // SelSourcePath2
            // 
            this.SelSourcePath2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SelSourcePath2.Location = new System.Drawing.Point(564, 86);
            this.SelSourcePath2.Name = "SelSourcePath2";
            this.SelSourcePath2.Size = new System.Drawing.Size(50, 26);
            this.SelSourcePath2.TabIndex = 31;
            this.SelSourcePath2.Text = "Select";
            this.SelSourcePath2.UseVisualStyleBackColor = true;
            this.SelSourcePath2.Click += new System.EventHandler(this.SelSourcePath2_Click);
            // 
            // TargetPath1
            // 
            this.TargetPath1.Location = new System.Drawing.Point(57, 49);
            this.TargetPath1.Name = "TargetPath1";
            this.TargetPath1.Size = new System.Drawing.Size(490, 21);
            this.TargetPath1.TabIndex = 39;
            // 
            // TargetPath3
            // 
            this.TargetPath3.Location = new System.Drawing.Point(57, 204);
            this.TargetPath3.Name = "TargetPath3";
            this.TargetPath3.Size = new System.Drawing.Size(490, 21);
            this.TargetPath3.TabIndex = 46;
            // 
            // SourcePath1
            // 
            this.SourcePath1.Location = new System.Drawing.Point(57, 17);
            this.SourcePath1.Name = "SourcePath1";
            this.SourcePath1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SourcePath1.Size = new System.Drawing.Size(490, 21);
            this.SourcePath1.TabIndex = 45;
            // 
            // TargetPath2
            // 
            this.TargetPath2.Location = new System.Drawing.Point(57, 126);
            this.TargetPath2.Name = "TargetPath2";
            this.TargetPath2.Size = new System.Drawing.Size(490, 21);
            this.TargetPath2.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 264);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(325, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(325, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 41;
            // 
            // SourcePath3
            // 
            this.SourcePath3.Location = new System.Drawing.Point(57, 172);
            this.SourcePath3.Name = "SourcePath3";
            this.SourcePath3.Size = new System.Drawing.Size(490, 21);
            this.SourcePath3.TabIndex = 47;
            // 
            // SourcePath2
            // 
            this.SourcePath2.Location = new System.Drawing.Point(57, 92);
            this.SourcePath2.Name = "SourcePath2";
            this.SourcePath2.Size = new System.Drawing.Size(490, 21);
            this.SourcePath2.TabIndex = 48;
            // 
            // checkDLL
            // 
            this.checkDLL.AutoSize = true;
            this.checkDLL.Location = new System.Drawing.Point(131, 241);
            this.checkDLL.Name = "checkDLL";
            this.checkDLL.Size = new System.Drawing.Size(54, 16);
            this.checkDLL.TabIndex = 49;
            this.checkDLL.Text = "*.dll";
            this.checkDLL.UseVisualStyleBackColor = true;
            this.checkDLL.CheckedChanged += new System.EventHandler(this.checkDLL_CheckedChanged);
            // 
            // checkEXE
            // 
            this.checkEXE.AutoSize = true;
            this.checkEXE.Location = new System.Drawing.Point(191, 241);
            this.checkEXE.Name = "checkEXE";
            this.checkEXE.Size = new System.Drawing.Size(54, 16);
            this.checkEXE.TabIndex = 50;
            this.checkEXE.Text = "*.exe";
            this.checkEXE.UseVisualStyleBackColor = true;
            this.checkEXE.CheckedChanged += new System.EventHandler(this.checkEXE_CheckedChanged);
            // 
            // checkAll
            // 
            this.checkAll.AutoSize = true;
            this.checkAll.Location = new System.Drawing.Point(251, 242);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(42, 16);
            this.checkAll.TabIndex = 51;
            this.checkAll.Text = "*.*";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.CheckedChanged += new System.EventHandler(this.checkAll_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 12);
            this.label7.TabIndex = 52;
            // 
            // USB2
            // 
            this.USB2.AutoSize = true;
            this.USB2.Location = new System.Drawing.Point(9, 129);
            this.USB2.Name = "USB2";
            this.USB2.Size = new System.Drawing.Size(42, 16);
            this.USB2.TabIndex = 53;
            this.USB2.Text = "USB";
            this.USB2.UseVisualStyleBackColor = true;
            // 
            // USB1
            // 
            this.USB1.AutoSize = true;
            this.USB1.Location = new System.Drawing.Point(9, 51);
            this.USB1.Name = "USB1";
            this.USB1.Size = new System.Drawing.Size(42, 16);
            this.USB1.TabIndex = 54;
            this.USB1.Text = "USB";
            this.USB1.UseVisualStyleBackColor = true;
            // 
            // USB3
            // 
            this.USB3.AutoSize = true;
            this.USB3.Location = new System.Drawing.Point(9, 206);
            this.USB3.Name = "USB3";
            this.USB3.Size = new System.Drawing.Size(42, 16);
            this.USB3.TabIndex = 55;
            this.USB3.Text = "USB";
            this.USB3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 299);
            this.Controls.Add(this.USB3);
            this.Controls.Add(this.USB1);
            this.Controls.Add(this.USB2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.checkEXE);
            this.Controls.Add(this.checkDLL);
            this.Controls.Add(this.SourcePath2);
            this.Controls.Add(this.SourcePath3);
            this.Controls.Add(this.TargetPath3);
            this.Controls.Add(this.SourcePath1);
            this.Controls.Add(this.TargetPath2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TargetPath1);
            this.Controls.Add(this.SelTargetPath2);
            this.Controls.Add(this.Copy2);
            this.Controls.Add(this.SelSourcePath2);
            this.Controls.Add(this.SelTargetPath3);
            this.Controls.Add(this.Copy3);
            this.Controls.Add(this.SelSourcePath3);
            this.Controls.Add(this.SelTargetPath1);
            this.Controls.Add(this.Copy1);
            this.Controls.Add(this.SelSourcePath1);
            this.Controls.Add(this.Save);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "CopyAuto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button SelTargetPath1;
        private System.Windows.Forms.Button Copy1;
        private System.Windows.Forms.Button SelSourcePath1;
        private System.Windows.Forms.Button SelTargetPath3;
        private System.Windows.Forms.Button Copy3;
        private System.Windows.Forms.Button SelSourcePath3;
        private System.Windows.Forms.Button SelTargetPath2;
        private System.Windows.Forms.Button Copy2;
        private System.Windows.Forms.Button SelSourcePath2;
        private System.Windows.Forms.TextBox TargetPath1;
        private System.Windows.Forms.TextBox TargetPath3;
        private System.Windows.Forms.TextBox SourcePath1;
        private System.Windows.Forms.TextBox TargetPath2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox SourcePath3;
        private System.Windows.Forms.TextBox SourcePath2;
        private System.Windows.Forms.CheckBox checkDLL;
        private System.Windows.Forms.CheckBox checkEXE;
        private System.Windows.Forms.CheckBox checkAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox USB2;
        private System.Windows.Forms.CheckBox USB1;
        private System.Windows.Forms.CheckBox USB3;
    }
}

