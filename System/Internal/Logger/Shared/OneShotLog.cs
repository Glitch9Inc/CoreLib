namespace Glitch9
{
    public class OneShotLog
    {
        private const string TAG = nameof(OneShotLog);
        private string _cachedLog;

        public void Info(string log)
        {
            if (log == _cachedLog) return;
            _cachedLog = log;
            GNLog.Info(TAG, log);
        }
        public void Warning(string log)
        {
            if (log == _cachedLog) return;
            _cachedLog = log;
            GNLog.Warning(TAG, log);
        }
        public void Error(string log)
        {
            if (log == _cachedLog) return;
            _cachedLog = log;
            GNLog.Error(TAG, log);
        }

        public override string ToString() => _cachedLog;
    }
}