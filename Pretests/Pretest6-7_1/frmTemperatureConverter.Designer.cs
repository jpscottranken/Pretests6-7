﻿namespace Pretest6_7_1
{
    partial class frmTemperatureConverter
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
            this.btnConvertFToC = new System.Windows.Forms.Button();
            this.btnConvertCToF = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblFahrTemp = new System.Windows.Forms.Label();
            this.lblCelTemp = new System.Windows.Forms.Label();
            this.txtFahrTemp = new System.Windows.Forms.TextBox();
            this.txtCelTemp = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConvertFToC
            // 
            this.btnConvertFToC.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertFToC.Location = new System.Drawing.Point(137, 206);
            this.btnConvertFToC.Name = "btnConvertFToC";
            this.btnConvertFToC.Size = new System.Drawing.Size(193, 58);
            this.btnConvertFToC.TabIndex = 2;
            this.btnConvertFToC.Text = "Convert &F To C";
            this.btnConvertFToC.UseVisualStyleBackColor = true;
            this.btnConvertFToC.Click += new System.EventHandler(this.btnConvertFToC_Click);
            // 
            // btnConvertCToF
            // 
            this.btnConvertCToF.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConvertCToF.Location = new System.Drawing.Point(475, 206);
            this.btnConvertCToF.Name = "btnConvertCToF";
            this.btnConvertCToF.Size = new System.Drawing.Size(190, 58);
            this.btnConvertCToF.TabIndex = 3;
            this.btnConvertCToF.Text = "Convert &C To F";
            this.btnConvertCToF.UseVisualStyleBackColor = true;
            this.btnConvertCToF.Click += new System.EventHandler(this.btnConvertCToF_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(140, 331);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(190, 58);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblFahrTemp
            // 
            this.lblFahrTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblFahrTemp.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFahrTemp.Location = new System.Drawing.Point(137, 41);
            this.lblFahrTemp.Name = "lblFahrTemp";
            this.lblFahrTemp.Size = new System.Drawing.Size(193, 36);
            this.lblFahrTemp.TabIndex = 6;
            this.lblFahrTemp.Text = "Fahr Temp:";
            this.lblFahrTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCelTemp
            // 
            this.lblCelTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblCelTemp.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelTemp.Location = new System.Drawing.Point(472, 41);
            this.lblCelTemp.Name = "lblCelTemp";
            this.lblCelTemp.Size = new System.Drawing.Size(193, 36);
            this.lblCelTemp.TabIndex = 7;
            this.lblCelTemp.Text = "Cel Temp:";
            this.lblCelTemp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFahrTemp
            // 
            this.txtFahrTemp.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFahrTemp.Location = new System.Drawing.Point(137, 122);
            this.txtFahrTemp.Name = "txtFahrTemp";
            this.txtFahrTemp.Size = new System.Drawing.Size(193, 38);
            this.txtFahrTemp.TabIndex = 0;
            this.txtFahrTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCelTemp
            // 
            this.txtCelTemp.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelTemp.Location = new System.Drawing.Point(472, 122);
            this.txtCelTemp.Name = "txtCelTemp";
            this.txtCelTemp.Size = new System.Drawing.Size(193, 38);
            this.txtCelTemp.TabIndex = 1;
            this.txtCelTemp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(475, 331);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(190, 58);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmTemperatureConverter
            // 
            this.AcceptButton = this.btnConvertFToC;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtCelTemp);
            this.Controls.Add(this.txtFahrTemp);
            this.Controls.Add(this.lblCelTemp);
            this.Controls.Add(this.lblFahrTemp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvertCToF);
            this.Controls.Add(this.btnConvertFToC);
            this.Name = "frmTemperatureConverter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Temperature Converter - Chapters 6 & 7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConvertFToC;
        private System.Windows.Forms.Button btnConvertCToF;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblFahrTemp;
        private System.Windows.Forms.Label lblCelTemp;
        private System.Windows.Forms.TextBox txtFahrTemp;
        private System.Windows.Forms.TextBox txtCelTemp;
        private System.Windows.Forms.Button btnExit;
    }
}

