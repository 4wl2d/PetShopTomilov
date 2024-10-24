using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PetShopTomilov.Domain.Managers
{
    public static class Manager
    {
        public static Frame MainFrame { get; set; }

        public static void getImageData()
        {
            try
            {
                var list = Data.PetShopEntities.getContext().Product.ToList();
                foreach (var item in list)
                {
                    string path = Directory.GetCurrentDirectory() + @"\img\" + item.ProductPhotoName;
                    
                    if (File.Exists(path))
                    {
                        item.ProductPhoto = File.ReadAllBytes(path);
                    }
                }
                Data.PetShopEntities.getContext().SaveChanges();
            }
            catch { }
        }
    }
}
    