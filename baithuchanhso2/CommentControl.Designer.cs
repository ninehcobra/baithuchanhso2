namespace baithuchanhso2
{
    partial class CommentControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            lblComment = new Label();
            pictureBox2 = new PictureBox();
            lblTime = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(34, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblComment.ForeColor = Color.White;
            lblComment.Location = new Point(80, 15);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(41, 17);
            lblComment.TabIndex = 1;
            lblComment.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = ButtonImage.trash;
            pictureBox2.Location = new Point(511, 9);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTime.ForeColor = SystemColors.ControlDarkDark;
            lblTime.Location = new Point(81, 35);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(37, 15);
            lblTime.TabIndex = 3;
            lblTime.Text = "label1";
            // 
            // CommentControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(lblTime);
            Controls.Add(pictureBox2);
            Controls.Add(lblComment);
            Controls.Add(pictureBox1);
            Name = "CommentControl";
            Size = new Size(569, 69);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblComment;
        private PictureBox pictureBox2;
        private Label lblTime;
    }
}
