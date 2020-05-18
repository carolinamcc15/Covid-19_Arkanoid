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
            this.btnUsername = new System.Windows.Forms.Button();
            this.btnSkin = new System.Windows.Forms.Button();
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
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 347F));
            this.tableLayoutPanel1.Controls.Add(this.btnUsername, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnSkin, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameUser1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.57732F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.42268F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 419);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUsername
            // 
            this.btnUsername.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUsername.Font = new System.Drawing.Font("Volleyball", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUsername.Location = new System.Drawing.Point(3, 390);
            this.btnUsername.Name = "btnUsername";
            this.btnUsername.Size = new System.Drawing.Size(336, 26);
            this.btnUsername.TabIndex = 1;
            this.btnUsername.Text = "Username";
            this.btnUsername.UseVisualStyleBackColor = true;
            this.btnUsername.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSkin
            // 
            this.btnSkin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSkin.Font = new System.Drawing.Font("Volleyball", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSkin.Location = new System.Drawing.Point(345, 390);
            this.btnSkin.Name = "btnSkin";
            this.btnSkin.Size = new System.Drawing.Size(341, 26);
            this.btnSkin.TabIndex = 2;
            this.btnSkin.Text = "Skin";
            this.btnSkin.UseVisualStyleBackColor = true;
            this.btnSkin.Click += new System.EventHandler(this.ButSkin_Click);
            // 
            // nameUser1
            // 
            this.nameUser1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.nameUser1, 2);
            this.nameUser1.Cursor = System.Windows.Forms.Cursors.Default;
            this.nameUser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameUser1.Location = new System.Drawing.Point(3, 4);
            this.nameUser1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nameUser1.Name = "nameUser1";
            this.nameUser1.Size = new System.Drawing.Size(683, 379);
            this.nameUser1.TabIndex = 3;
            // 
            // Username
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(689, 419);
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
        private Covid_19_Arkanoid.NameUser nameUser1;
        private System.Windows.Forms.Button btnSkin;
        private System.Windows.Forms.Button btnUsername;
    }
}