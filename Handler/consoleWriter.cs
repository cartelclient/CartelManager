using System;
namespace CartelManager.Handler
{
    internal class consoleWriter
    {
        public static int options = 0;

        public static void writeLogo()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            windowManager.centerText(" ▄████▄   ▄▄▄       ██▀███  ▄▄▄█████▓▓█████  ██▓    ");
            windowManager.centerText("▒██▀ ▀█  ▒████▄    ▓██ ▒ ██▒▓  ██▒ ▓▒▓█   ▀ ▓██▒    ");
            windowManager.centerText("▒▓█    ▄ ▒██  ▀█▄  ▓██ ░▄█ ▒▒ ▓██░ ▒░▒███   ▒██░    ");
            windowManager.centerText("▒▓▓▄ ▄██▒░██▄▄▄▄██ ▒██▀▀█▄  ░ ▓██▓ ░ ▒▓█  ▄ ▒██░    ");
            windowManager.centerText("▒ ▓███▀ ░ ▓█   ▓██▒░██▓ ▒██▒  ▒██▒ ░ ░▒████▒░██████▒");
            windowManager.centerText("░ ░▒ ▒  ░ ▒▒   ▓▒█░░ ▒▓ ░▒▓░  ▒ ░░   ░░ ▒░ ░░ ▒░▓  ░");
            windowManager.centerText("  ░  ▒     ▒   ▒▒ ░  ░▒ ░ ▒░    ░     ░ ░  ░░ ░ ▒  ░");
            windowManager.centerText("░          ░   ▒     ░░   ░   ░         ░     ░ ░   ");
            windowManager.centerText("░ ░            ░  ░   ░                 ░  ░    ░  ░");
            windowManager.centerText("░                                                  ");
            Console.ForegroundColor = ConsoleColor.White;
        }


        public static void optionsWriter(string text)
        {
            options++;
            Console.WriteLine($"{options}.) {text}");

        }

        public static void resetOptions()
        {
            options = 0;
        }
    }
}