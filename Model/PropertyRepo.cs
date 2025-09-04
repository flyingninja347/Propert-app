using System.Collections.Generic;
using PropertApp.Model;
using PropertyApp.Model;

namespace PropertyApp.Model
{
    public class PropertyRepo
    {
        public static List<Property> AllProperties => new List<Property>
        {
            new Property
            {
                Address = "Manhattan, New York",
                Price = 350550,
                DefaultImage = "https://cdn.pixabay.com/photo/2017/04/10/22/28/residence-2219972_1280.jpg",
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2019/05/24/11/00/interior-4226020_640.jpg",
                    "https://cdn.pixabay.com/photo/2021/06/13/19/22/room-6334131_640.jpg",
                    "https://cdn.pixabay.com/photo/2021/12/05/02/32/interior-design-6846350_640.jpg",
                    "https://cdn.pixabay.com/photo/2019/10/17/02/39/villa-4555815_640.jpg",
                    "https://cdn.pixabay.com/photo/2017/10/16/02/20/property-staging-2855944_640.jpg"
                }
            },
            new Property
            {
                Address = "Queens, New York",
                Price = 550100,
                DefaultImage = "https://cdn.pixabay.com/photo/2017/07/08/02/16/house-2483336_1280.jpg",
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2019/05/24/11/00/interior-4226020_640.jpg",
                    "https://cdn.pixabay.com/photo/2021/06/13/19/22/room-6334131_640.jpg",
                    "https://cdn.pixabay.com/photo/2021/12/05/02/32/interior-design-6846350_640.jpg",
                    "https://cdn.pixabay.com/photo/2019/10/17/02/39/villa-4555815_640.jpg",
                    "https://cdn.pixabay.com/photo/2017/10/16/02/20/property-staging-2855944_640.jpg"
                }
            },
            new Property
            {
                Address = "Brooklyn, New York",
                Price = 250000,
                DefaultImage = "https://cdn.pixabay.com/photo/2018/04/30/13/33/house-3362676_1280.jpg",
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2019/05/24/11/00/interior-4226020_640.jpg",
                    "https://cdn.pixabay.com/photo/2021/06/13/19/22/room-6334131_640.jpg",
                    "https://cdn.pixabay.com/photo/2021/12/05/02/32/interior-design-6846350_640.jpg",
                    "https://cdn.pixabay.com/photo/2019/10/17/02/39/villa-4555815_640.jpg"
                }
            },
            new Property
            {
                Address = "Manhattan, New York",
                Price = 400500,
                DefaultImage = "https://cdn.pixabay.com/photo/2016/08/05/17/32/new-1572747_1280.jpg",
                Images = new List<string>
                {
                    "https://cdn.pixabay.com/photo/2019/05/24/11/00/interior-4226020_640.jpg",
                    "https://cdn.pixabay.com/photo/2021/06/13/19/22/room-6334131_640.jpg",
                    "https://cdn.pixabay.com/photo/2021/12/05/02/32/interior-design-6846350_640.jpg",
                    "https://cdn.pixabay.com/photo/2019/10/17/02/39/villa-4555815_640.jpg",
                    "https://cdn.pixabay.com/photo/2017/10/16/02/20/property-staging-2855944_640.jpg"
                }
            }
        };
    }
}