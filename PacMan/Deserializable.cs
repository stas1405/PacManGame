using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan
{
    interface Deserializable
    {
        void Deserialize(List<NameValue> list);
    }
}
