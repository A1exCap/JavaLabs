using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public interface IBird : IFlyable, IDieable
    {

    }
    public interface IFlyable
    {
        public void FlyUp(int h);
    }
    public interface IDieable
    {
        public void Die();
    }
}
