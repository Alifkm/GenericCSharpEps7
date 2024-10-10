using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterfaceConstraint_eps_7_
{
    internal interface IEntity
    {
        public int Id { get; set; }
    }

    internal class Repository<T>  where T : IEntity  
    {
        public List<T> values = new List<T>();

        public void Add(T value)
        {
            values.Add(value);
        }
    }
}
