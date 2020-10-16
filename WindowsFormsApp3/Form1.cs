using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp3
{
	public partial class mainForm: Form
	{
		public mainForm()
		{
			InitializeComponent();
			bitDepthCmb.SelectedIndex = 1;
			texTypeCmb.SelectedIndex = 5;
		}

		// data is stored in the balls
		public class imageFile
		{
			public string localName { get; set; }
			public string directories { get; set; }
			public string format { get; set; }
			public Byte numBits { get; set; }
			public Char intensityKey { get; set; }
			public Int16 paletteKey { get; set; }

			// [ localName : directories : format : numbits : intensityKey : paletteKey ]
			public string Print()
			{
				return "[" + localName + "|" + directories + "|" + format + "|" + numBits + "|" + intensityKey + "|" + paletteKey + "]";
			}
		}

		List<imageFile> names = new List<imageFile>();

		// external variables for CI code
		string fileName;
		string directory;
		int imageX;
		int imageY;

		// TODO temporary disable
		// defined here for global access
		//FileStream imglist;

		private void mainForm_Load(object sender, EventArgs e)
		{
			// TODO temporary disable
			/*
			// load in or create new *.imglst file
			FileDialog imglistDialog = new OpenFileDialog
			{
				// VERY important, allows new file creation
				CheckFileExists = false,
				Filter = "Imagelist files *.imglst | *.imglst"
			};
			
			if (imglistDialog.ShowDialog() == DialogResult.OK)
			{
				imglist = File.Create(imglistDialog.FileName);
			}
			else
			{
				Close();
			}
			Show();*/

			// temporary
		}

        private void convertToCI()
        {
            uint[] colors;
            uint[] pixelImg = new uint[1];

            if (filePathTxt.Text != null)
            {
                // defines
                Bitmap image = new Bitmap(filePathTxt.Text);
                if (Convert.ToInt16(bitDepthCmb.Text) == 4)
                {
                    pixelImg = null;
                    pixelImg = new uint[2];
                }
                else if (Convert.ToInt16(bitDepthCmb.Text) == 8)
                {
                    pixelImg = null;
                    pixelImg = new uint[1];
                }
                
                StreamWriter imageOutput = new StreamWriter(directory + fileName + ".h");
                colors = new uint[Convert.ToInt16(bitDepthCmb.Text)^2];
                String pixelHex = "";

                imageOutput.WriteLine("/*\n * this image was converted using the CI converter\n * this image is {0} pixels wide by {1} pixels tall, and has a bit depth of {2} bits\n */", imageX, imageY, bitDepthCmb.Text);
                imageOutput.Write("unsigned char " + fileName.Replace(" ", String.Empty) + "[] = {\n");

                uint r, g, b, a;

                // loop x and y coords and fill picture size with pixel colors
                for (int j = 0; j < imageY; j++)
                {
                    imageOutput.Write("\t");
                    for (int i = 0; i < imageX; i++)
                    {
                        // getting raw data
                        for (int arrayposition = 0; arrayposition < pixelImg.Length; arrayposition++)
                        {
                            try
                            {
                                pixelImg[arrayposition] = (uint)image.GetPixel(i + arrayposition, j).ToArgb();
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                if (j < imageY - 1)
                                {
                                    pixelImg[arrayposition] = (uint)image.GetPixel(0, j + arrayposition).ToArgb();
                                }
                                else
                                {
                                    pixelImg[arrayposition] = 0;
                                }
                            }

                            // compare with colors array
                            for (int k = 0; k < colors.Length; k++)
                            {
                                if (colors[k] == 0)
                                {
                                    // add color to array
                                    colors[k] = pixelImg[arrayposition];
                                    pixelImg[arrayposition] = (uint)k;

                                    // break loop
                                    k = colors.Length;
                                }
                                else
                                {
                                    // compare colors
                                    if (pixelImg[arrayposition].Equals(colors[k]))
                                    {
                                        pixelImg[arrayposition] = (uint)k;
                                        k = colors.Length;
                                    }
                                }
                            }
                        }

                        // convert to hex
                        if (Convert.ToInt16(bitDepthCmb.Text).Equals(8))
                        {
                            pixelHex = string.Format("\t0x{0:X2}", pixelImg[0]);
                        }

                        else if (Convert.ToInt16(bitDepthCmb.Text).Equals(4))
                        {
                            byte tempByte = Convert.ToByte(pixelImg[0] << 4);
                            i++;
                            tempByte += Convert.ToByte(pixelImg[1]);
                            pixelHex = string.Format("\t0x{0:X2}", tempByte);
                        }

                        if (i != imageX - 1 || j != imageY - 1)
                        {
                            pixelHex = pixelHex + ", ";
                        }
                        metadataLbl.Text = pixelHex;

                        // write to file
                        imageOutput.Write(pixelHex);
                    }
                    // new line
                    imageOutput.WriteLine();
                }
                pixelHex = "0";
                imageOutput.WriteLine("};");

                // print color palette
                imageOutput.WriteLine("\nunsigned short " + fileName.Replace(" ", string.Empty) + "Palette[] = {");
                for (int i = 0; i < colors.Length; i++)
                {
                    // set up for bitshifts
                    r = colors[i];
                    g = colors[i];
                    b = colors[i];
                    a = colors[i];

                    colors[i] = compressPixel(r, g, b, a, 16, "RGBA");

                    imageOutput.Write("\t0x{0:X}", colors[i]);

                    // feels like this could be optimized, its messy
                    if (i < colors.Length - 1)
                    {
                        imageOutput.WriteLine(",");
                    }
                    else
                    {
                        imageOutput.WriteLine();
                    }
                }
                imageOutput.WriteLine("};");

                // REMEMBER TO CLOSE THE FILE IDIOT
                imageOutput.Close();
            }
            pixelImg = null;
            colors = null;
        }

        private void mainLoop()
        {
            for(int numItems = 0; numItems < textureLst.Items.Count; numItems++)
            {
                convertLoop(numItems);
            }
        }

        private void convertLoop(int currentItem)
        {
            //uint colors;
            uint[] pixelImg = new uint[2];
            uint r = 0, g = 0, b = 0, a = 0;

            if (textureLst.Items[currentItem] != null)
            {
                // TODO new bitmap
                Bitmap image = new Bitmap(directory);
                StreamWriter outputFile = new StreamWriter(directory);

                // TODO print header

                for (int y = 0; y < imageY; y++)
                {
                    for (int x = 0; x < imageX; x++)
                    {
                        for (int arrayposition = 0; arrayposition < pixelImg.Length; arrayposition++)
                        {
                            try
                            {
                                pixelImg[arrayposition] = (uint)image.GetPixel(x + arrayposition, y).ToArgb();
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                if (y < imageY - 1)
                                {
                                    pixelImg[arrayposition] = (uint)image.GetPixel(0, y + arrayposition).ToArgb();
                                }
                                else
                                {
                                    pixelImg[arrayposition] = 0;
                                }
                            }

							// export code
							compressPixel(r, g, b, a, Convert.ToInt16(bitDepthCmb.Text), texTypeCmb.Text);
                        }
                    }
                }
            }
            // TODO preemptive close file
        }

        private uint compressPixel(uint r, uint g, uint b, uint a, short size, string type)
        {
            uint pixel = 0;
            switch (size)
            {
                case 32:
                    // bitshift to 32 bits
                    r = r >> 16 << 24;
                    g = g >> 8 << 16;
                    b = b << 8;
                    a = a >> 24;
                    break;

                case 16:
                    // bitshift to 16 bits
                    r = r << 8 >> 27 << 11;
                    g = g << 16 >> 27 << 6;
                    b = b << 24 >> 27 << 1;
                    a = a >> 31;
                    break;

                case 8:
					// bitshift to 8 bits
					r = r >> 16;
					g = g >> 8;
					// b = b;
					a = a >> 24;

					pixel = (r + g + b) / 3;

					if (type == "IA")
					{
						pixel = pixel >> 4 << 4;
						a = a >> 4;
						pixel += a;
					}
					else if (type == "I")
					{
						// TODO figure out whether to select alpha or greyscale RGB
					}

					break;

                case 4:
					// bitshift to 4 bits
					r = r >> 16;
                    g = g >> 8;
                    // b = b;
                    a = a >> 24;

                    pixel = (r + g + b)/3;
					pixel = pixel >> 4;

					if (type == "IA")
					{
						pixel = pixel >> 2 << 2;
						a = a >> 6;
						pixel += a;
					}
					break;

                default:
                    break;
            }
            return pixel;
        }
        
        private uint decompressPixel(uint r, uint g, uint b, uint a, int size)
        {
            uint pixel = 0;

            switch (size)
            {
                case 32:
                    // TODO maybe convert to big endian??
                    r = r << 16 >> 24;
                    g = g << 8 >> 16;
                    b = b >> 8;
                    a = a << 24;

					pixel = r + g + b + a;
                    break;
                case 16:
					r = r;//>> 27 << ;
					g = g;
					b = b;
					a = a;
					pixel = r + g + b + a;
					break;
                case 8:

					pixel = r + g + b + a;
					break;
                case 4:

					pixel = r + g + b + a;
					break;
                case 2:

					pixel = r + g + b + a;
					break;
            }
            return pixel;
        }

		private void loadImglist(string imglist)
		{
			// TODO parse data
		}

		private void writeImglist()
		{
			// TODO temporary disable
			/*
			imglist = File.Create(imglist.Name);
			int i = 0;
			foreach (imageFile img in names) 
			{
				byte[] data = Encoding.UTF8.GetBytes(names[i].Print());
				imglist.Write(data, 0, data.Length);
				i++;
			}
			// TODO write palette data
			*/
		}

		private void addTexList(FileStream fs)
		{
			/*names.Add(new imageFile()
			{
				localName = Path.GetFileNameWithoutExtension(fs.Name),
				directories = Path.GetFullPath(fs.Name),
				format = texTypeCmb.SelectedIndex.ToString(),
				numBits = (byte)bitDepthCmb.SelectedIndex,
				intensityKey = getIntensity(),
				paletteKey = 0							// TODO add palette data
			});*/


		}

		private void editTexList()
		{

		}

		private void removeTexList()
		{

		}

		private void exitBtn_Click(object sender, EventArgs e)
		{
			Close();
		}

		private char getIntensity()
		{
			// get intensity
			char intensity = 'A';

			if (redRad.Checked) { intensity = 'R'; }
			else if (greenRad.Checked) { intensity = 'G'; }
			else if (blueRad.Checked) { intensity = 'B'; }
			else if (alphaRad.Checked) { intensity = 'A'; }
			else if (grayscaleRad.Checked) { intensity = 'G'; }
			else { intensity = 'A'; }

			return intensity;
		}

		private void addTextureBtn_Click(object sender, EventArgs e)
		{
			FileDialog textureDialog = new OpenFileDialog();
			textureDialog.Filter = "Image files (*.jpg, *.jpeg, *.bmp, *.gif, *.png) | *.jpg; *.jpeg; *.bmp; *.gif; *.png";

			if (textureDialog.ShowDialog() == DialogResult.OK)
			{
				// display image, show url in textbar
				directory = Path.GetDirectoryName(textureDialog.FileName) + "\\";
				fileName = Path.GetFileNameWithoutExtension(textureDialog.FileName);


				// TODO add to textureLst
				ImageDataGrid.Refresh();
				ImageDataGrid.Update();
				
				try
				{
					Bitmap image = new Bitmap(textureDialog.FileName);
					imageX = image.Width;
					imageY = image.Height;

					//TODO
					metadataLbl.Text = (imageX + ", " + imageY);

					// removes space
					fileName.Replace(" ", String.Empty);

					//TODO replace/change code so it shows *.imglst instead
					filePathTxt.Text = textureDialog.FileName;
					texturePic.Image = Image.FromFile(filePathTxt.Text);
				}
				catch (Exception r)
				{
					MessageBox.Show("This is not a valid image, please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				
				// TODO get palette data

				// eyesore time
				names.Add(new imageFile()
				{
					localName = fileName,
					directories = directory,
					format = texTypeCmb.SelectedIndex.ToString(),
					numBits = (byte)bitDepthCmb.SelectedIndex,
					intensityKey = getIntensity(),
					paletteKey = 0					// TODO add palette data
				}); 
			}

			// populate file
			writeImglist();
		}

		private void convertBtn_Click(object sender, EventArgs e)
        {
			//writeImglist();
			mainLoop();
        }

		private void texTypeCmb_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (texTypeCmb.SelectedItem.Equals("I") || texTypeCmb.SelectedItem.Equals("IA"))
			{
				intensitySelectorGroup.Enabled = true;
				intensitySelectorGroup.Visible = true;
				ciPaletteGroup.Enabled = false;
				ciPaletteGroup.Visible = false;
				alphaRad.Enabled = true;

				if (texTypeCmb.SelectedItem.Equals("IA"))
				{
					if (alphaRad.Checked)
					{
						grayscaleRad.Select();
					}
					alphaRad.Enabled = false;
				}
			}
			else if (texTypeCmb.SelectedItem.Equals("CI"))
			{
				intensitySelectorGroup.Enabled = false;
				intensitySelectorGroup.Visible = false;
				
				ciPaletteGroup.Enabled = true;
				ciPaletteGroup.Visible = true;
			}
			else
			{
				intensitySelectorGroup.Enabled = false;
				intensitySelectorGroup.Visible = false;
				ciPaletteGroup.Enabled = false;
				ciPaletteGroup.Visible = false;
			}
		}

		private void createPaletteBtn_Click(object sender, EventArgs e)
		{
			// TODO change this to real names
			paletteCmb.Items.Add("pal");
		}

		private void modPaletteBtn_Click(object sender, EventArgs e)
		{
			optionsWindow options = new optionsWindow();
			options.ShowDialog();
			// TODO fix this, main window shows over it
			options.BringToFront();
		}
	}
}
