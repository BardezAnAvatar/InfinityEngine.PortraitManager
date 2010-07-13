using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace IE_Portrait_Manager
{
    public partial class PortraitManager : Form
    {
        /// <summary>Point indicating the origin of the mouse click for determining the mouse movement offset</summary>
        protected Point MouseClickPoint;

        /// <summary>Boolean indicating whether or not the mouse is down</summary>
        protected Boolean MouseIsDown;

        /// <summary>Locking objects</summary>
        protected Object MouseDownLock, MouseClickPointLock;


        #region Constructor(s)
        /// <summary>Default public constructor</summary>
        public PortraitManager()
        {
            InitializeComponent();
            MouseIsDown = false;
            MouseDownLock = new Object();
            MouseClickPointLock = new Object();
        }
        #endregion

        /// <summary>This method is an event handler for the click on the Set Inut Directory button. It will open a file dialog and populate the input directory text box with that directory path.</summary>
        /// <param name="sender">Standard Object sender parameter (button pressed)</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        protected void buttonSetInputDir_Click(Object sender, EventArgs e)
        {
            //find the target directory
            this.folderBrowserDialogPortraits.ShowNewFolderButton = false;
            this.folderBrowserDialogPortraits.SelectedPath = this.textBoxInput.Text;
            this.folderBrowserDialogPortraits.ShowDialog();
            this.textBoxInput.Text = this.folderBrowserDialogPortraits.SelectedPath;
        }

        /// <summary>This method is an event handler for the click on the Set Output Directory button. It will open a file dialog and populate the output directory text box with that directory path.</summary>
        /// <param name="sender">Standard Object sender parameter (button pressed)</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        private void buttonSetOutputDir_Click(Object sender, EventArgs e)
        {
            //find the target directory
            this.folderBrowserDialogPortraits.ShowNewFolderButton = true;
            this.folderBrowserDialogPortraits.SelectedPath = this.textBoxOutput.Text;
            this.folderBrowserDialogPortraits.ShowDialog();
            this.textBoxOutput.Text = this.folderBrowserDialogPortraits.SelectedPath;
        }

        /// <summary>This protected method processes all the files in a directory and pulls all the images from it. This should point to a portraits directory.</summary>
        /// <param name="Path">">String representing the path to a directory</param>
        protected void ReadImagesFromDirectory(String Path)
        {
            Dictionary<String, PortraitListItem> portraits = new Dictionary<String, PortraitListItem>();

            foreach (String file in Directory.GetFiles(Path))
            {
                //Attempt to open an image from the file. Catch the error, since we are uninterested in non-image files
                try
                {
                    //get the image prefix/detail
                    PortraitDetail detail = GetImagePrefix(file);

                    //create the object with this description in portraits Dictionary if it does not exist
                    if (! portraits.ContainsKey(detail.Prefix))
                    {
                        portraits[detail.Prefix] = new PortraitListItem();
                        portraits[detail.Prefix].IntendedPrefix = (detail.Prefix.Length > 7 ? detail.Prefix.Substring(0, 7) : detail.Prefix);
                        portraits[detail.Prefix].CommonName = detail.Prefix;
                    }

                    //assign the appropriate characteristic to the object.
                    switch (detail.Size)
                    {
                        case PortraitSize.Medium:
                            portraits[detail.Prefix].Images[PortraitSize.Large] = detail;
                            break;
                        case PortraitSize.Small:
                            portraits[detail.Prefix].Images[PortraitSize.Small] = detail;
                            break;
                        case PortraitSize.Giant:
                        case PortraitSize.NULL:
                            portraits[detail.Prefix].Images[PortraitSize.Giant] = detail;
                            break;
                    }

                    //re-assign the best source image?
                    if ((detail.Height * detail.Width) > (portraits[detail.Prefix].Images[PortraitSize.Source].Height * portraits[detail.Prefix].Images[PortraitSize.Source].Width))
                        portraits[detail.Prefix].Images[PortraitSize.Source] = detail;
                }
                catch { } //not an image, do not process
            }

            //populate the Listbox with portraits
            foreach (String portraitSet in portraits.Keys)
            {
                this.listBoxPortraits.Items.Add(portraits[portraitSet]);
            }
        }

        /// <summary>This protected method searches the given Image filename</summary>
        /// <param name="ImagePath">String representing the path to an image</param>
        /// <returns>A String object detailing the prefix of the portrait set</returns>
        protected PortraitDetail GetImagePrefix(String ImagePath)
        {
            PortraitDetail detail = new PortraitDetail();

            using (Image temp = Bitmap.FromFile(ImagePath)) //IDisposable
            {
                Regex expression = new Regex(@"^(.*)\(?([gls])\)?\..*$", RegexOptions.IgnoreCase);   //greedy prefix
                Match results = expression.Match(Path.GetFileName(ImagePath));
                if (results.Success)
                {
                    detail.Prefix = results.Groups[1].Value;
                    detail.Size = PortraitDetail.GetPortraitSize(results.Groups[2].Value);
                    detail.Width = temp.Width;
                    detail.Height = temp.Height;
                    detail.FileName = ImagePath;
                }
                else
                {
                    detail.Prefix = Path.GetFileNameWithoutExtension(ImagePath);
                    detail.Size = PortraitSize.Giant;
                    detail.Width = temp.Width;
                    detail.Height = temp.Height;
                    detail.FileName = ImagePath;
                }
            }
            return detail;
        }

        /// <summary>This method will launch the process of reading images from the input directory and populating the data within the application.</summary>
        /// <param name="sender">Standard Object sender parameter (button pressed)</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        protected void buttonReadDir_Click(Object sender, EventArgs e)
        {
            ReadImagesFromDirectory(this.textBoxInput.Text);
        }

        /// <summary>This event handler fires off when the seected index withing the portraits list box changes.</summary>
        /// <param name="sender">Standard Object sender parameter (button pressed)</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        protected void listBoxPortraits_SelectedIndexChanged(Object sender, EventArgs e)
        {
            this.panelPortraits.Visible = true;
            ClearPortraitContents();
            DisplayPortraitItems();
            AutoSizePortraitPicturesAndPanels();
        }

        /// <summary>This protected method will draw the portrait item's contents to the portrait panel.</summary>
        protected void DisplayPortraitItems()
        {
            PortraitListItem item = GetCurrentlySelectedPortraitItem();
            this.labelCommonName.Text = item.CommonName;
            this.textBoxIntendedPrefix.Text = item.IntendedPrefix;
                        
            /********************
            *   Draw images     *
            ********************/
            //Clear Images
            this.pictureBoxSource.Image = null;
            this.pictureBoxGiant.Image = null;
            this.pictureBoxLarge.Image = null;
            this.pictureBoxSmall.Image = null;
            
            //Source
            this.pictureBoxSource.Image = new Bitmap(item.Images[PortraitSize.Source].FileName);
            this.labelSourceHeight.Text = pictureBoxSource.Image.Height.ToString() + Constants.Pixels;
            this.labelSourceWidth.Text = pictureBoxSource.Image.Width.ToString() + Constants.Pixels;

            //Giant
            if (item.Images[PortraitSize.Giant].RenderFromSource)
                CopyImageFromSourceToPictureBox(pictureBoxSource.Image, pictureBoxGiant, PortraitSize.Giant);

            if (!String.IsNullOrEmpty(item.Images[PortraitSize.Giant].FileName))
                this.pictureBoxGiant.Image = new Bitmap(item.Images[PortraitSize.Giant].FileName);
            this.labelGiantHeight.Text = (pictureBoxGiant.Image == null ? 0 : pictureBoxGiant.Image.Height).ToString() + Constants.Pixels;
            this.labelGiantWidth.Text = (pictureBoxGiant.Image == null ? 0 : pictureBoxGiant.Image.Width).ToString() + Constants.Pixels;

            //Large
            if (!String.IsNullOrEmpty(item.Images[PortraitSize.Large].FileName))
                this.pictureBoxLarge.Image = new Bitmap(item.Images[PortraitSize.Large].FileName);
            this.labelLargeHeight.Text = (pictureBoxLarge.Image == null ? 0 : pictureBoxLarge.Image.Height).ToString() + Constants.Pixels;
            this.labelLargeWidth.Text = (pictureBoxLarge.Image == null ? 0 : pictureBoxLarge.Image.Width).ToString() + Constants.Pixels;

            //Small
            if (!String.IsNullOrEmpty(item.Images[PortraitSize.Small].FileName))
                this.pictureBoxSmall.Image = new Bitmap(item.Images[PortraitSize.Small].FileName);
            this.labelSmallHeight.Text = (pictureBoxSmall.Image == null ? 0 : pictureBoxSmall.Image.Height).ToString() + Constants.Pixels;
            this.labelSmallWidth.Text = (pictureBoxSmall.Image == null ? 0 : pictureBoxSmall.Image.Width).ToString() + Constants.Pixels;
        }

        /// <summary>This protected method will automatically size the images and panels containing the images for the portrait set.</summary>
        protected void AutoSizePortraitPicturesAndPanels()
        {
            ReizePanelAndContents(this.panelSource, this.pictureBoxSource, this.labelSourceHeight, this.labelSourceWidth, this.labelSourceHeightPrompt, this.labelSourceWidthPrompt, PortraitSize.NULL);
            ReizePanelAndContents(this.panelGiant, this.pictureBoxGiant, this.labelGiantHeight, this.labelGiantWidth, this.labelGiantHeightPrompt, this.labelGiantWidthPrompt, PortraitSize.Giant);
            ReizePanelAndContents(this.panelLarge, this.pictureBoxLarge, this.labelLargeHeight, this.labelLargeWidth, this.labelLargeHeightPrompt, this.labelLargeWidthPrompt, PortraitSize.Large);
            ReizePanelAndContents(this.panelSmall, this.pictureBoxSmall, this.labelSmallHeight, this.labelSmallWidth, this.labelSmallHeightPrompt, this.labelSmallWidthPrompt, PortraitSize.Small);
            RepositionPortraitPanels();
        }


        /// <summary>This method is a generic to adjust the contents of one portrait panel, to avoid having one function do all 4, this can be called 4 times to avoid clutter, mistakes, etc.</summary>
        /// <param name="PanelAdjust">Panel to be adjusted</param>
        /// <param name="PictureAdjust">PictureBox to be adjusted</param>
        /// <param name="Height">Height Label to be adjusted</param>
        /// <param name="Width">Width Label to be adjusted</param>
        /// <param name="HeightPrompt">Height prompt Label to be adjusted</param>
        /// <param name="WidthPrompt">Width prompt Label to be adjusted</param>
        /// <param name="ImageSize">Defined size of the portrait</param>
        protected void ReizePanelAndContents(Panel PanelAdjust, PictureBox PictureAdjust, Label Height, Label Width, Label HeightPrompt, Label WidthPrompt, PortraitSize ImageSize)
        {
            /************************************
            *   Note:                           *
            *                                   *
            *   panel padding border = 4        *
            *   picture box padding border = 3  *
            *                                   *
            *   also: the items are anchored.   *
            *   move the items last, resize     *
            *   the panel first                 *
            ************************************/
            Int32 PicHeight, PicWidth;

            //Source Panel
            PicHeight = PictureAdjust.Image == null ? GetDefaultHeight(ImageSize) : PictureAdjust.Image.Height;     //check for NULL image
            PicWidth = PictureAdjust.Image == null ? GetDefaultWidth(ImageSize) : PictureAdjust.Image.Width;        //check for NULL image

            //panel
            if(PanelAdjust.Name == "panelSource")
                PanelAdjust.Width = PicWidth + 8;           //8 padding for width
            else
                PanelAdjust.Width = (PicWidth + 8) > 175 ? PicWidth + 8 : 175;           //8 padding for width
            PanelAdjust.Height = PicHeight + 59;        //20 height offset for image, 13 high for both labels, 7 for height padding, 6 for label padding        /* + 20 + 13 + 3 + 13 + 4 + 6;*/  

            //picture box
            PictureAdjust.Height = PicHeight;  //match height
            PictureAdjust.Width = PicWidth;    //match width

            //height / width
            Point point = HeightPrompt.Location;
            point.Y = PicHeight + 23;  //three for ceiling padding, 20 for picturebox offset
            HeightPrompt.Location = point;

            point = Height.Location;
            point.Y = PicHeight + 23;  //three for ceiling padding, 20 for picturebox offset
            Height.Location = point;

            point = Width.Location;
            point.Y = PicHeight + 40;  //seven for total ceiling padding, 20 for picturebox offset, 13 for height's height
            Width.Location = point;

            point = WidthPrompt.Location;
            point.Y = PicHeight + 40;  //seven for total ceiling padding, 20 for picturebox offset, 13 for height's height
            WidthPrompt.Location = point;
        }

        /// <summary>This method will repoition the panels to be more aesthetically pleasing and not stacked on top of one another once resized</summary>
        protected void RepositionPortraitPanels()
        {
            //Giant/Huge
            Point point = this.panelGiant.Location;
            point.X = panelSource.Location.X + panelSource.Width + 8;
            this.panelGiant.Location = point;

            //Large
            point = this.panelLarge.Location;
            point.X = panelGiant.Location.X + panelGiant.Width + 8;
            this.panelLarge.Location = point;

            //Small
            point = this.panelSmall.Location;
            point.X = panelLarge.Location.X + panelLarge.Width + 8;
            this.panelSmall.Location = point;
        }

        /// <summary>Gets the default height for the portrait.</summary>
        /// <param name="size">Enum dictating the portrait size</param>
        /// <returns>The default height for the portrait size based on the selected game</returns>
        protected Int32 GetDefaultHeight(PortraitSize size)
        {
            GameSettings game = GetSelectedGameSetting();
            
            Int32 height;
            switch (size)
            {
                case PortraitSize.Giant:
                    height = game.Portraits[PortraitSize.Giant].Height;
                    break;
                case PortraitSize.Large:
                    height = game.Portraits[PortraitSize.Large].Height;
                    break;
                case PortraitSize.Medium:
                    height = game.Portraits[PortraitSize.Medium].Height;
                    break;
                case PortraitSize.Small:
                    height = game.Portraits[PortraitSize.Small].Height;
                    break;
                case PortraitSize.Tiny:
                    height = game.Portraits[PortraitSize.Tiny].Height;
                    break;
                default:
                    height = 0;
                    break;
            }
            return height;
        }

        /// <summary>Gets the default width for the portrait.</summary>
        /// <param name="size">Enum dictating the portrait size</param>
        /// <returns>The default width for the portrait size based on the selected game</returns>
        protected Int32 GetDefaultWidth(PortraitSize size)
        {
            GameSettings game = GetSelectedGameSetting();

            Int32 width;
            switch (size)
            {
                case PortraitSize.Giant:
                    width = game.Portraits[PortraitSize.Giant].Width;
                    break;
                case PortraitSize.Large:
                    width = game.Portraits[PortraitSize.Large].Width;
                    break;
                case PortraitSize.Medium:
                    width = game.Portraits[PortraitSize.Medium].Width;
                    break;
                case PortraitSize.Small:
                    width = game.Portraits[PortraitSize.Small].Width;
                    break;
                case PortraitSize.Tiny:
                    width = game.Portraits[PortraitSize.Tiny].Width;
                    break;
                default:
                    width = 0;
                    break;
            }
            return width;
        }

        /// <summary>This protected method will clear the contents of the portrait images, heights, widths and prefixes</summary>
        protected void ClearPortraitContents()
        {
            //pictures
            this.pictureBoxSource.Image = null;
            this.pictureBoxGiant.Image = null;
            this.pictureBoxLarge.Image = null;
            this.pictureBoxSmall.Image = null;

            //height and width
            this.labelGiantHeight.Text = Constants.HeightBracket;
            this.labelGiantWidth.Text = Constants.WidthBracket;
            this.labelLargeHeight.Text = Constants.HeightBracket;
            this.labelLargeWidth.Text = Constants.WidthBracket;
            this.labelSmallHeight.Text = Constants.HeightBracket;
            this.labelSmallWidth.Text = Constants.WidthBracket;
            this.labelSourceHeight.Text = Constants.HeightBracket;
            this.labelSourceWidth.Text = Constants.WidthBracket;

            //portrait form contents
            this.labelCommonName.Text = Constants.Blank;
            this.textBoxIntendedPrefix.Text = String.Empty;
        }

        /// <summary>Returns a Game enum dictating which game is selected</summary>
        /// <returns>A Game enum object</returns>
        protected Game GetSelectedGame()
        {
            //default to Baldur's Gate 2
            return radioButtonBaldursGate.Checked ? Game.BaldursGate : radioButtonIcewindDale.Checked ? Game.IcewindDale : radioButtonIcewindDale2.Checked ? Game.IcewindDale2 : radioButtonPlanescapeTorment.Checked ? Game.PlanescapeTorment : radioButtonNeverwinterNights.Checked ? Game.NeverwinterNights : Game.BaldursGate2;
        }

        /// <summary>Returns a GameSettings object relating to which game is selected</summary>
        /// <returns>A GameSettings object</returns>
        protected GameSettings GetSelectedGameSetting()
        {
            GameSettings game = null;

            switch (GetSelectedGame())
            {
                case Game.BaldursGate:
                    game = Constants.Games.BaldursGate;
                    break;
                case Game.BaldursGate2:
                    game = Constants.Games.BaldursGate2;
                    break;
                case Game.IcewindDale:
                    game = Constants.Games.IcewindDale;
                    break;
                case Game.IcewindDale2:
                    game = Constants.Games.IcewindDale2;
                    break;
                case Game.NeverwinterNights:
                    game = Constants.Games.NeverwinterNights;
                    break;
                case Game.PlanescapeTorment:
                    //game = Constants.Games.PlanescapeTorment;
                    break;
                default: //default to Baldur's Gate 2
                    game = Constants.Games.BaldursGate2;
                    break;
            }

            return game;
        }

        /// <summary>Copies an image from a source to a destination picturebox using the dimensions specified</summary>
        /// <param name="ImageSource">Source image</param>
        /// <param name="Target">Target PictureBox to draw to</param>
        /// <param name="Portrait">Size of portrait to copy to</param>
        protected void CopyImageFromSourceToPictureBox(Image ImageSource, PictureBox Target, PortraitSize Portrait)
        {
            //Set up drawing objects
            using (Bitmap manipulate = new Bitmap(ImageSource))
            {
                PortraitListItem item = GetCurrentlySelectedPortraitItem();
                PortraitDimensions targetDimensions = GetSelectedGameSetting().Portraits[Portrait];
                PortraitWarp warpOptions = item.Images[Portrait].ImageOptions;

                //copy properties, since they would otherwise be often called
                Int32 SrcImageHeight = ImageSource.Height;
                Int32 SrcImageWidth = ImageSource.Width;
                
                //determine aspect ration, and the target size
                Double aspectRatioSource = Convert.ToDouble(SrcImageWidth > 0 ? SrcImageWidth : 1) / Convert.ToDouble(SrcImageHeight > 0 ? SrcImageHeight : 1);                     //w / h
                Double aspectRatioDest = Convert.ToDouble(targetDimensions.Width > 0 ? targetDimensions.Width : 1) / Convert.ToDouble(targetDimensions.Height > 0 ? targetDimensions.Height : 1);   //w / h

                //get the bounds of the image source
                Int32 srcHeight, srcWidth;
                if (aspectRatioDest > aspectRatioSource)
                {
                    srcWidth = SrcImageWidth;
                    srcHeight = Convert.ToInt32(srcWidth / aspectRatioDest);
                }
                else
                {
                    srcHeight = SrcImageHeight > 0 ? SrcImageHeight : 1;
                    srcWidth = Convert.ToInt32(aspectRatioDest * srcHeight);
                }

                //generate the scaling rectangle, centered in the source image
                Rectangle src = new Rectangle();
                src.Width = Convert.ToInt32(srcWidth / warpOptions.Zoom);
                src.Height = Convert.ToInt32(srcHeight / warpOptions.Zoom);
                //src.X = ((SrcImageWidth - src.Width) / 2);
                //src.Y = ((SrcImageHeight - src.Height) / 2);
                src.X = ((SrcImageWidth - src.Width) / 2) + Convert.ToInt32(warpOptions.X * warpOptions.Zoom);      //add in the offset
                src.Y = ((SrcImageHeight - src.Height) / 2) + Convert.ToInt32(warpOptions.Y * warpOptions.Zoom);    //add in the offset

                if ((src.X + src.Width) > (SrcImageWidth))
                    src.X = (SrcImageWidth) - src.Width;
                else if (src.X < 0)
                    src.X = 0;

                if ((src.Y + src.Height) > (SrcImageHeight))
                    src.Y = (SrcImageHeight) - src.Height;
                else if (src.Y < 0)
                    src.Y = 0;

                //copy image
                using (Bitmap b = new Bitmap(targetDimensions.Width, targetDimensions.Height))
                {
                    using (Graphics g = Graphics.FromImage(b))
                    {
                        using(Bitmap newImage = manipulate.Clone(src, System.Drawing.Imaging.PixelFormat.DontCare))
                        {
                            //High quality
                            g.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                            g.DrawImage(newImage, 0, 0, targetDimensions.Width, targetDimensions.Height);
                            Target.Image = b.Clone() as Bitmap;
                        }
                    }
                }
            }

            //Target.Invalidate();    //redraw?
        }

        #region From Source event handlers
        /// <summary>This method will pull the giant portrait image from the source and display it to the user</summary>
        /// <param name="sender">Standard Object sender parameter (button pressed)</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        protected void buttonGiantFromSource_Click(Object sender, EventArgs e)
        {
            RedrawGiantImage();
        }
        
        /// <summary>This method will pull the large portrait image from the source and display it to the user</summary>
        /// <param name="sender">Standard Object sender parameter (button pressed)</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        protected void buttonLargeFromSource_Click(Object sender, EventArgs e)
        {
            RedrawLargeImage();
        }
        
        /// <summary>This method will pull the small portrait image from the source and display it to the user</summary>
        /// <param name="sender">Standard Object sender parameter (button pressed)</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        protected void buttonSmallFromSource_Click(Object sender, EventArgs e)
        {
            RedrawSmallImage();
        }
        #endregion

        /// <summary>This method is abstracted from the render from source button event handlers, both to pull and to make more accessible to other methods.</summary>
        /// <param name="PortraitTarget">PictureBox to draw onto</param>
        /// <param name="ContainingPanel">Panel containing the rendering target PictureBox and its descriptive labels</param>
        /// <param name="Width">Label containing the width of the rendering target PictureBox</param>
        /// <param name="Height">Label containing the height of the rendering target PictureBox</param>
        /// <param name="WidthDesc">Label describing the label containing the width of the rendering target PictureBox</param>
        /// <param name="HeightDesc">Label describing the label containing the height of the rendering target PictureBox</param>
        /// <param name="Size">PortraitSize enum object describing the target portrait size</param>
        protected void RedrawImageFromSource(PictureBox PortraitTarget, PortraitSize Portrait, Panel ContainingPanel, Label Width, Label Height, Label WidthDesc, Label HeightDesc, PortraitSize Size)
        {
            CopyImageFromSourceToPictureBox(pictureBoxSource.Image, PortraitTarget, Size);
            ReizePanelAndContents(ContainingPanel, PortraitTarget, Height, Width, HeightDesc, WidthDesc, Size);
            RepositionPortraitPanels();
            Width.Text = PortraitTarget.Image.Width.ToString() + Constants.Pixels;
            Height.Text = PortraitTarget.Image.Height.ToString() + Constants.Pixels;
        }

        /// <summary>This method will redraw the small portrait from th source image</summary>
        protected void RedrawSmallImage()
        {
            RedrawImageFromSource(this.pictureBoxSmall, PortraitSize.Small, this.panelSmall, this.labelSmallWidth, this.labelSmallHeight, this.labelSmallWidthPrompt, this.labelSmallHeightPrompt, PortraitSize.Small);
        }

        /// <summary>This method will redraw the large portrait from th source image</summary>
        protected void RedrawLargeImage()
        {
            RedrawImageFromSource(this.pictureBoxLarge, PortraitSize.Large, this.panelLarge, this.labelLargeWidth, this.labelLargeHeight, this.labelLargeWidthPrompt, this.labelLargeHeightPrompt, PortraitSize.Large);
        }

        /// <summary>This method will redraw the giant portrait from th source image</summary>
        protected void RedrawGiantImage()
        {
            RedrawImageFromSource(this.pictureBoxGiant, PortraitSize.Giant, this.panelGiant, this.labelGiantWidth, this.labelGiantHeight, this.labelGiantWidthPrompt, this.labelGiantHeightPrompt, PortraitSize.Giant);
        }

        #region PictureBox Mouse Actions
        /// <summary>Event Handler for scrolling the mouse wheel over the small PictureBox</summary>
        /// <param name="sender">Standard Object sender parameter</param>
        /// <param name="e">Standard Mouse event arguments Object (mouse clicks, scrolls, movements, etc.)</param>
        protected void pictureBoxSmall_MouseWheel(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            PictureBoxScroll(e.Delta, PortraitSize.Small);
            RedrawSmallImage();     //redraw...
        }

        /// <summary>Event Handler for scrolling the mouse wheel over the large PictureBox</summary>
        /// <param name="sender">Standard Object sender parameter</param>
        /// <param name="e">Standard Mouse event arguments Object (mouse clicks, scrolls, movements, etc.)</param>
        protected void pictureBoxLarge_MouseWheel(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            PictureBoxScroll(e.Delta, PortraitSize.Large);
            RedrawLargeImage();     //redraw...
        }

        /// <summary>Event Handler for scrolling the mouse wheel over the giant PictureBox</summary>
        /// <param name="sender">Standard Object sender parameter</param>
        /// <param name="e">Standard Mouse event arguments Object (mouse clicks, scrolls, movements, etc.)</param>
        protected void pictureBoxGiant_MouseWheel(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            PictureBoxScroll(e.Delta, PortraitSize.Giant);
            RedrawGiantImage();     //redraw...
        }

        /// <summary>This method will increment or decrement the Zoom on a PortraitWarp based on te Scroll Delta passed</summary>
        /// <param name="ScrollDelta">Delta of the scroll wheel. Should be a multiple of 120, per MSDN. Each scroll tick is 120.</param>
        /// <param name="Portrait">Size of the portrait to adjust the zoom on</param>
        protected void PictureBoxScroll(Int32 ScrollDelta, PortraitSize Portrait)
        {
            PortraitListItem item = GetCurrentlySelectedPortraitItem();
            
            Int32 delta = (ScrollDelta / Constants.WHEEL_DELTA);    //number of wheel ticks

            //modify the zoom (?)
            if (delta > 0)
                item.Images[Portrait].ImageOptions.IncrementZoom(delta);
            else if (delta < 0)
                item.Images[Portrait].ImageOptions.DecrementZoom(-delta);
        }
        
        #region PictureBox Focus Methods / Event Handlers
        /// <summary>Event handler for the mouse entering the giant portrait picturebox. Gives Focus to the PictureBox to enable mouse wheel scrolling.</summary>
        /// <param name="sender">Standard Object sender parameter</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        protected void pictureBoxGiant_MouseEnter(Object sender, System.EventArgs e)
        {
            this.pictureBoxGiant.Focus();
        }
        
        /// <summary>Event handler for the mouse entering the large portrait picturebox. Gives Focus to the PictureBox to enable mouse wheel scrolling.</summary>
        /// <param name="sender">Standard Object sender parameter</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        protected void pictureBoxLarge_MouseEnter(Object sender, System.EventArgs e)
        {
            this.pictureBoxLarge.Focus();
        }

        /// <summary>Event handler for the mouse entering the small portrait picturebox. Gives Focus to the PictureBox to enable mouse wheel scrolling.</summary>
        /// <param name="sender">Standard Object sender parameter</param>
        /// <param name="e">Standard EventArgs e parameter</param>
        protected void PortraitManager_MouseEnter(Object sender, EventArgs e)
        {
            this.pictureBoxSmall.Focus();
        }
        #endregion


        /// <summary></summary>
        /// <param name="sender">Standard Object sender parameter</param>
        /// <param name="e">Standard Mouse event arguments Object (mouse clicks, scrolls, movements, etc.)</param>
        protected void pictureBoxSmall_MouseMove(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ProcessMouseMove(e.X, e.Y, PortraitSize.Small);
            RedrawSmallImage();
        }

        /// <summary>Event handler for mouse down over the small PictureBox</summary>
        /// <param name="sender">Standard Object sender parameter</param>
        /// <param name="e">Standard Mouse event arguments Object (mouse clicks, scrolls, movements, etc.)</param>
        protected void pictureBoxSmall_MouseDown(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            ProcessMouseDown(e.X, e.Y);
        }

        /// <summary>Event handler for mouse up over the small PictureBox</summary>
        /// <param name="sender">Standard Object sender parameter</param>
        /// <param name="e">Standard Mouse event arguments Object (mouse clicks, scrolls, movements, etc.)</param>
        protected void pictureBoxSmall_MouseUp(Object sender, System.Windows.Forms.MouseEventArgs e)
        {
            LockMouse(false);
        }

        /// <summary>Protected method to lock the MouseIsDown bloolean flag</summary>
        /// <param name="IsMouseDown">Boolean to assign to the MouseIsDown boolean flag</param>
        protected void LockMouse(Boolean IsMouseDown)
        {
            lock (this.MouseDownLock)
            {
                this.MouseIsDown = IsMouseDown;
            }
        }

        /// <summary>This method will set the MouseIsDown flag and create a new MouseClickPoint based on the X and Y co-ordinates provided.</summary>
        protected void ProcessMouseDown(Int32 X, Int32 Y)
        {
            LockMouse(true);
            lock (MouseClickPointLock)
            {
                MouseClickPoint = new Point(X, Y);
            }
        }
        
        /// <summary>This method will process a mouse move, adjusting the source area of the image</summary>
        /// <param name="X">Current X mouse coordinate</param>
        /// <param name="Y">Current Y mouse coordinate</param>
        /// <param name="Size">PortraitSize object describing the size of the portrait</param>
        protected void ProcessMouseMove(Int32 X, Int32 Y, PortraitSize Size)
        {
            if (MouseIsDown)
            {
                PortraitWarp warpOptions = (listBoxPortraits.Items[listBoxPortraits.SelectedIndex] as PortraitListItem).Images[Size].ImageOptions;

                //TODO: adjust the mouse movement below to be adjustable to the current X coordiant adjustment. This must take the current X into account.
                //      i.e.: move 4 to the left, move 6 to the right will move a total of 2.
                warpOptions.X = X - MouseClickPoint.X;
                warpOptions.Y = MouseClickPoint.Y - Y;
            }
        }
        #endregion

        /// <summary>Method to get the currently selected PortraitItem in listBoxPortraits</summary>
        /// <returns></returns>
        protected PortraitListItem GetCurrentlySelectedPortraitItem()
        {
            return listBoxPortraits.Items[listBoxPortraits.SelectedIndex] as PortraitListItem;
        }
    }
}