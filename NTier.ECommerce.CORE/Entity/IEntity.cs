using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTier.ECommerce.CORE.Entity
{
    public interface IEntity<T>//Guid
    {
        
        T ID { get; set; }

    }
}
