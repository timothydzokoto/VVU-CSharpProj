
namespace Evaluator1
{
    partial class SettingsForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnCreateSubject = new System.Windows.Forms.Button();
            this.txtCreateSubject = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnDeleteSubject);
            this.panel2.Controls.Add(this.btnCreateSubject);
            this.panel2.Controls.Add(this.txtCreateSubject);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(123, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(310, 250);
            this.panel2.TabIndex = 3;
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteSubject.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSubject.Location = new System.Drawing.Point(74, 166);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(161, 51);
            this.btnDeleteSubject.TabIndex = 3;
            this.btnDeleteSubject.Text = "Delete Subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = false;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnCreateSubject
            // 
            this.btnCreateSubject.BackColor = System.Drawing.Color.ForestGreen;
            this.btnCreateSubject.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateSubject.Location = new System.Drawing.Point(74, 109);
            this.btnCreateSubject.Name = "btnCreateSubject";
            this.btnCreateSubject.Size = new System.Drawing.Size(161, 51);
            this.btnCreateSubject.TabIndex = 2;
            this.btnCreateSubject.Text = "Create Subject";
            this.btnCreateSubject.UseVisualStyleBackColor = false;
            this.btnCreateSubject.Click += new System.EventHandler(this.btnCreateSubject_Click);
            // 
            // txtCreateSubject
            // 
            this.txtCreateSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCreateSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCreateSubject.Location = new System.Drawing.Point(74, 63);
            this.txtCreateSubject.Multiline = true;
            this.txtCreateSubject.Name = "txtCreateSubject";
            this.txtCreateSubject.Size = new System.Drawing.Size(161, 36);
            this.txtCreateSubject.TabIndex = 1;
            this.txtCreateSubject.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "ENTER SUBJECT NAME";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(119)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(552, 333);
            this.Controls.Add(this.panel2);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCreateSubject;
        private System.Windows.Forms.TextBox txtCreateSubject;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDeleteSubject;
    }
}