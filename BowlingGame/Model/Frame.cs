using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingGame.Model
{
    public class Frame
    {
        public int Id { get; set; }
        public int FrameScore { get; set; }
        public bool Strike { get; set; }
        public bool Spare { get; set; }
        public int Roll1 { get; set; }
        public int Roll2 { get; set; }
        public int Roll3 { get; set; }
        public bool IsTask1 { get; set; }
        public bool IsTask2 { get; set; }
        public bool IsTask3 { get; set; }
    }
}
