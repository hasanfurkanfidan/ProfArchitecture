using Hff.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hff.Entities.Concrete
{
    public class Category:IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
