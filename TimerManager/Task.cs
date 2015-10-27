using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimerManager
{
    class Task
    {
        public string name { get; set; }
        private readonly Stopwatch _timer;
        public bool started { get; set; }

        public Task()
        {
            _timer = new Stopwatch();
        }
         public void StartTimer()
         {
          _timer.Start();
             started = true;
         }
        public void StopTimer()
        {
            _timer.Stop();
            started = false;
        }
        public string GetTime()
        {
            return  _timer.Elapsed.ToString().Substring(0,8);
        }
    }
}
