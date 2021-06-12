
namespace Evaluator1
{
    partial class Fees
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbSelectFeeType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSelectStudent = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblln = new System.Windows.Forms.Label();
            this.lblfn = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("CHERRY LIME", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(386, 310);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(168, 44);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnGo
            // 
            this.btnGo.BackColor = System.Drawing.Color.Green;
            this.btnGo.Font = new System.Drawing.Font("CHERRY LIME", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGo.Location = new System.Drawing.Point(386, 200);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(168, 44);
            this.btnGo.TabIndex = 12;
            this.btnGo.Text = "ADD";
            this.btnGo.UseVisualStyleBackColor = false;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(16, 123);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(138, 34);
            this.txtAmount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 100);
            this.label4.TabIndex = 0;
            this.label4.Text = "ENTER THE AMOUNT FOR SELECTED STUDENT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Yellow;
            this.btnEdit.Font = new System.Drawing.Font("CHERRY LIME", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(386, 256);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(168, 44);
            this.btnEdit.TabIndex = 18;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAmount);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(386, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(168, 171);
            this.panel4.TabIndex = 17;
            // 
            // cbSelectFeeType
            // 
            this.cbSelectFeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectFeeType.FormattingEnabled = true;
            this.cbSelectFeeType.Location = new System.Drawing.Point(24, 78);
            this.cbSelectFeeType.Name = "cbSelectFeeType";
            this.cbSelectFeeType.Size = new System.Drawing.Size(121, 28);
            this.cbSelectFeeType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 52);
            this.label2.TabIndex = 0;
            this.label2.Text = "SELECT FEE TYPE";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbSelectStudent
            // 
            this.cbSelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSelectStudent.FormattingEnabled = true;
            this.cbSelectStudent.Location = new System.Drawing.Point(23, 79);
            this.cbSelectStudent.Name = "cbSelectStudent";
            this.cbSelectStudent.Size = new System.Drawing.Size(121, 28);
            this.cbSelectStudent.TabIndex = 1;
            this.cbSelectStudent.SelectedIndexChanged += new System.EventHandler(this.cbSelectStudent_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 47);
            this.label3.TabIndex = 0;
            this.label3.Text = "SELECT STUDENT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(189, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(168, 359);
            this.panel3.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbSelectFeeType);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(4, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(168, 172);
            this.panel2.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbSelectStudent);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(4, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(168, 171);
            this.panel1.TabIndex = 14;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(371, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(201, 372);
            this.splitter3.TabIndex = 13;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(180, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(191, 372);
            this.splitter2.TabIndex = 11;
            this.splitter2.TabStop = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(180, 372);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(145)))), ((int)(((byte)(106)))));
            this.panel5.Controls.Add(this.lbldob);
            this.panel5.Controls.Add(this.lblln);
            this.panel5.Controls.Add(this.lblfn);
            this.panel5.Controls.Add(this.lblID);
            this.panel5.Location = new System.Drawing.Point(13, 9);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(146, 155);
            this.panel5.TabIndex = 0;
            // 
            // lbldob
            // 
            this.lbldob.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbldob.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldob.Location = new System.Drawing.Point(13, 123);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(121, 23);
            this.lbldob.TabIndex = 10;
            this.lbldob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblln
            // 
            this.lblln.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblln.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblln.Location = new System.Drawing.Point(13, 85);
            this.lblln.Name = "lblln";
            this.lblln.Size = new System.Drawing.Size(121, 23);
            this.lblln.TabIndex = 9;
            this.lblln.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblfn
            // 
            this.lblfn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblfn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfn.Location = new System.Drawing.Point(13, 49);
            this.lblfn.Name = "lblfn";
            this.lblfn.Size = new System.Drawing.Size(121, 23);
            this.lblfn.TabIndex = 8;
            this.lblfn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(13, 8);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(121, 23);
            this.lblID.TabIndex = 7;
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Fees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(98)))), ((int)(((byte)(97)))));
            this.ClientSize = new System.Drawing.Size(568, 372);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.splitter1);
            this.Name = "Fees";
            this.Text = "Fees";
            this.Load += new System.EventHandler(this.Fees_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbSelectFeeType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSelectStudent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbldob;
        private System.Windows.Forms.Label lblln;
        private System.Windows.Forms.Label lblfn;
        private System.Windows.Forms.Label lblID;
    }
}