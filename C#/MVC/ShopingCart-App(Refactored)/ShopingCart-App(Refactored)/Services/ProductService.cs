using ShopingCart_App_Refactored_.Models;
using ShopingCart_App_Refactored_.Repositary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopingCart_App_Refactored_.Services
{
    public class ProductService
    {
        private List<Product> productList;

        ProductRepository pr = new ProductRepository();

        public List<Product> ProductList
        {
            get
            {
                return RetriveProductList();
            }

            set
            {
                productList = value;
            }
        } 
        
        public List<Product> RetriveProductList()
        {
            productList = pr.FetchData();
            return productList;
        }     
    }
}

//private static List<LineItem> lineItemList;
//lineItemList = new List<LineItem>();

//public List<LineItem> LineItemList
//{
//    get
//    {
//        return lineItemList;
//    }

//    set
//    {
//        lineItemList = value;
//    }
//}

//public void Add(LineItem lineItem)
//{
//    bool flag = false;
//    foreach (LineItem item in LineItemList)
//    {
//        if (lineItem.Product.ProductName == item.Product.ProductName)
//        {
//            UpdateExisting(item , lineItem.Quantity);
//            flag = true;
//        }
//    }

//    if (flag == false) { LineItemList.Add(lineItem); }

//}

//public void UpdateExisting(LineItem itemItem , int quantity)
//{
//    foreach (LineItem item in LineItemList)
//    {
//        if (item.Product.ProductName == itemItem .Product.ProductName)
//        {
//            item.Quantity = item.Quantity + quantity;
//            break;
//        }
//    }
//}

//public void DeleteLineItem(string name)
//{
//    int i = 0;
//    foreach (var lineItem in lineItemList)
//    {
//        if (lineItem.Product.ProductName == name)
//        {
//            break;
//        }
//        i++;
//    }
//    lineItemList.RemoveAt(i);
//}