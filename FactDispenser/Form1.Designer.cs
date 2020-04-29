namespace FactDispenser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.cBoxTypes = new System.Windows.Forms.ComboBox();
            this.btnDispense = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFact = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxTypes
            // 
            this.cBoxTypes.FormattingEnabled = true;
            //this.cBoxTypes.Items.AddRange(new object[] {"All"});
            this.cBoxTypes.Location = new System.Drawing.Point(340, 15);
            this.cBoxTypes.Name = "cBoxTypes";
            this.cBoxTypes.Size = new System.Drawing.Size(105, 21);
            this.cBoxTypes.TabIndex = 2;
            // 
            // btnDispense
            // 
            this.btnDispense.Location = new System.Drawing.Point(339, 44);
            this.btnDispense.Name = "btnDispense";
            this.btnDispense.Size = new System.Drawing.Size(107, 63);
            this.btnDispense.TabIndex = 3;
            this.btnDispense.Text = "Dispense Fact";
            this.btnDispense.UseVisualStyleBackColor = true;
            this.btnDispense.Click += new System.EventHandler(this.BtnDispense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFact);
            this.groupBox1.Location = new System.Drawing.Point(13, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 325);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // lblFact
            // 
            this.lblFact.AutoEllipsis = true;
            this.lblFact.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFact.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblFact.Location = new System.Drawing.Point(3, 16);
            this.lblFact.Name = "lblFact";
            this.lblFact.Size = new System.Drawing.Size(769, 306);
            this.lblFact.TabIndex = 2;
            this.lblFact.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmFactDispenser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDispense);
            this.Controls.Add(this.cBoxTypes);
            this.Name = "FrmFactDispenser";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.Text = "Chuck Norris Fact Dispenser";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
        }

        #endregion
        private System.Windows.Forms.ComboBox cBoxTypes;
        private System.Windows.Forms.Button btnDispense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFact;
    }
}

