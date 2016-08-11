using CarManager.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Data.Model
{
    [Serializable]
    public class Car : BaseEntity
    {
        public Car()
        {
            this.CreatTime = DateTime.Now;
        }

        //[MaxLength(10)]
        public string Name { get; set; }

        //[Display(Name = "价格")]
        public decimal Price { get; set; }

        //[DisplayName("创建时间")]
        public DateTime CreatTime { get; set; }
    }
}
