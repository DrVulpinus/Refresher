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
            this.components = new System.ComponentModel.Container();
            this.btn_SetTargetWindow = new System.Windows.Forms.Button();
            this.btn_StartRefreshing = new System.Windows.Forms.Button();
            this.btn_StopRefreshing = new System.Windows.Forms.Button();
            this.tmr_Refresh = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_SetTargetWindow
            // 
            this.btn_SetTargetWindow.Location = new System.Drawing.Point(12, 12);
            this.btn_SetTargetWindow.Name = "btn_SetTargetWindow";
            this.btn_SetTargetWindow.Size = new System.Drawing.Size(260, 23);
            this.btn_SetTargetWindow.TabIndex = 0;
            this.btn_SetTargetWindow.Text = "Set Target Window";
            this.btn_SetTargetWindow.UseVisualStyleBackColor = true;
            this.btn_SetTargetWindow.Click += new System.EventHandler(this.btn_SetTargetWindow_Click);
            // 
            // btn_StartRefreshing
            // 
            this.btn_StartRefreshing.Location = new System.Drawing.Point(12, 41);
            this.btn_StartRefreshing.Name = "btn_StartRefreshing";
            this.btn_StartRefreshing.Size = new System.Drawing.Size(260, 23);
            this.btn_StartRefreshing.TabIndex = 2;
            this.btn_StartRefreshing.Text = "Start Refreshing";
            this.btn_StartRefreshing.UseVisualStyleBackColor = true;
            this.btn_StartRefreshing.Click += new System.EventHandler(this.btn_StartRefreshing_Click);
            // 
            // btn_StopRefreshing
            // 
            this.btn_StopRefreshing.Location = new System.Drawing.Point(12, 70);
            this.btn_StopRefreshing.Name = "btn_StopRefreshing";
            this.btn_StopRefreshing.Size = new System.Drawing.Size(260, 23);
            this.btn_StopRefreshing.TabIndex = 3;
            this.btn_StopRefreshing.Text = "Stop Refreshing";
            this.btn_StopRefreshing.UseVisualStyleBackColor = true;
            this.btn_StopRefreshing.Click += new System.EventHandler(this.btn_StopRefreshing_Click);
            // 
            // tmr_Refresh
            // 
            this.tmr_Refresh.Enabled = true;
            this.tmr_Refresh.Interval = 5000;
            this.tmr_Refresh.Tick += new System.EventHandler(this.tmr_Refresh_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_StopRefreshing);
            this.Controls.Add(this.btn_StartRefreshing);
            this.Controls.Add(this.btn_SetTargetWindow);
            this.Name = "MainForm";
            this.Text = "Refresher";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SetTargetWindow;
        private System.Windows.Forms.Button btn_StartRefreshing;
        private System.Windows.Forms.Button btn_StopRefreshing;
        private System.Windows.Forms.Timer tmr_Refresh;
    }
}

