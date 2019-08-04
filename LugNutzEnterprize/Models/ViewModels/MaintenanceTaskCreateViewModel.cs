using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LugNutzEnterprize.Models
{
    public class MaintenanceTaskCreateViewModel
    {
        public List<Vehicle> Vehicles { get; set; }
        public MaintenanceTask MaintenanceTask { get; set; }

        private readonly string _connectionString;

        private SqlConnection Connection
        {
            get
            {
                return new SqlConnection(_connectionString);
            }
        }

        public MaintenanceCreateViewModel(string connectionString)
        {
            _connectionString = connectionString;

            Vehicles = GetAllVehicles()
                .Select(li => new SelectListItem
                {
                    Text = li.ModelYear + li.Make + li.Model,                    
                    Text = li.VehicleId
                })
                .ToList();
                Vehicles
                .Insert(0, new SelectListItem
                {
                    Text = "Choose vehicle...",
                    Value = "0"
                 });
        }

        private List<Vehicle> GetAllVehicles()
        {
            using (SqlConnection conn = Connection)
            {
                conn.Open();
                using (SqlCommand cmd = conn.CreateCommand())
                {
                    cmd.CommandText = "SELECT Id, CohortName FROM Cohort";
                    SqlDataReader reader = cmd.ExecuteReader();

                    List<Cohort> cohorts = new List<Cohort>();
                    while (reader.Read())
                    {
                        cohorts.Add(new Cohort
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            CohortName = reader.GetString(reader.GetOrdinal("CohortName")),
                        });
                    }

                    reader.Close();

                    return cohorts;
                }
            }
        }

    }   
}
