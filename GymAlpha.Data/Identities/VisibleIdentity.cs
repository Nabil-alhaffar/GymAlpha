using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymAlpha.Data
{
    public abstract class VisibleIdentity : BaseIdentity
    {
        public bool Visible { get; set; }
    }
}
