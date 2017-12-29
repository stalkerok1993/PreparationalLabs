namespace Interfaces.Phone.Components
{
    public class Keyboard
    {
        public bool HasFigures { get; set; }
        public bool HasLetters { get; set; }

        public Keyboard(bool hasFigures = true, bool hasLetters = true)
        {
            HasFigures = HasFigures;
            HasLetters = HasLetters;
        }

        public override string ToString()
        {
            return "Keyboard";
        }
    }
}
