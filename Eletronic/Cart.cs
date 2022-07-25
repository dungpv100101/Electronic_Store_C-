using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eletronic.Models;

namespace Electronic
{
    class Cart
    {
        public static User user { get; set; }
        public static Dictionary<Product, int> listProductInCart = new Dictionary<Product, int>();

        public Cart()
        {
            listProductInCart = new Dictionary<Product, int>();
        }

        public static double getTotalPrice()
        {
            double sum = 0;
            foreach (Product pro in listProductInCart.Keys)
            {
                sum += pro.SellPrice * listProductInCart[pro];
            }

            return sum;
        }

        public static void addToCart(int productID)
        {
            Product product = getProduct(productID);
            if (checkProductExist(product))
            {
                foreach (Product pro in listProductInCart.Keys)
                {
                    if (product.ProductId == pro.ProductId)
                    {
                        listProductInCart[pro] += 1;
                        return;
                    }
                }
            } else
            {
                listProductInCart.Add(product, 1);
            }
        }

        public static void addToCart(Product product)
        {
            if (checkProductExist(product))
            {
                foreach (Product pro in listProductInCart.Keys)
                {
                    if (product.ProductId == pro.ProductId)
                    {
                        listProductInCart[pro] += 1;
                        return;
                    }
                }
            }
            else
            {
                listProductInCart.Add(product, 1);
            }
        }

        public static void removeFromCart(Product product)
        {
            if (checkProductExist(product))
            {
                foreach (Product pro in listProductInCart.Keys)
                {
                    if (product.ProductId == pro.ProductId)
                    {
                        if (listProductInCart[pro] > 1)
                            listProductInCart[pro] -= 1;
                        else listProductInCart.Remove(pro);
                        return;
                    }
                }
            }
        }

        public static void removeFromCart(int productID)
        {
            Product product = getProduct(productID);
            if (checkProductExist(product))
            {
                foreach (Product pro in listProductInCart.Keys)
                {
                    if (product.ProductId == pro.ProductId)
                    {
                        if (listProductInCart[pro] > 1)
                            listProductInCart[pro] -= 1;
                        else listProductInCart.Remove(pro);
                        return;
                    }
                }
            }
        }

        public static Product getProduct(int productID)
        {
            foreach (Product pro in listProductInCart.Keys)
            {
                if (productID == pro.ProductId)
                {
                    return pro;
                }
            }

            return null;
        } 

        public static void setQuantity(int productID, int quantity)
        {
            foreach (Product pro in listProductInCart.Keys)
            {
                if (productID == pro.ProductId)
                {
                    pro.Quantity = quantity;
                    return;
                }
            }
        }

        public static void deleteFromCart(int productID)
        {
            foreach (Product pro in listProductInCart.Keys)
            {
                if (productID == pro.ProductId)
                {
                    listProductInCart.Remove(pro);
                    return;
                }
            }
        }

        public static bool checkProductExist(Product product)
        {
            foreach (Product pro in listProductInCart.Keys)
            {
                if (product.ProductId == pro.ProductId) return true;
            }
            return false;
        }
    }
}
