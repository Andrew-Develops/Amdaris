using ConsoleUI;

public class Program
{
    private static TableServers host1List = TableServers.GetTableServersInstance();
    private static TableServers host2List = TableServers.GetTableServersInstance();

    private static void Main(string[] args)
    {
        TableServers servers = TableServers.GetTableServersInstance();

        for (int i = 0; i < 10; i++)
        {
            //Console.WriteLine($"The next server is: {servers.GetNextServer()}");
            Host1GetNextServer();
            Host2GetNextServer();
        }

        Console.WriteLine();
    }

    public static void Host1GetNextServer()
    {
        Console.WriteLine($"The next server is: {host1List.GetNextServer()}");
    }

    public static void Host2GetNextServer()
    {
        Console.WriteLine($"The next server is: {host2List.GetNextServer()}");
    }
}