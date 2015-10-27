using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerManager
{
    public static class Control
    {
        private static TaskManager tManager;

        public static void Intialize()
        {
            tManager = new TaskManager();
            tManager.AddTaskToTaskList();
        }
    }
}
