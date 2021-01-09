using System;

namespace lab3_solution
{
    public class MadScientist
    {
        public int MadScientistID {get; set;} // This is the primary key
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public int Age {get; set;}
        public DateTime LastSeen {get; set;} // Date & time this mad scientist was last seen
    }
}