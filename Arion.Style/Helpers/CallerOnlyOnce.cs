using System;
using System.Threading.Tasks;
using System.Windows;

namespace Arion.Style.Helpers
{
    public class CallerOnlyOnce
    {
        private Task _mainTask;
        private DateTime _timeStart;
        private Action _lastAction;
        private readonly int _milliseconds;
        
        public CallerOnlyOnce(int milliseconds = 100) => _milliseconds = milliseconds;
        
        public void CallOnce(Action action)
        {
            _lastAction = action;
            if (_mainTask == null)
            {
                _timeStart = DateTime.Now;
                _mainTask = new Task(() =>
                {
                    var dateNow = DateTime.Now;
                    while ((dateNow - _timeStart).Milliseconds + (dateNow - _timeStart).Seconds * 1000 < _milliseconds) { dateNow = DateTime.Now; }

                    Application.Current.Dispatcher.Invoke(_lastAction.Invoke);
                    _lastAction = null;
                    if (_mainTask != null && _mainTask.IsCompleted) _mainTask.Dispose();
                    _mainTask = null;
                });
                _mainTask.Start();
            }
            else
            {
                _timeStart = DateTime.Now;
            }
        }
    }
}