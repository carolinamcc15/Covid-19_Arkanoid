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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.btnDoneU = new System.Windows.Forms.Button();
            this.tlpChoose.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpChoose
            // 
            this.tlpChoose.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpChoose.BackColor = System.Drawing.Color.Transparent;
            this.tlpChoose.BackgroundImage = global::Covid_19_Arkanoid.Properties.Resources.User;
            this.tlpChoose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tlpChoose.ColumnCount = 5;
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.10399F));
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.49047F));
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.63085F));
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.93068F));
            this.tlpChoose.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.10399F));
            this.tlpChoose.Controls.Add(this.txtUsername, 1, 1);
            this.tlpChoose.Controls.Add(this.btnDoneU, 2, 2);
            this.tlpChoose.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlpChoose.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpChoose.Location = new System.Drawing.Point(0, 0);
            this.tlpChoose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tlpChoose.Name = "tlpChoose";
            this.tlpChoose.RowCount = 5;
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.55814F));
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.5814F));
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.87117F));
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 384F));
            this.tlpChoose.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpChoose.Size = new System.Drawing.Size(1154, 749);
            this.tlpChoose.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.tlpChoose.SetColumnSpan(this.txtUsername, 3);
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Volleyball", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtUsername.Location = new System.Drawing.Point(234, 200);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsername.MaxLength = 20;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(684, 43);
            this.txtUsername.TabIndex = 3;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDoneU
            // 
            this.btnDoneU.BackColor = System.Drawing.Color.White;
            this.btnDoneU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDoneU.Font = new System.Drawing.Font("Volleyball", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnDoneU.Location = new System.Drawing.Point(481, 288);
            this.btnDoneU.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDoneU.Name = "btnDoneU";
            this.btnDoneU.Size = new System.Drawing.Size(208, 54);
            this.btnDoneU.TabIndex = 6;
            this.btnDoneU.Text = "DONE";
            this.btnDoneU.UseVisualStyleBackColor = false;
            this.btnDoneU.Click += new System.EventHandler(this.btnDoneU_Click);
            // 
            // NameUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tlpChoose);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "NameUser";
            this.Size = new System.Drawing.Size(1154, 749);
            this.tlpChoose.ResumeLayout(false);
            this.tlpChoose.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TableLayoutPanel tlpChoose;
        private System.Windows.Forms.Button btnDoneU;
    }
}