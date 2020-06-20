﻿using System.ComponentModel;

namespace Covid_19_Arkanoid.Vista
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
            this.btnDoneS = new System.Windows.Forms.Button();
            this.tlpSkin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.picSkin)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpSkin
            // 
            this.tlpSkin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSkin.BackColor = System.Drawing.Color.Transparent;
            this.tlpSkin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpSkin.ColumnCount = 5;
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.33102F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.2305F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.22357F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.06413F));
            this.tlpSkin.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.32409F));
            this.tlpSkin.Controls.Add(this.picSkin, 2, 1);
            this.tlpSkin.Controls.Add(this.btnRight, 3, 1);
            this.tlpSkin.Controls.Add(this.btnLeft, 1, 1);
            this.tlpSkin.Controls.Add(this.btnDoneS, 2, 2);
            this.tlpSkin.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlpSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSkin.Location = new System.Drawing.Point(0, 0);
            this.tlpSkin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tlpSkin.Name = "tlpSkin";
            this.tlpSkin.RowCount = 4;
            this.tlpSkin.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.9773F));
            this.tlpSkin.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.76502F));
            this.tlpSkin.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.55808F));
            this.tlpSkin.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.56609F));
            this.tlpSkin.Size = new System.Drawing.Size(922, 599);
            this.tlpSkin.TabIndex = 0;
            // 
            // picSkin
            // 
            this.picSkin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picSkin.Location = new System.Drawing.Point(356, 198);
            this.picSkin.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.picSkin.Name = "picSkin";
            this.picSkin.Size = new System.Drawing.Size(209, 140);
            this.picSkin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSkin.TabIndex = 0;
            this.picSkin.TabStop = false;
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRight.BackColor = System.Drawing.Color.White;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRight.Location = new System.Drawing.Point(614, 228);
            this.btnRight.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(80, 80);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "▶";
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.BackColor = System.Drawing.Color.White;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnLeft.Location = new System.Drawing.Point(216, 228);
            this.btnLeft.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(80, 80);
            this.btnLeft.TabIndex = 2;
            this.btnLeft.Text = "◀";
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // btnDoneS
            // 
            this.btnDoneS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDoneS.BackColor = System.Drawing.Color.White;
            this.btnDoneS.Font = new System.Drawing.Font("Volleyball", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDoneS.Location = new System.Drawing.Point(369, 366);
            this.btnDoneS.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnDoneS.Name = "btnDoneS";
            this.btnDoneS.Size = new System.Drawing.Size(182, 56);
            this.btnDoneS.TabIndex = 5;
            this.btnDoneS.Text = "DONE";
            this.btnDoneS.UseVisualStyleBackColor = false;
            this.btnDoneS.Click += new System.EventHandler(this.BtnDoneS_Click);
            // 
            // Skin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpSkin);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Skin";
            this.Size = new System.Drawing.Size(922, 599);
            this.Load += new System.EventHandler(this.Skin_Load);
            this.tlpSkin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.picSkin)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.PictureBox picSkin;
        private System.Windows.Forms.TableLayoutPanel tlpSkin;
        private System.Windows.Forms.Button btnDoneS;
    }
}