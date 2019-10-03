namespace Task_1
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
            this.start_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.round_lbl = new System.Windows.Forms.Label();
            this.stats_txt = new System.Windows.Forms.RichTextBox();
            this.map_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.Location = new System.Drawing.Point(630, 340);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(75, 23);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "START";
            this.start_btn.UseVisualStyleBackColor = true;
            // 
            // pause_btn
            // 
            this.pause_btn.Location = new System.Drawing.Point(630, 391);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(75, 23);
            this.pause_btn.TabIndex = 1;
            this.pause_btn.Text = "PAUSE";
            this.pause_btn.UseVisualStyleBackColor = true;
            // 
            // round_lbl
            // 
            this.round_lbl.AutoSize = true;
            this.round_lbl.Location = new System.Drawing.Point(638, 282);
            this.round_lbl.Name = "round_lbl";
            this.round_lbl.Size = new System.Drawing.Size(58, 17);
            this.round_lbl.TabIndex = 2;
            this.round_lbl.Text = "Round: ";
            this.round_lbl.Click += new System.EventHandler(this.round_lbl_Click);
            // 
            // stats_txt
            // 
            this.stats_txt.Location = new System.Drawing.Point(22, 24);
            this.stats_txt.Name = "stats_txt";
            this.stats_txt.Size = new System.Drawing.Size(154, 390);
            this.stats_txt.TabIndex = 4;
            this.stats_txt.Text = "";
            this.stats_txt.TextChanged += new System.EventHandler(this.stats_txt_TextChanged);
            // 
            // map_lbl
            // 
            this.map_lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.map_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.map_lbl.Location = new System.Drawing.Point(182, 24);
            this.map_lbl.Name = "map_lbl";
            this.map_lbl.Size = new System.Drawing.Size(423, 390);
            this.map_lbl.TabIndex = 5;
            this.map_lbl.Click += new System.EventHandler(this.map_lbl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.map_lbl);
            this.Controls.Add(this.stats_txt);
            this.Controls.Add(this.round_lbl);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.start_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Label round_lbl;
        private System.Windows.Forms.RichTextBox stats_txt;
        public System.Windows.Forms.Label map_lbl;
    }
}

