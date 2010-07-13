using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace IE_Portrait_Manager
{
    /// <summary>Simple enum declaring the inteded format of the output portrait set</summary>
    public enum GamePortraitFormat : byte
    {
        Bitmap = 0,
        Targa = 1
    }

    /// <summary>Infinity Engine-ish games, enumerated</summary>
    public enum Game : byte
    {
        PlanescapeTorment = 0,
        BaldursGate,
        BaldursGate2,
        IcewindDale,
        IcewindDale2,
        NeverwinterNights
    }

    /// <summary>Enum for the size of a portait. I want to use a byte to keep it simple.</summary>
    public enum PortraitSize : byte
    {
        NULL = 0x0,
        Small,
        Medium,
        Giant,
        Large,
        Tiny,
        Source
    }

    /// <summary>Object that describes a collection of images relating to a single portrait.</summary>
    public class PortraitListItem
    {
        #region Protected Members
        /// <summary>Collection of the PortraitDetails for all images</summary>
        protected Dictionary<PortraitSize, PortraitDetail> images;

        /// <summary>Common file name prefix of the portrait set.</summary>
        protected String commonName;

        /// <summary>String prefix of the imageset. Must be 7 or less characters, since resources must be of the 8.3 filename family.</summary>
        protected String intendedPrefix;
        #endregion

        #region Public Properties
        /// <summary>Collection of the PortraitDetails for all images</summary>
        public Dictionary<PortraitSize, PortraitDetail> Images
        {
            get { return images; }
            set { images = value; }
        }

        /// <summary>Common file name prefix of the portrait set.</summary>
        public String CommonName
        {
            get { return commonName; }
            set { commonName = value; }
        }

        /// <summary>String prefix of the imageset. Must be 7 or less characters, since resources must be of the 8.3 filename family.</summary>
        public String IntendedPrefix
        {
            get { return intendedPrefix; }
            set { intendedPrefix = value; }
        }
        #endregion

        #region Public Methods
        /// <summary>Overridden ToString() method that returns the portrait collection's common name</summary>
        /// <returns>Returns the member common name as a String</returns>
        public override String ToString()
        {
            return this.commonName;
        }
        #endregion

        #region Constructor(s)
        /// <summary>Default Constructor</summary>
        public PortraitListItem()
        {
            images = new Dictionary<PortraitSize, PortraitDetail>();
            images[PortraitSize.Source] = new PortraitDetail();
            images[PortraitSize.Giant] = new PortraitDetail();
            images[PortraitSize.Large] = new PortraitDetail();
            images[PortraitSize.Small] = new PortraitDetail();
            commonName = String.Empty;
            intendedPrefix = String.Empty;
        }
        #endregion
    }

    /// <summary>Structure used to describe both the Size of and Prefix name of the portrait image.</summary>
    public class PortraitDetail
    {
        #region Protected Members
        /// <summary>Size (in Infinity Engine terms) of the portrait</summary>
        protected PortraitSize size;

        /// <summary>String prefix describing the name of the portrait</summary>
        protected String prefix;

        /// <summary>Int32 describing the width of the portrait.</summary>
        protected Int32 width;

        /// <summary>Int32 describing the height of the portrait.</summary>
        protected Int32 height;

        /// <summary>Actual filename of the portrait image.</summary>
        protected String fileName;

        /// <summary>Options for the image, dictating how to display it</summary>
        protected PortraitWarp imageOptions;

        /// <summary>Flag indicating whether this image should be rendered from source rather than froma file</summary>
        protected Boolean renderFromSource;
        #endregion

        #region Public Properties
        /// <summary>Size (in Infinity Engine terms) of the portrait</summary>
        public PortraitSize Size
        {
            get { return size; }
            set { size = value; }
        }

        /// <summary>String prefix describing the name of the portrait</summary>
        public String Prefix
        {
            get { return prefix; }
            set { prefix = value; }
        }

        /// <summary>Int32 describing the width of the portrait.</summary>
        public Int32 Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary>Int32 describing the height of the portrait.</summary>
        public Int32 Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>Actual filename of the portrait image.</summary>
        public String FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        /// <summary>Options for the image, dictating how to display it</summary>
        public PortraitWarp ImageOptions
        {
            get { return imageOptions; }
            set { imageOptions = value; }
        }

        /// <summary>
        ///     Flag indicating whether this image should be rendered from source rather than froma file
        ///     This value is true if the filename is unset OR if the flag has been set already.
        /// </summary>
        public Boolean RenderFromSource
        {
            get
            {
                return String.IsNullOrEmpty(this.fileName) | renderFromSource; //if it is null or empty, then yes. If it is set, then yes
            }
            set { renderFromSource = value; }
        }
        #endregion

        #region Constructor(s)
        /// <summary>Default constructor</summary>
        public PortraitDetail()
        {
            size = PortraitSize.NULL;
            prefix = String.Empty;
            width = -1;
            height = -1;
            fileName = null;
            imageOptions = new PortraitWarp();
            renderFromSource = false;
        }

        /// <summary>Portrait prefix constructor</summary>
        /// <param name="PortraitPrefix">String describing the portrait prefix</param>
        public PortraitDetail(String PortraitPrefix)
        {
            size = PortraitSize.NULL;
            prefix = PortraitPrefix;
            width = -1;
            height = -1;
            fileName = null;
            imageOptions = new PortraitWarp();
            renderFromSource = false;
        }
        #endregion

        #region Static Methods
        /// <summary>This method will take in a portrait size descriptor ("G", "L", "S") and return an appropriate PortraitSize enum instance corresponding to this descriptor.</summary>
        /// <param name="PortraitSizeDescriptor">String descriptor of the portrait size</param>
        /// <returns>A PortraitSize enum object indicating the portrait size</returns>
        public static PortraitSize GetPortraitSize(String PortraitSizeDescriptor)
        {
            PortraitSize size;
            switch (PortraitSizeDescriptor.ToUpper())
            {
                case "L":
                    size = PortraitSize.Medium;
                    break;
                case "S":
                    size = PortraitSize.Small;
                    break;
                case "G":
                    size = PortraitSize.Giant;
                    break;
                default:
                    size = PortraitSize.NULL;
                    break;
            }

            return size;
        }
        #endregion

        #region Public Methods
        /// <summary>Overridden ToString() method that returns the portrait collection's prefix</summary>
        /// <returns>Returns the member prefix as a String</returns>
        public override String ToString()
        {
            return this.prefix;
        }
        #endregion
    }

    /// <summary>Simple struct containing the height and width of a portrait</summary>
    public class PortraitDimensions
    {
        #region Protected Members
        /// <summary>Visible width of the portrait</summary>
        protected Int32 width;

        /// <summary>Visible height of the portrait</summary>
        protected Int32 height;

        /// <summary>Actual width of the portrait generated</summary>
        protected Int32 actualWidth;

        /// <summary>Actual height of the portrait</summary>
        protected Int32 actualHeight;
        #endregion

        #region Public Properties
        /// <summary>Width of the portrait</summary>
        public Int32 Width
        {
            get { return width; }
            set { width = value; }
        }

        /// <summary>Height of the portrait</summary>
        public Int32 Height
        {
            get { return height; }
            set { height = value; }
        }

        /// <summary>Actual width of the portrait generated</summary>
        public Int32 ActualWidth
        {
            get { return actualWidth; }
            set { actualWidth = value; }
        }

        /// <summary>Actual height of the portrait</summary>
        public Int32 ActualHeight
        {
            get { return actualHeight; }
            set { actualHeight = value; }
        }
        #endregion

        #region Constructor(s)
        /// <summary>Default constructor</summary>
        public PortraitDimensions()
        {
            width = 0;
            height = 0;
            actualHeight = 0;
            actualWidth = 0;
        }

        /// <summary>Full initializing constructor</summary>
        public PortraitDimensions(Int32 Width, Int32 Height)
        {
            width = Width;
            height = Height;
            actualHeight = Height;
            actualWidth = Width;
        }

        /// <summary>Neverwinter Nights initializing constructor</summary>
        public PortraitDimensions(Int32 Width, Int32 Height, Int32 ActualWidth, Int32 ActualHeight)
        {
            width = Width;
            height = Height;
            actualHeight = ActualHeight;
            actualWidth = ActualWidth;
        }

        /// <summary>Config file initializing constructor</summary>
        public PortraitDimensions(ConfigSections.Portrait PortraitSettings)
        {
            width = PortraitSettings.Width;
            height = PortraitSettings.Height;
            actualHeight = PortraitSettings.ActualHeight == 0 ? PortraitSettings.Height : PortraitSettings.ActualHeight;
            actualWidth = PortraitSettings.ActualWidth == 0 ? PortraitSettings.Width : PortraitSettings.ActualWidth;
        }
        #endregion
    }

    public class GameSettings
    {
        #region Protected members
        /// <summary>Dictionary collection of PortraitDimensions based on PortraitSize keys</summary>
        protected Dictionary<PortraitSize, PortraitDimensions> portraits;

        /// <summary>Output format the game requires</summary>
        protected GamePortraitFormat imageFormat;
        #endregion

        #region Public Properties
        /// <summary>Dictionary collection of PortraitDimensions based on PortraitSize keys</summary>
        public Dictionary<PortraitSize, PortraitDimensions> Portraits
        {
            get { return portraits; }
            set { portraits = value; }
        }

        /// <summary>Output format the game requires</summary>
        public GamePortraitFormat ImageFormat
        {
            get { return imageFormat; }
            set { imageFormat = value; }
        }
        #endregion

        #region Constructor(s)
        /// <summary>Default constructor</summary>
        public GameSettings()
        {
            ConstructorDefault();
        }

        /// <summary>Infinity Engine constructor</summary>
        public GameSettings(PortraitDimensions Giant, PortraitDimensions Large, PortraitDimensions Small)
        {
            ConstructorInfinityEngineDefault(Giant, Large, Small);
        }

        /// <summary>Icewind Dale II constructor</summary>
        public GameSettings(PortraitDimensions Large, PortraitDimensions Small)
        {
            ConstructorIcewindDale2(Large, Small);
        }

        /// <summary>Neverwinter Nights constructor</summary>
        public GameSettings(PortraitDimensions Giant, PortraitDimensions Large, PortraitDimensions Medium, PortraitDimensions Small, PortraitDimensions Tiny)
        {
            ConstructorNeverwinterNights(Giant, Large, Medium, Small, Tiny);
        }

        /// <summary>Configuration file constructor</summary>
        public GameSettings(ConfigSections.Game GameSettings)
        {
            switch (GameSettings.Name)
            {
                case "BaldursGate":
                case "BaldursGate2":
                case "IcewindDale":
                    ConstructorInfinityEngineDefault(GameSettings["Giant"], GameSettings["Large"], GameSettings["Small"]);
                    break;
                case "IcewindDale2":
                    ConstructorIcewindDale2(GameSettings["Large"], GameSettings["Small"]);
                    break;
                case "NeverwinterNights":
                    ConstructorNeverwinterNights(GameSettings["Giant"], GameSettings["Large"], GameSettings["Medium"], GameSettings["Small"], GameSettings["Tiny"]);
                    break;
            }
        }
        #endregion

        #region Custructor Logic
        /// <summary>Default constructor logic</summary>
        protected void ConstructorDefault()
        {
            portraits = new Dictionary<PortraitSize, PortraitDimensions>();
            imageFormat = GamePortraitFormat.Bitmap;
        }

        /// <summary>Default Infinity Engine constructor logic</summary>
        /// <param name="Giant">Giant PortraitDimensions</param>
        /// <param name="Large">Large PortraitDimensions</param>
        /// <param name="Small">Small PortraitDimensions</param>
        protected void ConstructorInfinityEngineDefault(PortraitDimensions Giant, PortraitDimensions Large, PortraitDimensions Small)
        {
            portraits = new Dictionary<PortraitSize, PortraitDimensions>();
            portraits[PortraitSize.Giant] = Giant;
            portraits[PortraitSize.Large] = Large;
            portraits[PortraitSize.Small] = Small;
            imageFormat = GamePortraitFormat.Bitmap;
        }

        /// <summary>Default Infinity Engine constructor logic</summary>
        /// <param name="Giant">ConfigSections.Portrait describing Giant PortraitDimensions</param>
        /// <param name="Large">ConfigSections.Portrait describing Large PortraitDimensions</param>
        /// <param name="Small">ConfigSections.Portrait describing Small PortraitDimensions</param>
        protected void ConstructorInfinityEngineDefault(ConfigSections.Portrait Giant, ConfigSections.Portrait Large, ConfigSections.Portrait Small)
        {
            portraits = new Dictionary<PortraitSize, PortraitDimensions>();
            portraits[PortraitSize.Giant] = new PortraitDimensions(Giant);
            portraits[PortraitSize.Large] = new PortraitDimensions(Large);
            portraits[PortraitSize.Small] = new PortraitDimensions(Small);
            imageFormat = GamePortraitFormat.Bitmap;
        }

        /// <summary>Icewind Dale II constructor logic</summary>
        /// <param name="Large">Large PortraitDimensions</param>
        /// <param name="Small">Small PortraitDimensions</param>
        protected void ConstructorIcewindDale2(PortraitDimensions Large, PortraitDimensions Small)
        {
            portraits = new Dictionary<PortraitSize, PortraitDimensions>();
            portraits[PortraitSize.Giant] = Large;      //same
            portraits[PortraitSize.Large] = Large;      //same
            portraits[PortraitSize.Small] = Small;
            imageFormat = GamePortraitFormat.Bitmap;
        }

        /// <summary>Icewind Dale II constructor logic</summary>
        /// <param name="Large">ConfigSections.Portrait describing Large PortraitDimensions</param>
        /// <param name="Small">ConfigSections.Portrait describing Small PortraitDimensions</param>
        protected void ConstructorIcewindDale2(ConfigSections.Portrait Large, ConfigSections.Portrait Small)
        {
            portraits = new Dictionary<PortraitSize, PortraitDimensions>();
            portraits[PortraitSize.Giant] = new PortraitDimensions(Large);      //same
            portraits[PortraitSize.Large] = new PortraitDimensions(Large);      //same
            portraits[PortraitSize.Small] = new PortraitDimensions(Small);
            imageFormat = GamePortraitFormat.Bitmap;
        }

        /// <summary>Neverwinter Nights constructor logic</summary>
        /// <param name="Giant">Giant PortraitDimensions</param>
        /// <param name="Large">Large PortraitDimensions</param>
        /// <param name="Medium">Medium PortraitDimensions</param>
        /// <param name="Small">Small PortraitDimensions</param>
        /// <param name="Tiny">Tiny PortraitDimensions</param>
        protected void ConstructorNeverwinterNights(PortraitDimensions Giant, PortraitDimensions Large, PortraitDimensions Medium, PortraitDimensions Small, PortraitDimensions Tiny)
        {
            portraits = new Dictionary<PortraitSize, PortraitDimensions>();
            portraits[PortraitSize.Giant] = Giant;
            portraits[PortraitSize.Large] = Large;
            portraits[PortraitSize.Medium] = Medium;
            portraits[PortraitSize.Small] = Small;
            portraits[PortraitSize.Tiny] = Tiny;
            imageFormat = GamePortraitFormat.Targa;
        }

        /// <summary>Neverwinter Nights constructor logic</summary>
        /// <param name="Giant">ConfigSections.Portrait describing Giant PortraitDimensions</param>
        /// <param name="Large">ConfigSections.Portrait describing Large PortraitDimensions</param>
        /// <param name="Medium">ConfigSections.Portrait describing Medium PortraitDimensions</param>
        /// <param name="Small">ConfigSections.Portrait describing Small PortraitDimensions</param>
        /// <param name="Tiny">ConfigSections.Portrait describing Tiny PortraitDimensions</param>
        protected void ConstructorNeverwinterNights(ConfigSections.Portrait Giant, ConfigSections.Portrait Large, ConfigSections.Portrait Medium, ConfigSections.Portrait Small, ConfigSections.Portrait Tiny)
        {
            portraits = new Dictionary<PortraitSize, PortraitDimensions>();
            portraits[PortraitSize.Giant] = new PortraitDimensions(Giant);
            portraits[PortraitSize.Large] = new PortraitDimensions(Large);
            portraits[PortraitSize.Medium] = new PortraitDimensions(Medium);
            portraits[PortraitSize.Small] = new PortraitDimensions(Small);
            portraits[PortraitSize.Tiny] = new PortraitDimensions(Tiny);
            imageFormat = GamePortraitFormat.Targa;
        }
        #endregion
    }

    /// <summary>Class containing GameSettings for Infinity Engine games</summary>
    public class GameConfig
    {
        #region Protected Members
        /// <summary>Settings for Baldur's Gate</summary>
        protected GameSettings baldursGate;

        /// <summary>Settings for Baldur's Gate II</summary>
        protected GameSettings baldursGate2;

        /// <summary>Settings for Icewind Dale</summary>
        protected GameSettings icewindDale;

        /// <summary>Settings for Icewind Dale II</summary>
        protected GameSettings icewindDale2;

        /// <summary>Settings for Neverwinter Nights</summary>
        protected GameSettings neverwinterNights;

        /// <summary>Settings for Planescape: Torment</summary>
        protected GameSettings planescapeTorment;
        #endregion

        #region Public Properties
        /// <summary>Settings for Baldur's Gate</summary>
        public GameSettings BaldursGate
        {
            get { return baldursGate; }
            set { baldursGate = value; }
        }

        /// <summary>Settings for Baldur's Gate II</summary>
        public GameSettings BaldursGate2
        {
            get { return baldursGate2; }
            set { baldursGate2 = value; }
        }

        /// <summary>Settings for Icewind Dale</summary>
        public GameSettings IcewindDale
        {
            get { return icewindDale; }
            set { icewindDale = value; }
        }

        /// <summary>Settings for Icewind Dale II</summary>
        public GameSettings IcewindDale2
        {
            get { return icewindDale2; }
            set { icewindDale2 = value; }
        }

        /// <summary>Settings for Neverwinter Nights</summary>
        public GameSettings NeverwinterNights
        {
            get { return neverwinterNights; }
            set { neverwinterNights = value; }
        }
        #endregion

        #region Constructor(s)
        /// <summary>Default constructor</summary>
        public GameConfig()
        {
            baldursGate = null;
            baldursGate2 = null;
            icewindDale = null;
            icewindDale2 = null;
            neverwinterNights = null;
            planescapeTorment = null;
        }

        /// <summary>Basic constructor</summary>
        public GameConfig(GameSettings BaldursGate, GameSettings BaldursGate2, GameSettings IcewindDale, GameSettings IcewindDale2, GameSettings NeverwinterNights)
        {
            baldursGate = BaldursGate;
            baldursGate2 = BaldursGate2;
            icewindDale = IcewindDale;
            icewindDale2 = IcewindDale2;
            neverwinterNights = NeverwinterNights;
            planescapeTorment = null;
        }

        /// <summary>Full constructor</summary>
        public GameConfig(GameSettings BaldursGate, GameSettings BaldursGate2, GameSettings IcewindDale, GameSettings IcewindDale2, GameSettings NeverwinterNights, GameSettings PlanescapeTorment)
        {
            baldursGate = BaldursGate;
            baldursGate2 = BaldursGate2;
            icewindDale = IcewindDale;
            icewindDale2 = IcewindDale2;
            neverwinterNights = NeverwinterNights;
            planescapeTorment = PlanescapeTorment;
        }

        /// <summary>Configuration file constructor</summary>
        public GameConfig(ConfigSections.InfinityEngineGamesCollection GameSettings)
        {
            baldursGate = new GameSettings(GameSettings["BaldursGate"]);
            baldursGate2 = new GameSettings(GameSettings["BaldursGate2"]);
            icewindDale = new GameSettings(GameSettings["IcewindDale"]);
            icewindDale2 = new GameSettings(GameSettings["IcewindDale2"]);
            neverwinterNights = new GameSettings(GameSettings["NeverwinterNights"]);
            planescapeTorment = null;
        }
        #endregion
    }

    public class PortraitWarp
    {
        #region Protected Members
        /// <summary>Level of zoom on the image. Cannot go less than 1.</summary>
        protected double zoom;

        /// <summary>X-offset of the portrait from its latest rendering from source</summary>
        protected Int32 x;

        /// <summary>y-offset of the portrait from its latest rendering from source</summary>
        protected Int32 y;
        #endregion

        #region Public Properties
        /// <summary>Level of zoom on the image. Cannot go less than 1.</summary>
        public double Zoom
        {
            get { return zoom; }
            set { zoom = value; }
        }

        /// <summary>X-offset of the portrait from its latest rendering from source</summary>
        public Int32 X
        {
            get { return x; }
            set { x = value; }
        }

        /// <summary>y-offset of the portrait from its latest rendering from source</summary>
        public Int32 Y
        {
            get { return y; }
            set { y = value; }
        }
        #endregion

        #region Constructor(s)
        /// <summary>Default constructor</summary>
        public PortraitWarp()
        {
            zoom = 1.0d;
            x = 0;
            y = 0;
        }
        #endregion

        #region Public Methods
        /// <summary>Increments the image zoom by 0.1</summary>
        public void IncrementZoom()
        {
            zoom += 0.1D;
        }

        /// <summary>Increments the image zoom by 0.1 multiplied by the Occurances</summary>
        /// <param name="Occurances">The number of times to increment the zoom</param>
        public void IncrementZoom(Int32 Occurances)
        {
            zoom += (0.1D * Occurances);
        }

        /// <summary>Decrements the image zoom by 0.1, to a minimum of 1.0</summary>
        public void DecrementZoom()
        {
            zoom = (zoom - 0.1D) > 1.0D ? zoom - 0.1D : 1.0D;
        }

        /// <summary>Decrements the image zoom by 0.1, to a minimum of 1.0multiplied by the Occurances</summary>
        /// <param name="Occurances">The number of times to decrement the zoom</param>
        public void DecrementZoom(Int32 Occurances)
        {
            zoom = zoom - (0.1D * Occurances) > 1.0D ? zoom - (0.1D * Occurances) : 1.0D;
        }
        #endregion
    }
}