using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Proxy
{
    // Конкретний клас, який реалізує завантаження зображень
    public class ImageLoader : IImageLoader
    {
        private string imageUrl;

        public ImageLoader(string url)
        {
            imageUrl = url;
            LoadImageFromServer();
        }

        private void LoadImageFromServer()
        {
            Console.WriteLine("Завантаження зображення з сервера: " + imageUrl);
            // Код для завантаження зображення з сервера
        }

        public void DisplayImage()
        {
            Console.WriteLine("Відображення зображення: " + imageUrl);
            // Код для відображення зображення
        }
    }
}
