namespace ConsoleUI
{
    public class TableServers
    {
        // Singura modalitate de a instantia clasa este :"new TableServers()"
        private static readonly TableServers _instance = new TableServers();

        private List<string> _servers = new List<string>();
        private int _nextServer = 0;

        private TableServers()
        {
            _servers.Add("Mike");
            _servers.Add("John");
            _servers.Add("Bob");
            _servers.Add("Marry");
        }

        public static TableServers GetTableServersInstance()
        {
            return _instance;
        }

        public string GetNextServer()
        {
            string output = _servers[_nextServer];
            _nextServer++;

            if (_nextServer >= _servers.Count)
            {
                _nextServer = 0;
            }

            return output;
        }
    }
}
