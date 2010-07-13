using System;
using System.Configuration;
using System.Text;

namespace IE_Portrait_Manager
{
    public static class Constants
    {
        /// <summary>Constant blank for height</summary>
        public const String HeightBracket = "[Height]";

        /// <summary>Constant blank for width</summary>
        public const String WidthBracket = "[Width]";

        /// <summary>Constant blank for "Blank"</summary>
        public const String Blank = "[Blank]";

        /// <summary>Constant for CSS syntax of pixels</summary>
        public const String Pixels = "px";

        /// <summary>
        ///     The WinUser.h constant for mouse wheel delta movement
        ///     http://msdn.microsoft.com/en-us/library/system.windows.forms.mouseeventargs.delta.aspx
        ///     http://connect.microsoft.com/VisualStudio/feedback/details/265810/supply-equivalent-wheel-delta-constant-for-system-windows-forms-mouseeventargs-delta
        /// </summary>
        public const Int32 WHEEL_DELTA = 120;

        
        /// <summary>Gets the game settings</summary>
        private static GameConfig games;

        /// <summary>Gets the game settings</summary>
        public static GameConfig Games
        {
            get
            {
                if(games == null)
                    PopulateGamesSettings();

                return games;
            }
        }

        private static void PopulateGamesSettings()
        {
            //pull from config file
            ConfigSections.InfinityEngineGameSettings settings = ConfigurationManager.GetSection("InfinityEngineGameSettings") as IE_Portrait_Manager.ConfigSections.InfinityEngineGameSettings;
            games = new GameConfig(settings.Games);

            ////original dimensions, hard coded
            //games = new GameConfig
            //(
            //    new GameSettings(new PortraitDimensions(210, 330), new PortraitDimensions(110, 170), new PortraitDimensions(38, 60))
            //    , new GameSettings(new PortraitDimensions(210, 330), new PortraitDimensions(110, 170), new PortraitDimensions(38, 60))
            //    , new GameSettings(new PortraitDimensions(210, 330), new PortraitDimensions(110, 170), new PortraitDimensions(36, 58))
            //    , new GameSettings(new PortraitDimensions(210, 330), new PortraitDimensions(42, 42))
            //    , new GameSettings(new PortraitDimensions(256, 400, 256, 512), new PortraitDimensions(128, 200, 128, 256), new PortraitDimensions(61, 100, 64, 128), new PortraitDimensions(32, 50, 32, 64), new PortraitDimensions(16, 25, 16, 32))
            //);
        }
    }
}