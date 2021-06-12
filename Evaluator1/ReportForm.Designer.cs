
namespace Evaluator1
{
    partial class ReportForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSelectStudent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblStudentInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnViewFin = new System.Windows.Forms.Button();
            this.btnViewAca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(98)))), ((int)(((byte)(97)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.cbSelectStudent);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.btnViewFin);
            this.splitContainer1.Panel2.Controls.Add(this.btnViewAca);
            this.splitContainer1.Size = new System.Drawing.Size(568, 372);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Student";
            // 
            // cbSelectStudent
            // 
            this.cbSelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectStudent.FormattingEnabled = true;
            this.cbSelectStudent.ItemHeight = 20;
            this.cbSelectStudent.Location = new System.Drawing.Point(80, 170);
            this.cbSelectStudent.Name = "cbSelectStudent";
            this.cbSelectStudent.Size = new System.Drawing.Size(121, 28);
            this.cbSelectStudent.TabIndex = 5;
            this.cbSelectStudent.SelectedIndexChanged += new System.EventHandler(this.cbSelectStudent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("CHERRY LIME", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Academic Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(145)))), ((int)(((byte)(106)))));
            this.panel1.Controls.Add(this.lblStudentInfo);
            this.panel1.Location = new System.Drawing.Point(25, 224);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 121);
            this.panel1.TabIndex = 17;
            // 
            // lblStudentInfo
            // 
            this.lblStudentInfo.Font = new System.Drawing.Font("Comic Sans MS", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudentInfo.Location = new System.Drawing.Point(13, 32);
            this.lblStudentInfo.Name = "lblStudentInfo";
            this.lblStudentInfo.Size = new System.Drawing.Size(214, 79);
            this.lblStudentInfo.TabIndex = 0;
            this.lblStudentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("CHERRY LIME", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(85, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Financial Report";
            // 
            // btnViewFin
            // 
            this.btnViewFin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(19)))));
            this.btnViewFin.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewFin.Location = new System.Drawing.Point(22, 285);
            this.btnViewFin.Name = "btnViewFin";
            this.btnViewFin.Size = new System.Drawing.Size(238, 59);
            this.btnViewFin.TabIndex = 9;
            this.btnViewFin.Text = "View Financial Report";
            this.btnViewFin.UseVisualStyleBackColor = false;
            this.btnViewFin.Click += new System.EventHandler(this.btnViewFin_Click);
            // 
            // btnViewAca
            // 
            this.btnViewAca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(46)))), ((int)(((byte)(19)))));
            this.btnViewAca.Font = new System.Drawing.Font("Kristen ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAca.Location = new System.Drawing.Point(22, 45);
            this.btnViewAca.Name = "btnViewAca";
            this.btnViewAca.Size = new System.Drawing.Size(238, 59);
            this.btnViewAca.TabIndex = 7;
            this.btnViewAca.Text = "View Academic Report";
            this.btnViewAca.UseVisualStyleBackColor = false;
            this.btnViewAca.Click += new System.EventHandler(this.btnViewAca_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 372);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSelectStudent;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnViewFin;
        private System.Windows.Forms.Button btnViewAca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblStudentInfo;
    }
}