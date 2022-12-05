namespace AdventOfCode_04
{
    class AssignmentCollection
    {
        public List<AssignmentPairs> PairList = new List<AssignmentPairs>();

        public void BuildList(string[] lines)
        {
            foreach (string line in lines)
            {
                string[] splitLine = line.Split(',');
                AssignmentPairs assignmentPair = new AssignmentPairs();
                assignmentPair.ElfOne = splitLine[0];
                assignmentPair.ElfTwo = splitLine[1];
                PairList.Add(assignmentPair);
            }
        }

        public int GetCompletelyOverlappedAssignmentCount()
        {
            int containedAssignments = 0;
            foreach (AssignmentPairs pair in PairList)
            {
                if ((pair.ElfOneFloor >= pair.ElfTwoFloor && pair.ElfOneCeiling <= pair.ElfTwoCeiling) || (pair.ElfTwoFloor >= pair.ElfOneFloor && pair.ElfTwoCeiling <= pair.ElfOneCeiling))
                {
                    containedAssignments++;
                }
            }

            return containedAssignments;
        }
        public int GetOverlappedAssignmentCount()
        {
            int containedAssignments = 0;
            foreach (AssignmentPairs pair in PairList)
            {
                if ((pair.ElfOneFloor >= pair.ElfTwoFloor && pair.ElfOneFloor <= pair.ElfTwoCeiling) || (pair.ElfTwoFloor >= pair.ElfOneFloor && pair.ElfTwoFloor <= pair.ElfOneCeiling))
                {
                    containedAssignments++;
                }
            }

            return containedAssignments;
        }
    }
}