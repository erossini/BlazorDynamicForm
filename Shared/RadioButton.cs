using System.Collections.Generic;

namespace Hosted.Shared
{
    public class RadioButton : Element
    {
        public override string ElementType { get => "RadioButton"; }

        public Dictionary<string, string> Options { get; set; }

    }
}
