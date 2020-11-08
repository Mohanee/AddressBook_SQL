﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace ABook_DBConnection
{

    public class AddressBookRepo
    {
        public static string connectionString = @"Data Source=(LocalDB)\BLDBserver;Initial Catalog=ABook;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void RetrieveAllContacts()
        {
            try
            {
                ContactsModel contactModel = new ContactsModel();
                using (this.connection)
                {
                    string query = @"select n.FirstName, n.LastName, af.Address, af.City, af.State, af.Zipcode, cf.PhoneNumber,cf.Email, rt.RelationType"
                                    + " from AddressInfo af join ABookTable n on  af.FirstName= n.FirstName" +
                                    " join ContactInfo cf on cf.FirstName=af.FirstName  join RelationTable rt on af.FirstName=rt.FirstName;";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    System.Console.WriteLine("FirstName,LastName,Address,City,State,Zipcode,PhoneNumber,Email,RelationType");
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            contactModel.FirstName = dr.GetString(0);
                            contactModel.LastName = dr.GetString(1);
                            contactModel.Address = dr.GetString(2);
                            contactModel.City = dr.GetString(3);
                            contactModel.State = dr.GetString(4);
                            contactModel.Zipcode = dr.GetString(5);
                            contactModel.PhoneNumber = dr.GetString(6);
                            contactModel.Email = dr.GetString(7);
                            contactModel.RelationType = dr.GetString(8);
                            System.Console.WriteLine(contactModel.FirstName+","+contactModel.LastName + "," +contactModel.Address + "," +contactModel.City + 
                                "," +contactModel.State + "," +contactModel.PhoneNumber + "," +contactModel.Email + "," +contactModel.RelationType);
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }

        public string RetrieveForTesting(string testQuery)
        {
            string modifiedCity = "";
            try
            {
                ContactsModel contactModel = new ContactsModel();
                using (this.connection)
                {
                    string query = testQuery;
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            modifiedCity = dr.GetString(0);
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                    }
                }
                return modifiedCity;
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                return modifiedCity;
            }
        }


        public void UpdateContact(string updateQuery)
        {
            try
            {
                using (this.connection)
                {
                    string query = updateQuery;
                    
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    int rows = cmd.ExecuteNonQuery();
                    this.connection.Close();
                    if (rows > 0)
                    {
                        Console.WriteLine(rows + " row(s) affected");
                    }
                    else
                    {
                        Console.WriteLine("Please check your query");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                this.connection.Close();
            }
        }
    }
}
