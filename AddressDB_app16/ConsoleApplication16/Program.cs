using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressDB

{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection;   //1. Create connection
            connection = new SqlConnection(@"Data Source=(LocalDb)\MSSQLLocalDB;AttachDbFilename=c:\users\ray\documents\visual studio 2015\Projects\ConsoleApplication16\ConsoleApplication16\AddressDB.mdf; Integrated Security=true");
            connection.Open();

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nWhat would you like to do?\na) Add a contact\nb) View your contacts\nc) Update a contact\nd) Delete a contact\nx) Exit");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "x":
                        {
                            exit = true;
                            break;
                        }

                    case "a":
                        {
                            Console.WriteLine("Please enter the first and last name of the person to add");
                            string nameEntry = Console.ReadLine();
                            //Console.WriteLine("Please enter the email address");
                            //string emailEntry = Console.ReadLine();
                            //Console.WriteLine("Please enter the street addresss");
                            //string addressEntry = Console.ReadLine();
                            //Console.WriteLine("Please enter the city");
                            //string cityEntry = Console.ReadLine();
                            //Console.WriteLine("Please enter the state");
                            //string stateEntry = Console.ReadLine();
                            Console.WriteLine("Please enter the zip code");
                            string zipEntry = Console.ReadLine();

                            string insertString = "INSERT INTO Address (Name, Email, Address, Address2, City, State, Zip) VALUES ( '" + nameEntry + "', 'emailAddress@gmail.com', '555 Anystreet Dr.', '', 'Pittsburgh', 'PA', '" + zipEntry + "')";
                            SqlCommand insertCommand = new SqlCommand(insertString, connection);
                            insertCommand.ExecuteNonQuery();
                            break;
                        }

                    case "b":
                        {
                            //SqlCommand command = new SqlCommand("SELECT * from Address", connection);   // * means look in all columns
                            Console.WriteLine("Enter the first 0-3 digits of the desired zip code");
                            string zipFilter = "SELECT * from Address WHERE Zip LIKE '" + Console.ReadLine() + "%'";
                            SqlCommand command = new SqlCommand(zipFilter, connection);
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine();
                                    Console.Write(reader["Id"]);
                                    Console.Write(": ");
                                    Console.Write(reader["Name"]);
                                    Console.Write(" ");
                                    Console.Write(reader["Address"]);
                                    Console.Write(" ");
                                    Console.Write(reader["City"]);
                                    Console.Write(" ");
                                    Console.Write(reader["State"]);
                                    Console.Write(" ");
                                    Console.Write(reader["Zip"]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                            }
                            reader.Close();
                            Console.WriteLine();
                            break;


                        }
                    case "c":
                        {
                            string updateString = "UPDATE Address SET City='Pittsburgh' WHERE City='Pgh'";
                            SqlCommand updateCommand = new SqlCommand(updateString, connection);
                            updateCommand.ExecuteNonQuery();
                            Console.ReadLine();
                            break;
                        }

                    case "d":
                        {
                            SqlCommand command = new SqlCommand("SELECT * from Address", connection);
                            SqlDataReader reader = command.ExecuteReader();
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Console.WriteLine();
                                    Console.Write(reader["Id"]);
                                    Console.Write(": ");
                                    Console.Write(reader["Name"]);
                                    Console.Write(" ");
                                    Console.Write(reader["Address"]);
                                    Console.Write(" ");
                                    Console.Write(reader["City"]);
                                    Console.Write(" ");
                                    Console.Write(reader["State"]);
                                    Console.Write(" ");
                                    Console.Write(reader["Zip"]);
                                }
                            }
                            else
                            {
                                Console.WriteLine("No rows found.");
                            }
                            reader.Close();
                            Console.WriteLine("\n\nEnter the ID# of the record to delete");
                            //int userID = Convert.ToInt16(Console.ReadLine());
                            string userID = Console.ReadLine();
                            string deleteString = "DELETE FROM Address WHERE Id = '" + userID + "'";
                            SqlCommand deleteCommand = new SqlCommand(deleteString, connection);
                            deleteCommand.ExecuteNonQuery();
                            break;
                        }

                }

            }

        }
    }
}
