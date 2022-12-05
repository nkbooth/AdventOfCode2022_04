namespace AdventOfCode_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "input.txt";
            int containedAssignments = 0;
            AssignmentCollection assignmentPairs = new AssignmentCollection();
            
            Console.WriteLine("Reading input file...");
            string[] lines = File.ReadAllLines(input);

            assignmentPairs.BuildList(lines);

            Console.WriteLine(string.Format("Read {0} pairs of elves.", assignmentPairs.PairList.Count));
            
            containedAssignments = assignmentPairs.GetCompletelyOverlappedAssignmentCount();
            Console.WriteLine(string.Format("There are {0} pairs of elves with completely overlapping assignments.", containedAssignments));

            int overlappedAssignments = assignmentPairs.GetOverlappedAssignmentCount();
            Console.WriteLine(string.Format("There are {0} pairs of elves with overlapping assignments.", overlappedAssignments));
        }
    }
}