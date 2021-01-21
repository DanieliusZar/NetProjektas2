namespace ManoProjektas
{
    partial class FilmForm
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
            this.ReleaseDate = new System.Windows.Forms.Label();
            this.releaseDate_P = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.producer_P = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.director_P = new System.Windows.Forms.Label();
            this.charactersView = new System.Windows.Forms.ListView();
            this.title_P = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.episode_P = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.AutoSize = true;
            this.ReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReleaseDate.Location = new System.Drawing.Point(12, 195);
            this.ReleaseDate.Name = "ReleaseDate";
            this.ReleaseDate.Size = new System.Drawing.Size(111, 17);
            this.ReleaseDate.TabIndex = 0;
            this.ReleaseDate.Text = "Release Date:";
            this.ReleaseDate.Click += new System.EventHandler(this.label1_Click);
            // 
            // releaseDate_P
            // 
            this.releaseDate_P.AutoSize = true;
            this.releaseDate_P.Location = new System.Drawing.Point(126, 195);
            this.releaseDate_P.Name = "releaseDate_P";
            this.releaseDate_P.Size = new System.Drawing.Size(90, 17);
            this.releaseDate_P.TabIndex = 1;
            this.releaseDate_P.Text = "[placeholder]";
            this.releaseDate_P.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producer:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // producer_P
            // 
            this.producer_P.AutoSize = true;
            this.producer_P.Location = new System.Drawing.Point(94, 160);
            this.producer_P.Name = "producer_P";
            this.producer_P.Size = new System.Drawing.Size(90, 17);
            this.producer_P.TabIndex = 3;
            this.producer_P.Text = "[placeholder]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Director:";
            // 
            // director_P
            // 
            this.director_P.AutoSize = true;
            this.director_P.Location = new System.Drawing.Point(84, 129);
            this.director_P.Name = "director_P";
            this.director_P.Size = new System.Drawing.Size(90, 17);
            this.director_P.TabIndex = 5;
            this.director_P.Text = "[placeholder]";
            this.director_P.Click += new System.EventHandler(this.label5_Click);
            // 
            // charactersView
            // 
            this.charactersView.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charactersView.HideSelection = false;
            this.charactersView.Location = new System.Drawing.Point(17, 243);
            this.charactersView.Name = "charactersView";
            this.charactersView.Size = new System.Drawing.Size(157, 195);
            this.charactersView.TabIndex = 6;
            this.charactersView.UseCompatibleStateImageBehavior = false;
            this.charactersView.View = System.Windows.Forms.View.List;
            this.charactersView.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // title_P
            // 
            this.title_P.BackColor = System.Drawing.Color.Transparent;
            this.title_P.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_P.ForeColor = System.Drawing.Color.Red;
            this.title_P.Location = new System.Drawing.Point(0, 0);
            this.title_P.Name = "title_P";
            this.title_P.Size = new System.Drawing.Size(801, 116);
            this.title_P.TabIndex = 7;
            this.title_P.Text = "[placeholder]";
            this.title_P.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.title_P.Click += new System.EventHandler(this.title_P_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::ManoProjektas.Properties.Resources.New_Hope__1_;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(584, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 284);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Character List";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Episode:";
            // 
            // episode_P
            // 
            this.episode_P.AutoSize = true;
            this.episode_P.Location = new System.Drawing.Point(84, 99);
            this.episode_P.Name = "episode_P";
            this.episode_P.Size = new System.Drawing.Size(90, 17);
            this.episode_P.TabIndex = 11;
            this.episode_P.Text = "[placeholder]";
            this.episode_P.Click += new System.EventHandler(this.episode_P_Click);
            // 
            // FilmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ManoProjektas.Properties.Resources.FirstMovieBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.episode_P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.title_P);
            this.Controls.Add(this.charactersView);
            this.Controls.Add(this.director_P);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.producer_P);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.releaseDate_P);
            this.Controls.Add(this.ReleaseDate);
            this.Name = "FilmForm";
            this.Text = "FilmForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReleaseDate;
        private System.Windows.Forms.Label releaseDate_P;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label producer_P;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label director_P;
        private System.Windows.Forms.ListView charactersView;
        private System.Windows.Forms.Label title_P;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label episode_P;
    }
}