using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormQuestions
{
    public abstract class UniqueID
    {
        public Guid Guid { get; set; }

        public UniqueID()
        {
            Guid = Guid.NewGuid();
        }
    }
}
