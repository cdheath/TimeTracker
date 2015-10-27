namespace TimerManager
{
    partial class TimerDisplay
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
            this.TaskGrid = new System.Windows.Forms.DataGridView();
            this.TaskButton = new System.Windows.Forms.Button();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimerControl = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TaskGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TaskGrid
            // 
            this.TaskGrid.AllowUserToAddRows = false;
            this.TaskGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.Time,
            this.TimerControl});
            this.TaskGrid.Location = new System.Drawing.Point(12, 12);
            this.TaskGrid.Name = "TaskGrid";
            this.TaskGrid.Size = new System.Drawing.Size(345, 217);
            this.TaskGrid.TabIndex = 0;
            this.TaskGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskGrid_CellContentClick);
            this.TaskGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TaskGrid_CellValueChanged);
            // 
            // TaskButton
            // 
            this.TaskButton.Location = new System.Drawing.Point(12, 236);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(345, 23);
            this.TaskButton.TabIndex = 1;
            this.TaskButton.Text = "Add Another Task";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // Task
            // 
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // TimerControl
            // 
            this.TimerControl.HeaderText = "TimerControl";
            this.TimerControl.Name = "TimerControl";
            this.TimerControl.ReadOnly = true;
            this.TimerControl.Text = "Start";
            // 
            // TimerDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 273);
            this.Controls.Add(this.TaskButton);
            this.Controls.Add(this.TaskGrid);
            this.Name = "TimerDisplay";
            this.Text = "Timer";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.TimerDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TaskGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TaskGrid;
        private System.Windows.Forms.Button TaskButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewButtonColumn TimerControl;
    }
}

