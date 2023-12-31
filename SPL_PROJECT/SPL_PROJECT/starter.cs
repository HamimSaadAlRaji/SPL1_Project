﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPL_PROJECT
{
    public class Starter
    {
        public void loadUser()
        {
            string user_file = @"C:\ShopMate\user.txt.txt";
            if (File.Exists(user_file))
            {
                StreamReader sr = new StreamReader(user_file);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = null;
                    s = line.Split(',');

                    string userName = s[0];
                    string name = s[1];
                    string pass = s[2];
                    string mail = s[3];
                    string date = s[4];
                    user tempUser = new user(userName, name, pass, mail, date);
                    Database.userList.Add(tempUser);
                }

                sr.Close();
            }
        }
        public void loadElectronicProduct()
        {
            string product_file = @"C:\ShopMate\electronicproduct.txt";
            if (File.Exists(product_file))
            {
                StreamReader sr = new StreamReader(product_file);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = null;
                    s = line.Split(',');

                    int id = Convert.ToInt32(s[0]);
                    string name = s[1];
                    double price = Convert.ToDouble(s[2]);
                    int quantity= Convert.ToInt32(s[3]);
                    string description = s[4];

                    ElectronicProducts temp = new ElectronicProducts(id, name, price, description, quantity);
                    Database.ElectronicProductList.Add(temp);
                }

                sr.Close();
            }
            else
            {
                Console.WriteLine("electronic file not found");
            }
        }
        public void loadClothingProduct()
        {
            string product_file = @"C:\ShopMate\clothingproduct.txt";
            if (File.Exists(product_file))
            {
                StreamReader sr = new StreamReader(product_file);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = null;
                    s = line.Split(',');

                    int id = Convert.ToInt32(s[0]);
                    string name = s[1];
                    double price = Convert.ToDouble(s[2]);
                    int quantity = Convert.ToInt32(s[3]);
                    string description = s[4];

                    Cloth temp = new Cloth(id, name, price, description, quantity);
                    Database.clothList.Add(temp);
                }

                sr.Close();
            }
            else
            {
                Console.WriteLine("cloth file not found");
            }
        }
        public void loadHomeApplienceProduct()
        {
            string product_file = @"C:\ShopMate\homeapplienceproduct.txt";
            if (File.Exists(product_file))
            {
                StreamReader sr = new StreamReader(product_file);
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    string[] s = null;
                    s = line.Split(',');

                    int id = Convert.ToInt32(s[0]);
                    string name = s[1];
                    double price = Convert.ToDouble(s[2]);
                    int quantity = Convert.ToInt32(s[3]);
                    string description = s[4];

                    HomeAppliences temp = new HomeAppliences(id, name, price, description, quantity);
                    Database.HomeApplienceList.Add(temp);
                }

                sr.Close();
            }
            else
            {
                Console.WriteLine("home file not found");
            }
        }
        public Starter()
        {
            loadUser();
            loadElectronicProduct();
            loadHomeApplienceProduct();
            loadClothingProduct();
        }
       
    }
}
