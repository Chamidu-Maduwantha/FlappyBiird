
namespace Flappy
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
            this.components = new System.ComponentModel.Container();
            this.pipeisTop = new System.Windows.Forms.PictureBox();
            this.flappy = new System.Windows.Forms.PictureBox();
            this.pipeisBottom = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Text1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gameOverPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pipeisTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeisBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.gameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pipeisTop
            // 
            this.pipeisTop.Image = global::Flappy.Properties.Resources.sss;
            this.pipeisTop.Location = new System.Drawing.Point(305, -76);
            this.pipeisTop.Name = "pipeisTop";
            this.pipeisTop.Size = new System.Drawing.Size(100, 157);
            this.pipeisTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeisTop.TabIndex = 0;
            this.pipeisTop.TabStop = false;
            // 
            // flappy
            // 
            this.flappy.BackColor = System.Drawing.Color.Transparent;
            this.flappy.Image = global::Flappy.Properties.Resources.pngegg;
            this.flappy.Location = new System.Drawing.Point(113, 185);
            this.flappy.Name = "flappy";
            this.flappy.Size = new System.Drawing.Size(71, 62);
            this.flappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappy.TabIndex = 1;
            this.flappy.TabStop = false;
            // 
            // pipeisBottom
            // 
            this.pipeisBottom.Image = global::Flappy.Properties.Resources.NicePng_pipes_png_388476;
            this.pipeisBottom.Location = new System.Drawing.Point(396, 342);
            this.pipeisBottom.Name = "pipeisBottom";
            this.pipeisBottom.Size = new System.Drawing.Size(100, 157);
            this.pipeisBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeisBottom.TabIndex = 2;
            this.pipeisBottom.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = global::Flappy.Properties.Resources.download;
            this.ground.Location = new System.Drawing.Point(-18, 402);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(866, 97);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.gameTimmerEvent);
            // 
            // Text1
            // 
            this.Text1.AutoSize = true;
            this.Text1.BackColor = System.Drawing.Color.Transparent;
            this.Text1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text1.Location = new System.Drawing.Point(338, 427);
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(158, 61);
            this.Text1.TabIndex = 4;
            this.Text1.Text = "Score : ";
            this.Text1.Click += new System.EventHandler(this.Text1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(464, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 61);
            this.label1.TabIndex = 5;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 55);
            this.label2.TabIndex = 6;
            this.label2.Text = "Game Over";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Location = new System.Drawing.Point(94, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Restart";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gameOverPanel
            // 
            this.gameOverPanel.Controls.Add(this.label3);
            this.gameOverPanel.Controls.Add(this.label2);
            this.gameOverPanel.Controls.Add(this.button1);
            this.gameOverPanel.Location = new System.Drawing.Point(247, 103);
            this.gameOverPanel.Name = "gameOverPanel";
            this.gameOverPanel.Size = new System.Drawing.Size(325, 209);
            this.gameOverPanel.TabIndex = 8;
            this.gameOverPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 44);
            this.label3.TabIndex = 8;
            this.label3.Text = "Score : ";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(835, 482);
            this.Controls.Add(this.gameOverPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeisBottom);
            this.Controls.Add(this.flappy);
            this.Controls.Add(this.pipeisTop);
            this.Name = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pipeisTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeisBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.gameOverPanel.ResumeLayout(false);
            this.gameOverPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox flalppyBird;
        private System.Windows.Forms.PictureBox grass;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer ganeTimmer;
        private System.Windows.Forms.PictureBox pipeisTop;
        private System.Windows.Forms.PictureBox flappy;
        private System.Windows.Forms.PictureBox pipeisBottom;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Text1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel gameOverPanel;
        private System.Windows.Forms.Label label3;
    }
}

