using System;
using System.Threading.Tasks;

namespace Arion.Style.Helpers
{
    public class Waiter
    {
        private bool _firstSend;
        private DateTime _startSend;
        private int _milliseconds;

        public bool IsStop { get; set; }
        public async Task Wait(int milliseconds = 100)
        {
            _milliseconds = milliseconds;
            IsStop = false;
            if (_firstSend)
                _startSend = DateTime.Now;
            await Work();
        }

        public void Stop()
        {
            IsStop = true;
            _firstSend = false;
        }

        private async Task Work()
        {
            _startSend = DateTime.Now;
            _firstSend = true;
            await Task.Run(() =>
            {
                while (true)
                {
                    if (!((DateTime.Now - _startSend).Seconds > _milliseconds / 1000.0) && _firstSend) continue;
                    IsStop = true;
                    _firstSend = false;
                    break;
                }
            });
        }
    }
}