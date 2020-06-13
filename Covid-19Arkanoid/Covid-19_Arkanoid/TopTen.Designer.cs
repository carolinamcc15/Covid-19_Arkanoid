using System.ComponentModel;

namespace Covid_19_Arkanoid
{
    partial class TopTen
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(TopTen));
            this.tlpTop10 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvTop10 = new System.Windows.Forms.DataGridView();
            this.tlpTop10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvTop10)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpTop10
            // 
            this.tlpTop10.BackColor = System.Drawing.Color.Transparent;
            this.tlpTop10.ColumnCount = 3;
            this.tlpTop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.80139F));
            this.tlpTop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.65854F));
            this.tlpTop10.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.45296F));
            this.tlpTop10.Controls.Add(this.dgvTop10, 1, 1);
            this.tlpTop10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTop10.Font = new System.Drawing.Font("Volleyball", 9F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tlpTop10.Location = new System.Drawing.Point(0, 0);
            this.tlpTop10.Name = "tlpTop10";
            this.tlpTop10.RowCount = 3;
            this.tlpTop10.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.16925F));
            this.tlpTop10.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.31734F));
            this.tlpTop10.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.372355F));
            this.tlpTop10.Size = new System.Drawing.Size(1148, 709);
            this.tlpTop10.TabIndex = 0;
            // 
            // dgvTop10
            // 
            this.dgvTop10.AllowUserToAddRows = false;
            this.dgvTop10.AllowUserToDeleteRows = false;
            this.dgvTop10.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTop10.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTop10.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (52)))),
                ((int) (((byte) (46)))), ((int) (((byte) (55)))));
            this.dgvTop10.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTop10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTop10.Location = new System.Drawing.Point(127, 146);
            this.dgvTop10.Name = "dgvTop10";
            this.dgvTop10.ReadOnly = true;
            this.dgvTop10.RowTemplate.Height = 28;
            this.dgvTop10.Size = new System.Drawing.Size(897, 528);
            this.dgvTop10.TabIndex = 0;
            // 
            // TopTen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::Covid_19_Arkanoid.Properties.Resources.Top101;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1148, 709);
            this.Controls.Add(this.tlpTop10);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "TopTen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARKANOID";
            this.Load += new System.EventHandler(this.TopTen_Load);
            this.tlpTop10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvTop10)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpTop10;
        private System.Windows.Forms.DataGridView dgvTop10;
    }
}