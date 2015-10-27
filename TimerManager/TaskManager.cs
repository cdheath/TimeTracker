using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerManager
{
    class TaskManager
    {
        private List<Task> taskList = new List<Task>();

        public void AddTaskToTaskList()
        {
            var tempTask = new Task();
            taskList.Add(tempTask);
        }
        public void SetTaskName(int ele, string name)
        {
            taskList.ElementAt(ele).name = name;
        }
        public string GetTaskName(int ele)
        {
            return taskList.ElementAt(ele).name;
        }
        private void StartTimer(int ele)
        {
            taskList.ElementAt(ele).StartTimer();
        }
        private void StopTimer(int ele)
        {
            taskList.ElementAt(ele).StopTimer();
        }
        public string GetTime(int ele)
        {
            return taskList.ElementAt(ele).GetTime();
        }
        public string ToggleButton(int ele)
        {
            if (taskList.ElementAt(ele).started == true)
            {
                StopTimer(ele);
                return "Start";
            }
            else
            {
                StartTimer(ele);
                return "Stop";
            }
        }
    }
    
}
