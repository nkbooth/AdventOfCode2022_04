namespace AdventOfCode_04
{
    class AssignmentPairs
    {
        public string? ElfOne { get; set; }
        public string? ElfTwo { get; set; }
        public int ElfOneFloor { 
            get
            {
                return int.Parse(ElfOne.Split('-')[0]);
            }
        }
        public int ElfOneCeiling {
            get
            {
                return int.Parse(ElfOne.Split('-')[1]);
            }
        }
        public int ElfTwoFloor { 
            get
            {
                return int.Parse(ElfTwo.Split('-')[0]);
            }
        
        }
        public int ElfTwoCeiling { 
            get
            {
                return int.Parse(ElfTwo.Split('-')[1]);
            }
        }
    }
}