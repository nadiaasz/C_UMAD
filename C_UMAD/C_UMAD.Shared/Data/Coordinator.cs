using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_UMAD.Shared.Data
{
    internal class Coordinator :IEntity
    {
        public int Id { get; set; }
        public User? User { get; set; }
    }
}
