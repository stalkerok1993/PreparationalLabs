using Interfaces.Phone;
using System;
using System.Collections.Generic;
using Interfaces.Output;
using Interfaces.Phone.Components.Charger;
using Interfaces.Phone.Components.Playback;

namespace InterfacesConsole
{
    class Program
    {
        private class AbstractCreator<T>
        {
            public delegate T GenericCreator();
            public string Name { get; set; }
            public GenericCreator Creator { get; set; }
            public bool IsConfirmationNeeded { get; set; }
        }

        public static IOutput output = new ConsoleOutput();
        //public static IOutput output = new FileOutput(new System.IO.StreamWriter("output.txt"));

        private static Dictionary<char, AbstractCreator<PlaybackBase>> playbackCreators = new Dictionary<char, AbstractCreator<PlaybackBase>>()
        {
            {'1', new AbstractCreator<PlaybackBase>() {Name = "External speaker", Creator = () => new ExternalSpeaker(output)} },
            {'2', new AbstractCreator<PlaybackBase>() {Name = "iPhone headset", Creator = () => new IphoneHeadset(output)} },
            {'3', new AbstractCreator<PlaybackBase>() {Name = "Samsung headset", Creator = () => new SamsungHeadset(output)} },
            {'4', new AbstractCreator<PlaybackBase>() {Name = "Unofficial iPhone headset", Creator = () => new UnofficialIphoneHeadset(output)} },
            {'0', new AbstractCreator<PlaybackBase>() {Name = "Unplug playback", Creator = () => null, IsConfirmationNeeded = true} },
        };

        private static Dictionary<char, AbstractCreator<ChargerBase>> chargerCreators = new Dictionary<char, AbstractCreator<ChargerBase>>()
        {
            {'1', new AbstractCreator<ChargerBase>() {Name = "Fast charger", Creator = () => new FastCharger(output)} },
            {'2', new AbstractCreator<ChargerBase>() {Name = "USB charger", Creator = () => new UsbCharger(output)} },
            {'0', new AbstractCreator<ChargerBase>() {Name = "Unplug charger", Creator = () => null, IsConfirmationNeeded = true} }
        };

        private const char DEVICE_HEADPHONES = '1';
        private const char DEVICE_CHARGER = '2';

        private const char CANCEL = '0';
        private const char ACCEPT = '1';

        private static bool ConfirmationPopup(string message)
        {
            if (message?.Length > 0)
            {
                Console.WriteLine(message);
            }
            Console.WriteLine("Are you sure?");
            Console.WriteLine($"{ACCEPT} - ACCEPT");
            Console.WriteLine($"{CANCEL} - ABORT");

            var keyInfo = Console.ReadKey();
            Console.WriteLine();

            switch (keyInfo.KeyChar)
            {
                case ACCEPT:
                    return true;
                case CANCEL:
                    return false;
                default:
                    Console.WriteLine("Wrong input, try again . . .");
                    return ConfirmationPopup(message);
            }
        }

        private static char ChooseCreator<T>(string message, Dictionary<char, AbstractCreator<T>> creators)
        {
            Console.WriteLine(message);
            foreach (var key in creators.Keys)
            {
                Console.WriteLine($"{key} - {creators[key].Name}");
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();

            char choice = keyInfo.KeyChar;
            if (!creators.ContainsKey(choice))
            {
                Console.WriteLine("Wrong input, try again . . .");
                return ChooseCreator(message, creators);
            }

            if (creators[choice].IsConfirmationNeeded)
            {
                ConfirmationPopup("You're about to unplug peripherials.");
            }

            return choice;
        }

        public static void Main(string[] args)
        {
            var mobile = new ModernMobile(output);

            while (true)
            {
                Console.WriteLine("\n============================");
                Console.WriteLine("Select device: (Esc to exit)");
                Console.WriteLine($"{DEVICE_HEADPHONES} - Headphones");
                Console.WriteLine($"{DEVICE_CHARGER} - Charger");

                ConsoleKeyInfo userInput = Console.ReadKey();
                Console.WriteLine();
                if (userInput.Key == ConsoleKey.Escape)
                {
                    if (!ConfirmationPopup("You are going to exit."))
                    {
                        continue;
                    }
                    return;
                }

                switch (userInput.KeyChar)
                {
                    case DEVICE_HEADPHONES:
                        AbstractCreator<PlaybackBase> playbackCreator = playbackCreators[ChooseCreator("Choose playback:", playbackCreators)];
                        mobile.PlaybackComponent = playbackCreator.Creator.Invoke();

                        mobile.Play(new object());
                        break;
                    case DEVICE_CHARGER:
                        AbstractCreator<ChargerBase> chargerCreator = chargerCreators[ChooseCreator("Choose charger:", chargerCreators)];
                        ChargerBase charger = chargerCreator.Creator.Invoke();

                        charger?.Charge(mobile);
                        break;
                    default:
                        Console.WriteLine("Unexpected input. Please try again.");
                        continue;
                }
            }
        }

        
    }
}
