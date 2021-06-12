
namespace Evaluator1
{
    partial class FinanceReportForm
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
            this.recordListView = new System.Windows.Forms.ListView();
            this.lblName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // recordListView
            // 
            this.recordListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordListView.FullRowSelect = true;
            this.recordListView.GridLines = true;
            this.recordListView.HideSelection = false;
            this.recordListView.Location = new System.Drawing.Point(63, 69);
            this.recordListView.Name = "recordListView";
            this.recordListView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.recordListView.Size = new System.Drawing.Size(693, 343);
            this.recordListView.TabIndex = 1;
            this.recordListView.UseCompatibleStateImageBehavior = false;
            this.recordListView.View = System.Windows.Forms.View.Details;
            this.recordListView.SelectedIndexChanged += new System.EventHandler(this.recordListView_SelectedIndexChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(60, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(67, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "NAME : ";
            // 
            // FinanceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(171)))), ((int)(((byte)(151)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.recordListView);
            this.Name = "FinanceReportForm";
            this.Text = "FinanceReportForm";
            this.Load += new System.EventHandler(this.FinanceReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView recordListView;
        private System.Windows.Forms.Label lblName;
    }
}