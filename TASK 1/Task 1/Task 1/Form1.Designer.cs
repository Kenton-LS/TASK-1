namespace Task_1
{
    partial class frm1
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lblRound = new System.Windows.Forms.Label();
            this.rtbUnitInfo = new System.Windows.Forms.RichTextBox();
            this.lblMap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(143, 415);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(434, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START / PAUSE";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // lblRound
            // 
            this.lblRound.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRound.Location = new System.Drawing.Point(12, 413);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(125, 28);
            this.lblRound.TabIndex = 2;
            this.lblRound.Text = "ROUND: ";
            //this.lblRound.Click += new System.EventHandler(this.round_lbl_Click); giving issues, this never has to be clicked, so i thereby commented it out
            // 
            // rtbUnitInfo
            // 
            this.rtbUnitInfo.Location = new System.Drawing.Point(265, 9);
            this.rtbUnitInfo.Name = "rtbUnitInfo";
            this.rtbUnitInfo.Size = new System.Drawing.Size(312, 393);
            this.rtbUnitInfo.TabIndex = 4;
            this.rtbUnitInfo.Text = "";
            //this.rtbUnitInfo.TextChanged += new System.EventHandler(this.stats_txt_TextChanged); giving issues, this never has to be clicked, so i thereby commented it out
            // 
            // lblMap
            // 
            this.lblMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMap.Location = new System.Drawing.Point(12, 9);
            this.lblMap.Name = "lblMap";
            this.lblMap.Size = new System.Drawing.Size(247, 393);
            this.lblMap.TabIndex = 5;
            //this.lblMap.Click += new System.EventHandler(this.map_lbl_Click); giving issues, this never has to be clicked, so i thereby commented it out
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 450);
            this.Controls.Add(this.lblMap);
            this.Controls.Add(this.rtbUnitInfo);
            this.Controls.Add(this.lblRound);
            this.Controls.Add(this.btnStart);
            this.Name = "frm1";
            this.Text = "THE WAR FOR BOEREWORS";
            //this.Load += new System.EventHandler(this.Form1_Load); giving issues, this never has to be clicked, so i thereby commented it out
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.RichTextBox rtbUnitInfo;
        public System.Windows.Forms.Label lblMap;
    }
}

