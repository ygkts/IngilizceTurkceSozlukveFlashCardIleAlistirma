namespace u2_IngilizceSozlukFlashCard
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
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButtonTurkce = new System.Windows.Forms.RadioButton();
            this.radioButtonInglizce = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnFlashCard = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(193, 108);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(157, 22);
            this.txtAranan.TabIndex = 0;
            this.txtAranan.TextChanged += new System.EventHandler(this.txtAranan_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aranan : ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(825, 231);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // radioButtonTurkce
            // 
            this.radioButtonTurkce.AutoSize = true;
            this.radioButtonTurkce.Checked = true;
            this.radioButtonTurkce.Location = new System.Drawing.Point(92, 40);
            this.radioButtonTurkce.Name = "radioButtonTurkce";
            this.radioButtonTurkce.Size = new System.Drawing.Size(99, 21);
            this.radioButtonTurkce.TabIndex = 4;
            this.radioButtonTurkce.TabStop = true;
            this.radioButtonTurkce.Text = "Türkçe Ara";
            this.radioButtonTurkce.UseVisualStyleBackColor = true;
            this.radioButtonTurkce.CheckedChanged += new System.EventHandler(this.radioButtonTurkce_CheckedChanged);
            // 
            // radioButtonInglizce
            // 
            this.radioButtonInglizce.AutoSize = true;
            this.radioButtonInglizce.Location = new System.Drawing.Point(272, 40);
            this.radioButtonInglizce.Name = "radioButtonInglizce";
            this.radioButtonInglizce.Size = new System.Drawing.Size(105, 21);
            this.radioButtonInglizce.TabIndex = 4;
            this.radioButtonInglizce.Text = "İngilizce Ara";
            this.radioButtonInglizce.UseVisualStyleBackColor = true;
            this.radioButtonInglizce.CheckedChanged += new System.EventHandler(this.radioButtonInglizce_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(465, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(403, 111);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // btnFlashCard
            // 
            this.btnFlashCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlashCard.BackColor = System.Drawing.Color.OldLace;
            this.btnFlashCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnFlashCard.Location = new System.Drawing.Point(897, 27);
            this.btnFlashCard.Name = "btnFlashCard";
            this.btnFlashCard.Size = new System.Drawing.Size(30, 365);
            this.btnFlashCard.TabIndex = 6;
            this.btnFlashCard.Text = "FLASHCARD  GAME";
            this.btnFlashCard.UseVisualStyleBackColor = false;
            this.btnFlashCard.Click += new System.EventHandler(this.btnFlashCard_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(465, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 448);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFlashCard);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.radioButtonInglizce);
            this.Controls.Add(this.radioButtonTurkce);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAranan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButtonTurkce;
        private System.Windows.Forms.RadioButton radioButtonInglizce;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnFlashCard;
        private System.Windows.Forms.Label label2;
    }
}

