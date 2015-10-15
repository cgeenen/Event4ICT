using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event4ICT
{
    class Material
    {
        private int materialID;
        private string name;
        private string description;
        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        public int MaterialID
        {
            get { return materialID; }
            set { materialID = value; }
        }
        
        public Material(int materialID, string name, string description, int price)
        {
            this.materialID = materialID;
            this.name = name;
            this.description = description;
            this.price = price;
        }
    }
}
