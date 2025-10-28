using BigLog;
namespace BigLog_testing_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger()
            {
                LogToFile = false,
                LogToTerminal = true,
                ColorAll = false,
                ColorLevelPrefix = false,
                ColorMessage = true
            };
            logger.Inf("this is an info");
            logger.Suc("this is success");
            logger.War("this is a warning");
            logger.Err("this is an error");
            logger.Ctm("this is a custom message");
        }
    }
}
