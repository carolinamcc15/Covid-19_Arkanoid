using System.ComponentModel;

namespace Covid_19_Arkanoid
{
    partial class NameUser
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
            this.tlpChoose = new System.Windows.Forms.TableLayoutPanel();
            this.btnDone = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.tlpChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpChoose
            // 
            this.tlpChoose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpChoose.BackgroundImage = global::Covid_19_Arkanoid.Properties.Resources.User;
            this.tlpChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpChoose.ColumnCount = 5;
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.70223F));
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.80884F));
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.78939F));
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.99923F));
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.7003F));
            this.tlpChoose.Controls.Add(this.btnDone, 2, 3);
            this.tlpChoose.Controls.Add(this.txtUsername, 1, 1);
            this.tlpChoose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tlpChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChoose.Location = new System.Drawing.Point(0, 0);
            this.tlpChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpChoose.Name = "tlpChoose";
            this.tlpChoose.RowCount = 5;
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.62376F));
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.306931F));
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.94737F));
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.31579F));
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.63158F));
            this.tlpChoose.Size = new System.Drawing.Size(711, 475);
            this.tlpChoose.TabIndex = 0;
            // 
            // btnDone
            // 
            this.btnDone.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDone.Font = new System.Drawing.Font("Volleyball", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDone.Location = new System.Drawing.Point(312, 273);
            this.btnDone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(106, 44);
            this.btnDone.TabIndex = 2;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            this.tlpChoose.SetColumnSpan(this.txtUsername, 3);
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Volleyball", 14F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsername.Location = new System.Drawing.Point(150, 179);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(410, 35);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpChoose);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "NameUser";
            this.Size = new System.Drawing.Size(711, 475);
            this.tlpChoose.ResumeLayout(false);
            this.tlpChoose.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.TableLayoutPanel tlpChoose;
    }
}