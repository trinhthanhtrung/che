using System;
using System.Drawing;
using System.Drawing.Imaging;


namespace EveryoneCouldBeCHE
{

	public class BitmapFilter
	{

        public static bool Cheguevarize(Bitmap b,int threshold)
        {
            // Giá trị trả về là BGR (không phải RGB)
            BitmapData bmData = b.LockBits(new Rectangle(0, 0, b.Width, b.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);

            int stride = bmData.Stride;
            System.IntPtr Scan0 = bmData.Scan0;

            unsafe
            {
                byte* p = (byte*)(void*)Scan0;

                int nOffset = stride - b.Width * 3;
                int nWidth = b.Width * 3;

                byte red, green, blue;

                for (int y = 0; y < b.Height; ++y)
                {
                    for (int x = 0; x < b.Width; ++x)
                    {
                        blue = p[0];
                        green = p[1];
                        red = p[2];
                        if ((byte)((red + green + blue) / 3) < threshold)
                        {
                            p[0] = p[1] = p[2] = 0;
                        }
                        else
                        {
                        	p[0] = p[1] = 0; //! Don't know why but the image turn black when they're lower than 64
                        	p[2] = 255;
                        }
                        p += 3;
                     }
                }

                p += nOffset;
            }

            b.UnlockBits(bmData);

            return true;
        }
		
    }
}