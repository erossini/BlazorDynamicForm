namespace Hosted.Shared
{
    public class TextInput : Element
    {
        public override string ElementType { get => "TextInput"; }

        public string PlaceHolder { get; set; }

        public string Value { get; set; }
    }
}
