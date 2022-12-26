namespace OCR_Vietnamese
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
            this.btn_choose = new System.Windows.Forms.Button();
            this.btn_ocr = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.picloading = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_takephoto = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btn_saveresult = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(371, 44);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(89, 23);
            this.btn_choose.TabIndex = 1;
            this.btn_choose.Text = "Choose Image";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ocr
            // 
            this.btn_ocr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ocr.ForeColor = System.Drawing.Color.Red;
            this.btn_ocr.Location = new System.Drawing.Point(476, 230);
            this.btn_ocr.Name = "btn_ocr";
            this.btn_ocr.Size = new System.Drawing.Size(92, 89);
            this.btn_ocr.TabIndex = 2;
            this.btn_ocr.Text = "OCR";
            this.btn_ocr.UseVisualStyleBackColor = true;
            this.btn_ocr.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.richTextBox1.Location = new System.Drawing.Point(590, 73);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(486, 467);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(587, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Result";
            // 
            // picloading
            // 
            this.picloading.Image = global::OCR_Vietnamese.Properties.Resources.loading;
            this.picloading.Location = new System.Drawing.Point(780, 230);
            this.picloading.Name = "picloading";
            this.picloading.Size = new System.Drawing.Size(107, 106);
            this.picloading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picloading.TabIndex = 7;
            this.picloading.TabStop = false;
            this.picloading.Visible = false;
            this.picloading.Click += new System.EventHandler(this.picloading_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(448, 467);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(12, 44);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_takephoto
            // 
            this.btn_takephoto.Location = new System.Drawing.Point(209, 44);
            this.btn_takephoto.Name = "btn_takephoto";
            this.btn_takephoto.Size = new System.Drawing.Size(75, 23);
            this.btn_takephoto.TabIndex = 9;
            this.btn_takephoto.Text = "Take photo";
            this.btn_takephoto.UseVisualStyleBackColor = true;
            this.btn_takephoto.Click += new System.EventHandler(this.btn_takephoto_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(290, 44);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(93, 44);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(110, 21);
            this.comboBox1.TabIndex = 11;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Title = "ImageName|*.png";
            // 
            // btn_saveresult
            // 
            this.btn_saveresult.Location = new System.Drawing.Point(1001, 44);
            this.btn_saveresult.Name = "btn_saveresult";
            this.btn_saveresult.Size = new System.Drawing.Size(75, 23);
            this.btn_saveresult.TabIndex = 12;
            this.btn_saveresult.Text = "Save";
            this.btn_saveresult.UseVisualStyleBackColor = true;
            this.btn_saveresult.Click += new System.EventHandler(this.btn_saveresult_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 552);
            this.Controls.Add(this.btn_saveresult);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_takephoto);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.picloading);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_ocr);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "[C#] Convert Image To Text";
            ((System.ComponentModel.ISupportInitialize)(this.picloading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Button btn_ocr;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picloading;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_takephoto;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btn_saveresult;
    }
}

