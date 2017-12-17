namespace Interfaces.Phone.Components
{
    public class Keyboard
    {
        public bool HasFigures { get; set; }
        public bool HasLetters { get; set; }

        public override string ToString()
        {
            return "Keyboard";
        }
    }
}
