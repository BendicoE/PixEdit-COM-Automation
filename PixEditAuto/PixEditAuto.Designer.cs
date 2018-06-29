namespace PixEditAuto
{
    partial class PixEditAuto
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
            this.btnOpenDoc = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.tbText = new System.Windows.Forms.TextBox();
            this.btnInsertText = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpenDoc
            // 
            this.btnOpenDoc.Location = new System.Drawing.Point(13, 13);
            this.btnOpenDoc.Name = "btnOpenDoc";
            this.btnOpenDoc.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDoc.TabIndex = 0;
            this.btnOpenDoc.Text = "Open...";
            this.btnOpenDoc.UseVisualStyleBackColor = true;
            this.btnOpenDoc.Click += new System.EventHandler(this.btnOpenDoc_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(13, 53);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(71, 13);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Text to insert:";
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(13, 70);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(255, 20);
            this.tbText.TabIndex = 2;
            // 
            // btnInsertText
            // 
            this.btnInsertText.Location = new System.Drawing.Point(275, 69);
            this.btnInsertText.Name = "btnInsertText";
            this.btnInsertText.Size = new System.Drawing.Size(75, 23);
            this.btnInsertText.TabIndex = 3;
            this.btnInsertText.Text = "Insert";
            this.btnInsertText.UseVisualStyleBackColor = true;
            this.btnInsertText.Click += new System.EventHandler(this.btnInsertText_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(95, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // PixEditAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 396);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnInsertText);
            this.Controls.Add(this.tbText);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnOpenDoc);
            this.Name = "PixEditAuto";
            this.Text = "PixEdit Automation Application";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PixEditAuto_FormClosing);
            this.Load += new System.EventHandler(this.PixEditAuto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenDoc;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Button btnInsertText;
        private System.Windows.Forms.Button btnSave;
    }
}

