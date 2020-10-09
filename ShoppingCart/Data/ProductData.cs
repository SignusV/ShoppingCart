﻿using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.Data
{
    public class ProductData : Data
    {
        public static List<Product> GetAllProducts()
        {
            //create list to store all records from Cart
            List<Product> productslist = new List<Product>();

            //connect to database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT ProductId, Image, Title, Description, Price 
                                FROM Product";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //store each record as Product object
                    Product product = new Product()
                    {
                        Id = (int)reader["ProductId"],
                        Image = (string)reader["Image"],
                        Title = (string)reader["Title"],
                        Description = (string)reader["Description"],
                        Price = (double)reader["Price"]
                    };
                    productslist.Add(product);
                }
            }
            //return list to controller
            return productslist;
        }
        public static List<Product> GetProductSearch(string search)
        {
            //create list to store all records from Cart
            List<Product> productslist = new List<Product>();

            //connect to database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql = @"SELECT ProductId, Image, Title, Description, Price 
                               FROM Product
                                WHERE Description like'%" + search + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Product product = new Product()
                    {
                        Id = (int)reader["ProductId"],
                        Image = (string)reader["Image"],
                        Title = (string)reader["Title"],
                        Description = (string)reader["Description"],
                        Price = (double)reader["Price"]
                    };
                    productslist.Add(product);
                }
            }
            return productslist;
        }
    }
}