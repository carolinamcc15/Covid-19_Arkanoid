using System.ComponentModel;

namespace Covid_19_Arkanoid
{
      partial class Username
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Username));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ButName = new System.Windows.Forms.Button();
            this.ButSkin = new System.Windows.Forms.Button();
            this.nameUser1 = new Covid_19_Arkanoid.NameUser();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 427F));
            this.tableLayoutPanel1.Controls.Add(this.ButName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ButSkin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameUser1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.57732F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.42268F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(849, 513);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ButName
            // 
            this.ButName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButName.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ButName.Location = new System.Drawing.Point(3, 477);
            this.ButName.Name = "ButName";
            this.ButName.Size = new System.Drawing.Size(416, 33);
            this.ButName.TabIndex = 1;
            this.ButName.Text = "Username";
            this.ButName.UseVisualStyleBackColor = true;
            this.ButName.Click += new System.EventHandler(this.button1_Click);
            // 
            // ButSkin
            // 
            this.ButSkin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButSkin.Location = new System.Drawing.Point(425, 477);
            this.ButSkin.Name = "ButSkin";
            this.ButSkin.Size = new System.Drawing.Size(421, 33);
            this.ButSkin.TabIndex = 2;
            this.ButSkin.Text = "Skin";
            this.ButSkin.UseVisualStyleBackColor = true;
            this.ButSkin.Click += new System.EventHandler(this.ButSkin_Click);
            // 
            // nameUser1
            // 
            this.nameUser1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.nameUser1, 2);
            this.nameUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameUser1.Location = new System.Drawing.Point(3, 3);
            this.nameUser1.Name = "nameUser1";
            this.nameUser1.Size = new System.Drawing.Size(843, 468);
            this.nameUser1.TabIndex = 3;
            // 
            // Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(849, 513);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Username";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARKANOID";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button ButName;
        private System.Windows.Forms.Button ButSkin;
        private Covid_19_Arkanoid.NameUser nameUser1;
    }
}