
namespace Tools;

public static class LogManager
{
    private static string log = "Log";
    public static string GetLogByMonth()
    {
        return log + "/" + DateTime.Now.Month;
    }
    public static string GetLogByDay()
    {
        return GetLogByMonth() + "/" + DateTime.Now.Day.ToString() + ".txt";
    }
    public static void writeIntoLog(string projectName, string funcName, string message)
    {
        if (!(Directory.Exists(GetLogByMonth())))
        {
            DirectoryInfo dir1 = Directory.CreateDirectory(GetLogByMonth());
        }
        if (!File.Exists(GetLogByDay()))
        {
            File.Create(GetLogByDay()).Close();
        }
        using (StreamWriter writer = new StreamWriter(GetLogByDay(), true))
        {
            writer.WriteLine($"{DateTime.Now}\t{projectName}.{funcName}:\t{message}");
        }
    }
    public static void DeletLog()
    {
        string[] dirs = Directory.GetDirectories(log);
        for (int i = 0; i < dirs.Length - 2; i++)
        {
            Directory.Delete(dirs[i], true);
        }
    }

}
