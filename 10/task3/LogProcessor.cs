namespace task3
{
    public class LogProcessor
    {
        private List<LogEntry> _logEntries;

        public LogProcessor(List<LogEntry> logEntries)
        {
            _logEntries = logEntries;
        }

        public IEnumerable<LogEntry> FilterLogsByDate(DateTime fromDate, DateTime toDate)
        {
            return _logEntries.Where(log => log.Date >= fromDate && log.Date <= toDate);
        }
    }
}
