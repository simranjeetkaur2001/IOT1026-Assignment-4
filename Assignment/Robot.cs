﻿// Change to 'using Assignment.InterfaceCommand' when you are ready to test your interface implementation
using Assignment.InterfaceCommand;

namespace Assignment;

class Robot
{
    // These are properties, you can replace these with traditional getters/setters if you prefer.
    public int NumCommands { get; }
    public int X { get; set; }
    public int Y { get; set; }
    public bool IsPowered { get; set; }

    private const int DefaultCommands = 6;
    // An array is not the preferred data structure here.
    // You will get bonus marks if you replace the array with the preferred data structure
    // Hint: It is NOT a list either,
    private readonly RobotCommand[] _commands;
    private int _commandsLoaded = 0;

    public override string ToString()
    {
        return $"[{X} {Y} {IsPowered}]";
    }

    // You should not have to use any of the methods below here but you should
    // provide XML documentation for the argumented constructor, the Run method and one
    // of the LoadCommand methods.
    public Robot() : this(DefaultCommands) { }

    /// <summary>
    /// Constructor that initializes the robot with the capacity to store a user specified
    /// number of commands
    /// </summary>
    /// <param name="numCommands">The maximum number of commands the robot can store</param>
    public Robot(int numCommands)
    {
        _commands = new RobotCommand[numCommands];
        NumCommands = numCommands;
    }

    /// <summary>
    ///
    /// </summary>
    /// <throws> </throws>
    public bool Run()
    {
        // Is this throw a good design choice? Can you think of any alternatives?
        if (!_commands.Any()) {
            throw new InvalidOperationException("No commands have been loaded!");
            }
        else{
        foreach (var command in _commands){
            command.Run(this);
            Console.WriteLine(this);
        }
        return true;
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <param name="command"></param>
    /// <returns></returns>
    public bool LoadCommand(RobotCommand command)
    {
        if (_commandsLoaded >= NumCommands)
            return false;
        _commands[_commandsLoaded++] = command;
        return true;
    }
}
