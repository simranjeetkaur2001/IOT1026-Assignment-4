using Assignment.InterfaceCommand;
namespace Assignment
{
    public class RobotTester
    {
        public void TestRobotCommands()
        {
            Robot robot = new Robot();
            string commandString;

            while (true)
            {
                Console.WriteLine("Enter a command ('exit' to quit):");
                commandString = Console.ReadLine();

                if (commandString.Equals("exit", StringComparison.OrdinalIgnoreCase))
                    break;

                IRobotCommand command = ConvertToCommand(commandString);
                if (command != null)
                {
                    robot.LoadCommand(command);
                    robot.Run();
                    Console.WriteLine(robot.ToString());
                }
                else
                {
                    Console.WriteLine("Invalid command. Please try again.");
                }
            }
        }

        private IRobotCommand ConvertToCommand(string commandString)
        {
            switch (commandString.ToLower())
            {
                case "on":
                    return new OnCommand();
                case "off":
                    return new OffCommand();
                case "north":
                    return new NorthCommand();
                case "south":
                    return new SouthCommand();
                case "east":
                    return new EastCommand();
                case "west":
                    return new WestCommand();
                default:
                    return null;
            }
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            RobotTester robotTester = new RobotTester();
            robotTester.TestRobotCommands();

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}