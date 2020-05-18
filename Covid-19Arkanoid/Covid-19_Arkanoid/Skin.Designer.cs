using System.ComponentModel;

namespace Covid_19_Arkanoid
{
    partial class Skin
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlpSkin = new System.Windows.Forms.TableLayoutPanel();
            this.picSkin = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.tlpSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picSkin)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSkin
            // 
            this.tlpSkin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlpSkin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSkin.BackColor = System.Drawing.Color.Transparent;
            this.tlpSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpSkin.ColumnCount = 7;
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 168F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
            this.tlpSkin.Controls.Add(this.picSkin, 3, 1);
            this.tlpSkin.Controls.Add(this.btnRight, 5, 1);
            this.tlpSkin.Controls.Add(this.btnLeft, 1, 1);
            this.tlpSkin.Controls.Add(this.btnDone, 3, 3);
            this.tlpSkin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpSkin.Location = new System.Drawing.Point(0, 0);
            this.tlpSkin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpSkin.Name = "tlpSkin";
            this.tlpSkin.RowCount = 6;
            this.tlpSkin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tlpSkin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tlpSkin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpSkin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tlpSkin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlpSkin.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tlpSkin.Size = new System.Drawing.Size(711, 475);
            this.tlpSkin.TabIndex = 0;
            // 
            // picSkin
            // 
            this.picSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSkin.Image = global::Covid_19_Arkanoid.Properties.Resources.Pink_Kirby;
            this.picSkin.Location = new System.Drawing.Point(276, 143);
            this.picSkin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picSkin.Name = "picSkin";
            this.picSkin.Size = new System.Drawing.Size(162, 135);
            this.picSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSkin.TabIndex = 0;
            this.picSkin.TabStop = false;
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRight.Location = new System.Drawing.Point(455, 185);
            this.btnRight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(48, 51);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "▶";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLeft.Location = new System.Drawing.Point(208, 185);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(48, 51);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "◀";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnDone
            // 
            this.btnDone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDone.BackColor = System.Drawing.Color.White;
            this.btnDone.Font = new System.Drawing.Font("Volleyball", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDone.Location = new System.Drawing.Point(288, 310);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(137, 56);
            this.btnDone.TabIndex = 3;
            this.btnDone.Text = "DONE";
            this.btnDone.UseVisualStyleBackColor = false;
            // 
            // Skin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Covid_19_Arkanoid.Properties.Resources.Skin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.tlpSkin);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Skin";
            this.Size = new System.Drawing.Size(711, 475);
            this.tlpSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picSkin)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.PictureBox picSkin;
        private System.Windows.Forms.TableLayoutPanel tlpSkin;
    }
}