namespace Slot_Machine_WinForm
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.symbol1_pcbx = new System.Windows.Forms.PictureBox();
            this.symbol2_pcbx = new System.Windows.Forms.PictureBox();
            this.symbol3_pcbx = new System.Windows.Forms.PictureBox();
            this.bet_lbl = new System.Windows.Forms.Label();
            this.money_lbl = new System.Windows.Forms.Label();
            this.bet_txtbx = new System.Windows.Forms.TextBox();
            this.current_money_lbl = new System.Windows.Forms.Label();
            this.jupingPicTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.symbol1_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbol2_pcbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbol3_pcbx)).BeginInit();
            this.SuspendLayout();
            // 
            // symbol1_pcbx
            // 
            this.symbol1_pcbx.Location = new System.Drawing.Point(12, 12);
            this.symbol1_pcbx.Name = "symbol1_pcbx";
            this.symbol1_pcbx.Size = new System.Drawing.Size(217, 186);
            this.symbol1_pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.symbol1_pcbx.TabIndex = 0;
            this.symbol1_pcbx.TabStop = false;
            // 
            // symbol2_pcbx
            // 
            this.symbol2_pcbx.Location = new System.Drawing.Point(303, 12);
            this.symbol2_pcbx.Name = "symbol2_pcbx";
            this.symbol2_pcbx.Size = new System.Drawing.Size(217, 186);
            this.symbol2_pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.symbol2_pcbx.TabIndex = 1;
            this.symbol2_pcbx.TabStop = false;
            // 
            // symbol3_pcbx
            // 
            this.symbol3_pcbx.Location = new System.Drawing.Point(571, 12);
            this.symbol3_pcbx.Name = "symbol3_pcbx";
            this.symbol3_pcbx.Size = new System.Drawing.Size(217, 186);
            this.symbol3_pcbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.symbol3_pcbx.TabIndex = 2;
            this.symbol3_pcbx.TabStop = false;
            // 
            // bet_lbl
            // 
            this.bet_lbl.AutoSize = true;
            this.bet_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bet_lbl.Location = new System.Drawing.Point(32, 223);
            this.bet_lbl.Name = "bet_lbl";
            this.bet_lbl.Size = new System.Drawing.Size(197, 46);
            this.bet_lbl.TabIndex = 3;
            this.bet_lbl.Text = "Youre Bet";
            // 
            // money_lbl
            // 
            this.money_lbl.AutoSize = true;
            this.money_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.money_lbl.Location = new System.Drawing.Point(531, 223);
            this.money_lbl.Name = "money_lbl";
            this.money_lbl.Size = new System.Drawing.Size(257, 46);
            this.money_lbl.TabIndex = 4;
            this.money_lbl.Text = "Youre Money";
            // 
            // bet_txtbx
            // 
            this.bet_txtbx.Location = new System.Drawing.Point(72, 291);
            this.bet_txtbx.Name = "bet_txtbx";
            this.bet_txtbx.Size = new System.Drawing.Size(113, 20);
            this.bet_txtbx.TabIndex = 5;
            this.bet_txtbx.Text = "0";
            this.bet_txtbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bet_txtbx_KeyDown);
            // 
            // current_money_lbl
            // 
            this.current_money_lbl.AutoSize = true;
            this.current_money_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.current_money_lbl.Location = new System.Drawing.Point(620, 282);
            this.current_money_lbl.Name = "current_money_lbl";
            this.current_money_lbl.Size = new System.Drawing.Size(86, 46);
            this.current_money_lbl.TabIndex = 6;
            this.current_money_lbl.Text = "200";
            // 
            // jupingPicTimer
            // 
            this.jupingPicTimer.Enabled = true;
            this.jupingPicTimer.Interval = 10000;
            this.jupingPicTimer.Tick += new System.EventHandler(this.jupingPicTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.current_money_lbl);
            this.Controls.Add(this.bet_txtbx);
            this.Controls.Add(this.money_lbl);
            this.Controls.Add(this.bet_lbl);
            this.Controls.Add(this.symbol3_pcbx);
            this.Controls.Add(this.symbol2_pcbx);
            this.Controls.Add(this.symbol1_pcbx);
            this.Name = "MainForm";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.symbol1_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbol2_pcbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.symbol3_pcbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox symbol1_pcbx;
        private System.Windows.Forms.PictureBox symbol2_pcbx;
        private System.Windows.Forms.PictureBox symbol3_pcbx;
        private System.Windows.Forms.Label bet_lbl;
        private System.Windows.Forms.Label money_lbl;
        private System.Windows.Forms.TextBox bet_txtbx;
        private System.Windows.Forms.Label current_money_lbl;
        private System.Windows.Forms.Timer jupingPicTimer;
    }
}

