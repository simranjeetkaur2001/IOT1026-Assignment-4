using Assignment.InterfaceCommand;
namespace Assignment
{static class RobotTester
    {
        public static void TestRobot()
        {
            int tc = 1;
            Robot robot = new Robot();
            Console.WriteLine("Choose total 6 commands from these commands : ");
            Console.WriteLine("ON ");
            Console.WriteLine("NORTH ");
            Console.WriteLine("SOUTH");
            Console.WriteLine("EAST");
            Console.WriteLine("WEST ");
            Console.WriteLine("OFF ");

            while (tc <= 6){
                Console.Write($"Choose {tc}s Command : ");
                string? choice = Console.ReadLine()?.ToUpper();
                RobotCommand? command = choice switch{
                    "ON" => new OnCommand(),
                    "NORTH" => new NorthCommand(),
                    "SOUTH" => new SouthCommand(),
                    "EAST" => new EastCommand(),
                    "WEST" => new WestCommand(),
                    "REBOOT" => new RebootCommand(),
                    "OFF" => new OffCommand(),
                    _ => null
                };

                if (command != null){
                    robot.LoadCommand(command);
                    tc++;
                }
                else{
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Our Robot Cannot Understand This command !");
                    Console.ResetColor();
                }
            }

            Console.WriteLine();
            robot.Run();
            Console.ReadLine();
        }
    }
}
