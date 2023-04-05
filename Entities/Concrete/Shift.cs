using System;
using System.Collections.Generic;

namespace Entities.Concrete
{
    public partial class Shift
    {
        public int Id { get; set; }
        public int Shiftid { get; set; }
        public string? Shiftname { get; set; }
        public string? Starthour { get; set; }
        public string? Endhour { get; set; }
    }
}
