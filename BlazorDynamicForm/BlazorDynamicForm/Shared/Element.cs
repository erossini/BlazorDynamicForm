using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorDynamicForm.Shared
{
    public class Element
    {
        public virtual string ElementType { get; set; }

        public string Name { get; set; }

        public string Label { get; set; }
    }
}
