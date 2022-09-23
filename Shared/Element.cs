using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Hosted.Shared
{
    public class Element
    {
        public virtual string ElementType { get; set; }

        public string Name { get; set; }

        public string Label { get; set; }
    }
}
