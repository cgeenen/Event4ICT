using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event4ICT.Material
{
    class MaterialManager
    {
        private Account account;
        private Material material;
        private List<Material> materials;

        public List<Material> Materials
        {
            get { return materials; }
            set { materials = value; }
        }
        

        public void Add(Material material)
        {
            Materials.Add(material);   
        }

        public void Remove(Material material)
        {
            Materials.Remove(material);
        }
        /*
        public Material GetMaterialByID(int materialID)
        {

        }

        public void ReserveShoppingCart(Dictionary<Material> material, string AccountEmail, OrderDate orderDate)
        {

        }*/

        public void Reserve(Material material, int quantity, string AccountEmail, OrderDate orderDate)
        {

        }
    }
}
