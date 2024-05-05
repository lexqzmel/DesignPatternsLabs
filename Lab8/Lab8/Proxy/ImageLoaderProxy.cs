using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Proxy
{
    // Клас-проксі для завантаження зображень
    public class ImageLoaderProxy : IImageLoader
    {
        private string imageUrl;
        private ImageLoader imageLoader;

        public ImageLoaderProxy(string url)
        {
            imageUrl = url;
        }

        public void DisplayImage()
        {
            if (imageLoader == null)
            {
                imageLoader = new ImageLoader(imageUrl);
            }

            imageLoader.DisplayImage();
        }
    }

}
