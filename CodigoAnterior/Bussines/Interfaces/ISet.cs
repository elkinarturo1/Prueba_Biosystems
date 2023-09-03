using Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussines.Interfaces
{
    public interface ISet
    {       
        public void startSet(SetModel setModel);
        public void stopSet(SetModel setModel);
    }
}
