
namespace deneme
{
    partial class anaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(anaForm));
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnKural = new System.Windows.Forms.Button();
            this.btnBasla = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.duvar = new System.Windows.Forms.PictureBox();
            this.targetStone = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duvar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetStone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(39, 185);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(121, 49);
            this.btnCikis.TabIndex = 6;
            this.btnCikis.Text = "ÇIKIŞ";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnKural
            // 
            this.btnKural.Location = new System.Drawing.Point(39, 102);
            this.btnKural.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKural.Name = "btnKural";
            this.btnKural.Size = new System.Drawing.Size(121, 49);
            this.btnKural.TabIndex = 5;
            this.btnKural.Text = "OYUN KURALLARI";
            this.btnKural.UseVisualStyleBackColor = true;
            this.btnKural.Click += new System.EventHandler(this.btnKural_Click);
            // 
            // btnBasla
            // 
            this.btnBasla.Location = new System.Drawing.Point(39, 18);
            this.btnBasla.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(121, 49);
            this.btnBasla.TabIndex = 4;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.duvar);
            this.panel1.Controls.Add(this.targetStone);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnBasla);
            this.panel1.Controls.Add(this.btnKural);
            this.panel1.Controls.Add(this.btnCikis);
            this.panel1.Location = new System.Drawing.Point(586, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 585);
            this.panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 486);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Ana Taş";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 369);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Duvar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Yan Taşlar";
            // 
            // duvar
            // 
            this.duvar.Image = global::deneme.Properties.Resources.pngtree_cartoon_wall_vector_png_image_3201462;
            this.duvar.Location = new System.Drawing.Point(39, 391);
            this.duvar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.duvar.Name = "duvar";
            this.duvar.Size = new System.Drawing.Size(106, 73);
            this.duvar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.duvar.TabIndex = 13;
            this.duvar.TabStop = false;
            this.duvar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.duvar_MouseDown);
            // 
            // targetStone
            // 
            this.targetStone.Image = ((System.Drawing.Image)(resources.GetObject("targetStone.Image")));
            this.targetStone.Location = new System.Drawing.Point(39, 508);
            this.targetStone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.targetStone.Name = "targetStone";
            this.targetStone.Size = new System.Drawing.Size(106, 73);
            this.targetStone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetStone.TabIndex = 12;
            this.targetStone.TabStop = false;
            this.targetStone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.targetStone_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(39, 277);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.Location = new System.Drawing.Point(5, 3);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 585);
            this.panel2.TabIndex = 9;
            // 
            // anaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 601);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "anaForm";
            this.Text = "Taş Oyunu";
            this.Load += new System.EventHandler(this.anaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.duvar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetStone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnKural;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox targetStone;
        private System.Windows.Forms.PictureBox duvar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

