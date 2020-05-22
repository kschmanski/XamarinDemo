using System;
using System.Collections.Generic;

namespace XamarinDemo.Core.Model
{

    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Pie> Pies { get; set; }
    }
}
