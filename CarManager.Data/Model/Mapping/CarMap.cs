using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManager.Data.Model.Mapping
{
    public class CarMap : EntityTypeConfiguration<Car>
    {
        public CarMap()
        {
            this.HasKey(x => x.ID);
            this.Property(x => x.Name).HasMaxLength(32);
        }
    }
}
