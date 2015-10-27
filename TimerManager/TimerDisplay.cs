using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;


namespace TimerManager
{
    public partial class TimerDisplay : Form
    {
        private TaskManager _tManager;
        private readonly Timer tmr = new Timer(1000);

        public TimerDisplay()
        {
            InitializeComponent();
        }

        private void TimerDisplay_Load(object sender, EventArgs e)
        {
            _tManager = new TaskManager();
            _tManager.AddTaskToTaskList();
            tmr.Elapsed += UpdateTime;
            tmr.Enabled = true;
            GC.KeepAlive(tmr);
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            _tManager.AddTaskToTaskList();
            TaskGrid.Rows.Add(1);
            TaskGrid.Rows[TaskGrid.Rows.Count - 1].Cells["TimerControl"].Value = "Start";
        }

        private void TaskGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                UpdateGridNames();
            }
        }
        private void UpdateGridNames()
        {
            SetNames();
            GetNames();
        }
        private void SetNames()
        {
            for (int i = 0; i <= TaskGrid.Rows.Count - 1; i++)
            {
                string tempName = TaskGrid.Rows[i].Cells["Task"].Value.ToString(); 
                _tManager.SetTaskName(i, tempName);
            }
        }
        private void GetNames()
        {
            for (int i = 0; i < TaskGrid.Rows.Count - 1; i++)
            {
                TaskGrid.Rows[i].Cells["Task"].Value = _tManager.GetTaskName(i);
            }
        }
        private void UpdateTime(object source, ElapsedEventArgs e)
        {
            GetTimes();
        }
        private void GetTimes()
        {
            for (int i = 0; i <= TaskGrid.Rows.Count - 1; i++)
            {
                TaskGrid.Rows[i].Cells["Time"].Value = _tManager.GetTime(i);
            }
        }

        private void TaskGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 2 && e.RowIndex >= 0)
            {
                TaskGrid.Rows[e.RowIndex].Cells["TimerControl"].Value = _tManager.ToggleButton(e.RowIndex);
                TaskGrid.Rows[e.RowIndex].Cells["Time"].Value = _tManager.GetTime(e.RowIndex);
            }
        }
    }
}
