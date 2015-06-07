namespace Refresher
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
            this.btn_SetTargetWindow = new System.Windows.Forms.Button();
            this.btn_StartRefreshing = new System.Windows.Forms.Button();
            this.btn_StopRefreshing = new System.Windows.Forms.Button();
            this.gb_SetInterval = new System.Windows.Forms.GroupBox();
            this.lbl_Seconds = new System.Windows.Forms.Label();
            this.lbl_Minutes = new System.Windows.Forms.Label();
            this.nud_Seconds = new System.Windows.Forms.NumericUpDown();
            this.nud_Minutes = new System.Windows.Forms.NumericUpDown();
            this.nud_Hours = new System.Windows.Forms.NumericUpDown();
            this.lbl_Hours = new System.Windows.Forms.Label();
            this.gb_SetKeys = new System.Windows.Forms.GroupBox();
            this.tb_Keys = new System.Windows.Forms.TextBox();
            this.lbl_Control = new System.Windows.Forms.Label();
            this.lbl_Alt = new System.Windows.Forms.Label();
            this.lbl_Shift = new System.Windows.Forms.Label();
            this.gb_SetInterval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Seconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Minutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hours)).BeginInit();
            this.gb_SetKeys.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SetTargetWindow
            // 
            this.btn_SetTargetWindow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SetTargetWindow.Location = new System.Drawing.Point(13, 156);
            this.btn_SetTargetWindow.Name = "btn_SetTargetWindow";
            this.btn_SetTargetWindow.Size = new System.Drawing.Size(261, 23);
            this.btn_SetTargetWindow.TabIndex = 0;
            this.btn_SetTargetWindow.Text = "Set Target Window";
            this.btn_SetTargetWindow.UseVisualStyleBackColor = true;
            this.btn_SetTargetWindow.Click += new System.EventHandler(this.btn_SetTargetWindow_Click);
            // 
            // btn_StartRefreshing
            // 
            this.btn_StartRefreshing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_StartRefreshing.Location = new System.Drawing.Point(13, 185);
            this.btn_StartRefreshing.Name = "btn_StartRefreshing";
            this.btn_StartRefreshing.Size = new System.Drawing.Size(261, 23);
            this.btn_StartRefreshing.TabIndex = 2;
            this.btn_StartRefreshing.Text = "Start Refreshing";
            this.btn_StartRefreshing.UseVisualStyleBackColor = true;
            this.btn_StartRefreshing.Click += new System.EventHandler(this.btn_StartRefreshing_Click);
            // 
            // btn_StopRefreshing
            // 
            this.btn_StopRefreshing.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_StopRefreshing.Location = new System.Drawing.Point(13, 214);
            this.btn_StopRefreshing.Name = "btn_StopRefreshing";
            this.btn_StopRefreshing.Size = new System.Drawing.Size(261, 23);
            this.btn_StopRefreshing.TabIndex = 3;
            this.btn_StopRefreshing.Text = "Stop Refreshing";
            this.btn_StopRefreshing.UseVisualStyleBackColor = true;
            this.btn_StopRefreshing.Click += new System.EventHandler(this.btn_StopRefreshing_Click);
            // 
            // gb_SetInterval
            // 
            this.gb_SetInterval.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SetInterval.Controls.Add(this.lbl_Seconds);
            this.gb_SetInterval.Controls.Add(this.lbl_Minutes);
            this.gb_SetInterval.Controls.Add(this.nud_Seconds);
            this.gb_SetInterval.Controls.Add(this.nud_Minutes);
            this.gb_SetInterval.Controls.Add(this.nud_Hours);
            this.gb_SetInterval.Controls.Add(this.lbl_Hours);
            this.gb_SetInterval.Location = new System.Drawing.Point(13, 13);
            this.gb_SetInterval.Name = "gb_SetInterval";
            this.gb_SetInterval.Size = new System.Drawing.Size(261, 67);
            this.gb_SetInterval.TabIndex = 4;
            this.gb_SetInterval.TabStop = false;
            this.gb_SetInterval.Text = "Set Interval";
            // 
            // lbl_Seconds
            // 
            this.lbl_Seconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Seconds.AutoSize = true;
            this.lbl_Seconds.Location = new System.Drawing.Point(175, 21);
            this.lbl_Seconds.Name = "lbl_Seconds";
            this.lbl_Seconds.Size = new System.Drawing.Size(49, 13);
            this.lbl_Seconds.TabIndex = 5;
            this.lbl_Seconds.Text = "Seconds";
            // 
            // lbl_Minutes
            // 
            this.lbl_Minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_Minutes.AutoSize = true;
            this.lbl_Minutes.Location = new System.Drawing.Point(91, 21);
            this.lbl_Minutes.Name = "lbl_Minutes";
            this.lbl_Minutes.Size = new System.Drawing.Size(44, 13);
            this.lbl_Minutes.TabIndex = 4;
            this.lbl_Minutes.Text = "Minutes";
            // 
            // nud_Seconds
            // 
            this.nud_Seconds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nud_Seconds.Location = new System.Drawing.Point(178, 37);
            this.nud_Seconds.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_Seconds.Name = "nud_Seconds";
            this.nud_Seconds.Size = new System.Drawing.Size(77, 20);
            this.nud_Seconds.TabIndex = 3;
            this.nud_Seconds.ValueChanged += new System.EventHandler(this.nud_Seconds_ValueChanged);
            // 
            // nud_Minutes
            // 
            this.nud_Minutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nud_Minutes.Location = new System.Drawing.Point(94, 37);
            this.nud_Minutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_Minutes.Name = "nud_Minutes";
            this.nud_Minutes.Size = new System.Drawing.Size(77, 20);
            this.nud_Minutes.TabIndex = 2;
            this.nud_Minutes.ValueChanged += new System.EventHandler(this.nud_Minutes_ValueChanged);
            // 
            // nud_Hours
            // 
            this.nud_Hours.Location = new System.Drawing.Point(10, 37);
            this.nud_Hours.Name = "nud_Hours";
            this.nud_Hours.Size = new System.Drawing.Size(77, 20);
            this.nud_Hours.TabIndex = 1;
            this.nud_Hours.ValueChanged += new System.EventHandler(this.nud_Hours_ValueChanged);
            // 
            // lbl_Hours
            // 
            this.lbl_Hours.AutoSize = true;
            this.lbl_Hours.Location = new System.Drawing.Point(7, 21);
            this.lbl_Hours.Name = "lbl_Hours";
            this.lbl_Hours.Size = new System.Drawing.Size(35, 13);
            this.lbl_Hours.TabIndex = 0;
            this.lbl_Hours.Text = "Hours";
            // 
            // gb_SetKeys
            // 
            this.gb_SetKeys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_SetKeys.Controls.Add(this.lbl_Shift);
            this.gb_SetKeys.Controls.Add(this.lbl_Alt);
            this.gb_SetKeys.Controls.Add(this.lbl_Control);
            this.gb_SetKeys.Controls.Add(this.tb_Keys);
            this.gb_SetKeys.Location = new System.Drawing.Point(13, 86);
            this.gb_SetKeys.Name = "gb_SetKeys";
            this.gb_SetKeys.Size = new System.Drawing.Size(261, 64);
            this.gb_SetKeys.TabIndex = 5;
            this.gb_SetKeys.TabStop = false;
            this.gb_SetKeys.Text = "Set Keys";
            // 
            // tb_Keys
            // 
            this.tb_Keys.AcceptsReturn = true;
            this.tb_Keys.AcceptsTab = true;
            this.tb_Keys.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Keys.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_Keys.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.tb_Keys.Location = new System.Drawing.Point(6, 19);
            this.tb_Keys.Name = "tb_Keys";
            this.tb_Keys.ReadOnly = true;
            this.tb_Keys.ShortcutsEnabled = false;
            this.tb_Keys.Size = new System.Drawing.Size(249, 20);
            this.tb_Keys.TabIndex = 0;
            this.tb_Keys.TabStop = false;
            this.tb_Keys.Text = "Click here to set the keys to press";
            this.tb_Keys.Enter += new System.EventHandler(this.tb_Keys_Enter);
            this.tb_Keys.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Keys_KeyDown);
            this.tb_Keys.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Keys_KeyPress);
            this.tb_Keys.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_Keys_KeyUp);
            this.tb_Keys.Leave += new System.EventHandler(this.tb_Keys_Leave);
            // 
            // lbl_Control
            // 
            this.lbl_Control.AutoSize = true;
            this.lbl_Control.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Control.Location = new System.Drawing.Point(7, 42);
            this.lbl_Control.Name = "lbl_Control";
            this.lbl_Control.Size = new System.Drawing.Size(40, 13);
            this.lbl_Control.TabIndex = 1;
            this.lbl_Control.Text = "Control";
            this.lbl_Control.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Alt
            // 
            this.lbl_Alt.AutoSize = true;
            this.lbl_Alt.Location = new System.Drawing.Point(53, 42);
            this.lbl_Alt.Name = "lbl_Alt";
            this.lbl_Alt.Size = new System.Drawing.Size(19, 13);
            this.lbl_Alt.TabIndex = 2;
            this.lbl_Alt.Text = "Alt";
            this.lbl_Alt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Shift
            // 
            this.lbl_Shift.AutoSize = true;
            this.lbl_Shift.Location = new System.Drawing.Point(78, 42);
            this.lbl_Shift.Name = "lbl_Shift";
            this.lbl_Shift.Size = new System.Drawing.Size(28, 13);
            this.lbl_Shift.TabIndex = 3;
            this.lbl_Shift.Text = "Shift";
            this.lbl_Shift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 246);
            this.Controls.Add(this.gb_SetKeys);
            this.Controls.Add(this.gb_SetInterval);
            this.Controls.Add(this.btn_StopRefreshing);
            this.Controls.Add(this.btn_StartRefreshing);
            this.Controls.Add(this.btn_SetTargetWindow);
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "MainForm";
            this.Text = "Refresher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.gb_SetInterval.ResumeLayout(false);
            this.gb_SetInterval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Seconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Minutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Hours)).EndInit();
            this.gb_SetKeys.ResumeLayout(false);
            this.gb_SetKeys.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SetTargetWindow;
        private System.Windows.Forms.Button btn_StartRefreshing;
        private System.Windows.Forms.Button btn_StopRefreshing;
        private System.Windows.Forms.GroupBox gb_SetInterval;
        private System.Windows.Forms.Label lbl_Hours;
        private System.Windows.Forms.NumericUpDown nud_Seconds;
        private System.Windows.Forms.NumericUpDown nud_Minutes;
        private System.Windows.Forms.NumericUpDown nud_Hours;
        private System.Windows.Forms.Label lbl_Seconds;
        private System.Windows.Forms.Label lbl_Minutes;
        private System.Windows.Forms.GroupBox gb_SetKeys;
        private System.Windows.Forms.TextBox tb_Keys;
        private System.Windows.Forms.Label lbl_Shift;
        private System.Windows.Forms.Label lbl_Alt;
        private System.Windows.Forms.Label lbl_Control;
    }
}

