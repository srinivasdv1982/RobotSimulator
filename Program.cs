// See https://aka.ms/new-console-template for more information
using RobotSimulator.Models;
using RobotSimulator.Services;

var table = new Table(5, 5);
var robot = new Robot(table);
var processor = new CommandProcessor(robot);

string[] commands;

if (args.Length > 0)
{
    commands = File.ReadAllLines(args[0]);
}
else
{
    //commands = File.ReadAllLines("J:\\PracticePrograms\\RobotSimulator\\commands.txt");
    commands = File.ReadAllLines("C:\\commands.txt");

}

commands.All(command =>
{
    processor.ProcessCommand(command);
    return true;
});



