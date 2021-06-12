
namespace Evaluator1
{
    partial class DashboardForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotalPupil = new System.Windows.Forms.Label();
            this.iconTotalPupil = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotalSubjects = new System.Windows.Forms.Label();
            this.iconTotalReport = new FontAwesome.Sharp.IconPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.iconTotalFees = new FontAwesome.Sharp.IconPictureBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTotalPupil)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTotalReport)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTotalFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotalPupil);
            this.panel1.Controls.Add(this.iconTotalPupil);
            this.panel1.Location = new System.Drawing.Point(19, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 199);
            this.panel1.TabIndex = 0;
            // 
            // lblTotalPupil
            // 
            this.lblTotalPupil.AutoSize = true;
            this.lblTotalPupil.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPupil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(221)))), ((int)(((byte)(50)))));
            this.lblTotalPupil.Location = new System.Drawing.Point(50, 149);
            this.lblTotalPupil.MaximumSize = new System.Drawing.Size(60, 50);
            this.lblTotalPupil.MinimumSize = new System.Drawing.Size(60, 30);
            this.lblTotalPupil.Name = "lblTotalPupil";
            this.lblTotalPupil.Size = new System.Drawing.Size(60, 38);
            this.lblTotalPupil.TabIndex = 1;
            this.lblTotalPupil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconTotalPupil
            // 
            this.iconTotalPupil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.iconTotalPupil.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconTotalPupil.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconTotalPupil.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconTotalPupil.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTotalPupil.IconSize = 69;
            this.iconTotalPupil.Location = new System.Drawing.Point(28, 73);
            this.iconTotalPupil.Name = "iconTotalPupil";
            this.iconTotalPupil.Size = new System.Drawing.Size(104, 69);
            this.iconTotalPupil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTotalPupil.TabIndex = 0;
            this.iconTotalPupil.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTotalSubjects);
            this.panel2.Controls.Add(this.iconTotalReport);
            this.panel2.Location = new System.Drawing.Point(206, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(158, 199);
            this.panel2.TabIndex = 2;
            // 
            // lblTotalSubjects
            // 
            this.lblTotalSubjects.AutoSize = true;
            this.lblTotalSubjects.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSubjects.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(221)))), ((int)(((byte)(50)))));
            this.lblTotalSubjects.Location = new System.Drawing.Point(50, 149);
            this.lblTotalSubjects.MaximumSize = new System.Drawing.Size(60, 50);
            this.lblTotalSubjects.MinimumSize = new System.Drawing.Size(60, 30);
            this.lblTotalSubjects.Name = "lblTotalSubjects";
            this.lblTotalSubjects.Size = new System.Drawing.Size(60, 38);
            this.lblTotalSubjects.TabIndex = 1;
            this.lblTotalSubjects.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconTotalReport
            // 
            this.iconTotalReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.iconTotalReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconTotalReport.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.iconTotalReport.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconTotalReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTotalReport.IconSize = 69;
            this.iconTotalReport.Location = new System.Drawing.Point(28, 74);
            this.iconTotalReport.Name = "iconTotalReport";
            this.iconTotalReport.Size = new System.Drawing.Size(104, 69);
            this.iconTotalReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTotalReport.TabIndex = 0;
            this.iconTotalReport.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblTotalFees);
            this.panel3.Controls.Add(this.iconTotalFees);
            this.panel3.Location = new System.Drawing.Point(393, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 199);
            this.panel3.TabIndex = 2;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(221)))), ((int)(((byte)(50)))));
            this.lblTotalFees.Location = new System.Drawing.Point(37, 148);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(86, 38);
            this.lblTotalFees.TabIndex = 1;
            this.lblTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconTotalFees
            // 
            this.iconTotalFees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconTotalFees.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(63)))));
            this.iconTotalFees.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.iconTotalFees.IconChar = FontAwesome.Sharp.IconChar.Coins;
            this.iconTotalFees.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.iconTotalFees.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconTotalFees.IconSize = 69;
            this.iconTotalFees.Location = new System.Drawing.Point(28, 74);
            this.iconTotalFees.Name = "iconTotalFees";
            this.iconTotalFees.Size = new System.Drawing.Size(104, 69);
            this.iconTotalFees.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.iconTotalFees.TabIndex = 0;
            this.iconTotalFees.TabStop = false;
            // 
            // chart1
            // 
            this.chart1.Anchor = System.Windows.Forms.AnchorStyles.None;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(19, 233);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(532, 136);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(28, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 50);
            this.label1.TabIndex = 2;
            this.label1.Text = "TOTAL STUDENTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 50);
            this.label2.TabIndex = 3;
            this.label2.Text = "TOTAL SUBJECTS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold Condensed", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(32, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "TOTAL AMOUNT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(568, 372);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DashboardForm";
            this.Text = " DashboardForm";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTotalPupil)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconTotalReport)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconTotalFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTotalPupil;
        private FontAwesome.Sharp.IconPictureBox iconTotalPupil;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalSubjects;
        private FontAwesome.Sharp.IconPictureBox iconTotalReport;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconPictureBox iconTotalFees;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}