using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Chores.Models
{
    public class Chore
    {
        public Chore(int id, string name, int time, string difficulty, bool finished)
        {
            Id = id;
            Name = name;
            Time = time;
            Difficulty = difficulty;
            Finished = finished;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Time { get; set; }
        public string Difficulty { get; set; }
        public bool Finished { get; set; }
    }
}