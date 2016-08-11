using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Core.Domain
{
    [Serializable]
    public class BaseEntity
    {
        public int ID { get; set; }
    }
}
