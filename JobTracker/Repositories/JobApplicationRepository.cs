using System;
using System.Collections.Generic;
using System.Text;
using JobTracker.Data;
using JobTracker.Models;
using JobTracker.Repositories;
using MySql.Data.MySqlClient;

namespace JobTracker.Repositories
{
    internal class JobApplicationRepository
    {
        private readonly Database database = new Database();
        public List<JobApplication> GetAllApplications()
        {
            List<JobApplication> applications = new List<JobApplication>();

            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query =
                    @"SELECT 
                        Applications.Id,
                        Applications.CompanyId,
                        Companies.CompanyName,
                        Applications.Position,
                        Applications.ApplicationStatus,
                        Applications.DateApplied
                      FROM Applications
                      INNER JOIN Companies
                      ON Applications.CompanyId = Companies.Id";


                using (var command = new MySqlCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            JobApplication application = new JobApplication();

                            application.Id = reader.GetInt32("Id");
                            application.CompanyId = reader.GetInt32("CompanyId");
                            application.CompanyName = reader.GetString("CompanyName");
                            application.Position = reader.GetString("Position");
                            application.ApplicationStatus = reader.GetString("ApplicationStatus");
                            application.DateApplied = reader.GetDateTime("DateApplied");

                            applications.Add(application);
                        }
                    }
                }
            }

            return applications;
        }
        public void AddApplication(JobApplication application)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();

                string query =
                        @"INSERT INTO Applications
                (CompanyId, Position, ApplicationStatus, DateApplied)
                VALUES
                (@companyId,@position,@status,@date)";


                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@companyId", application.CompanyId);
                    command.Parameters.AddWithValue("@position", application.Position);
                    command.Parameters.AddWithValue("@status", application.ApplicationStatus);
                    command.Parameters.AddWithValue("@date", application.DateApplied);

                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteApplication(int id)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();
                string query = "DELETE FROM Applications WHERE Id = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateApplication(JobApplication application)
        {
            using (var connection = database.GetConnection())
            {
                connection.Open();
                string query =
                    @"UPDATE Applications
                      SET CompanyId = @companyId,
                          Position = @position,
                          ApplicationStatus = @status,
                          DateApplied = @date
                      WHERE Id = @id";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@companyId", application.CompanyId);
                    command.Parameters.AddWithValue("@position", application.Position);
                    command.Parameters.AddWithValue("@status", application.ApplicationStatus);
                    command.Parameters.AddWithValue("@date", application.DateApplied);
                    command.Parameters.AddWithValue("@id", application.Id);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
