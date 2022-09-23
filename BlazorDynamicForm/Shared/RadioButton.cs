using System.Collections.Generic;

namespace BlazorDynamicForm.Shared
{
    public class RadioButton : Element
    {
        public override string ElementType { get => "RadioButton"; }

        public Dictionary<string, string> Options { get; set; }

    }
}
