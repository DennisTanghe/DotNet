using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DT.DotNet.BL
{
    public enum EntityStateOption
    {
        Active,
        Deleted
    }

    public abstract class EntityBase // cannot be instantiated but only used to inherrit from <=> sealed (=cannot be inherrited from), no keyword is normal or concrete class
    {
        // could use protected so that only classes in the library can use this

        protected string ImProtected { get; set; }

        public EntityStateOption EntityState { get; set; }

        public bool IsNew { get; private set; } 

        public bool HasChanges { get; set;}

        public bool IsValid => Validate();

        public abstract bool Validate(); // contains no implementation and have to overridden

        public virtual bool Validate(bool useVirtual) // contains a default implementation and can be overridden
        {
            return true;
        }

        public bool Validate(string thisIsMine) // method is sealed by default and cannot be overridden
        {
            return true;
        }
    }
}
