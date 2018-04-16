using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy.Models
{
    class Video
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Classification Classification { get; set; }
    }

    enum Classification
    {
        Silver = 1,
        Gold = 2,
        Platinum = 3,
    }
}
