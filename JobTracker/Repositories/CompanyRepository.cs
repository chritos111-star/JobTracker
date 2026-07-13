using System;
using System.Collections.Generic;
using System.Text;
using JobTracker.Data;
using JobTracker.Models;
using MySql.Data.MySqlClient;

namespace JobTracker.Repositories
{
    internal class CompanyRepository
    {
        private readonly Database database = new Database();
        public List<Company> GetAllCompanies()
        {
            List<Company> companies = new List<Company>();
            using (var connection = database.GetConnection())
            {
                connection.Open();
                string query = "SELECT * FROM Companies";
                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Company company = new Company
                            {
                                Id = reader.GetInt32("Id"),
                                CompanyName = reader.GetString("CompanyName"),
                                City = reader.GetString("City"),
                                Website = reader.GetString("Website")
                            };
                            companies.Add(company);
                        }
                    }
                }
            }
            return companies;
        }
        public void AddCompany(Company company)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query =
                    "INSERT INTO Companies (CompanyName, City, Website) " +
                    "VALUES (@name, @city, @website)";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", company.CompanyName);
                    command.Parameters.AddWithValue("@city", company.City);
                    command.Parameters.AddWithValue("@website", company.Website);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteCompany(int id)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Companies WHERE Id = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateCompany(Company company)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();
                string query =
                    "UPDATE Companies SET CompanyName = @name, City = @city, Website = @website " +
                    "WHERE Id = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@name", company.CompanyName);
                    command.Parameters.AddWithValue("@city", company.City);
                    command.Parameters.AddWithValue("@website", company.Website);
                    command.Parameters.AddWithValue("@id", company.Id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<Company> SearchCompanies(string search)
        {
            List<Company> companies = new List<Company>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query =
                    "SELECT * FROM Companies WHERE CompanyName LIKE @search";

                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@search", "%" + search + "%");


                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Company company = new Company();

                            company.Id = reader.GetInt32("Id");
                            company.CompanyName = reader.GetString("CompanyName");
                            company.City = reader.GetString("City");
                            company.Website = reader.GetString("Website");

                            companies.Add(company);
                        }
                    }
                }
            }
            return companies;
        }
    }
}
