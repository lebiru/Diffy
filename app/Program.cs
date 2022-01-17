using static SimpleExec.Command;

var exitCode = 0;
Run("compare.sh", "file1.txt file2.txt", handleExitCode: code => (exitCode = code) < 2);

var inputsAreSame = exitCode & 0;
var inputsAreDiff = exitCode & 1;
var errorWithDiff = exitCode & 2;

System.Console.WriteLine($"Inputs are same: {inputsAreSame}");
System.Console.WriteLine($"Inputs are diff: {inputsAreDiff}");
System.Console.WriteLine($"Error with diff: {errorWithDiff}");
