namespace WFA240918
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCatches = new Label();
            lblGameTime = new Label();
            pnl = new Panel();
            btn = new Button();
            pnl.SuspendLayout();
            SuspendLayout();
            // 
            // lblCatches
            // 
            lblCatches.AutoSize = true;
            lblCatches.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblCatches.Location = new Point(12, 9);
            lblCatches.Name = "lblCatches";
            lblCatches.Size = new Size(179, 32);
            lblCatches.TabIndex = 0;
            lblCatches.Text = "catches: 00";
            // 
            // lblGameTime
            // 
            lblGameTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblGameTime.AutoSize = true;
            lblGameTime.Font = new Font("Consolas", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblGameTime.Location = new Point(403, 9);
            lblGameTime.Name = "lblGameTime";
            lblGameTime.Size = new Size(149, 32);
            lblGameTime.TabIndex = 0;
            lblGameTime.Text = "00:00:000";
            // 
            // pnl
            // 
            pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl.BackColor = Color.Ivory;
            pnl.Controls.Add(btn);
            pnl.Location = new Point(12, 44);
            pnl.Name = "pnl";
            pnl.Size = new Size(540, 431);
            pnl.TabIndex = 1;
            // 
            // btn
            // 
            btn.BackColor = Color.Maroon;
            btn.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btn.ForeColor = Color.SeaShell;
            btn.Location = new Point(3, 3);
            btn.Name = "btn";
            btn.Size = new Size(100, 100);
            btn.TabIndex = 0;
            btn.Text = "Click me!";
            btn.UseVisualStyleBackColor = false;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 487);
            Controls.Add(pnl);
            Controls.Add(lblGameTime);
            Controls.Add(lblCatches);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(400, 400);
            Name = "FrmMain";
            Text = "Catch me!";
            pnl.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCatches;
        private Label lblGameTime;
        private Panel pnl;
        private Button btn;
    }
}
