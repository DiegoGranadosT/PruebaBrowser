using MediatR;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using PruebaTBrowser.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Application.Feature.Estadisticas
{
    public class ReservasByEstadoIdQuery : IRequest<List<ReservaViewModel>>
    {
        public int EstadoId { get; set; }
    }

    public class ReservasByEstadoIdHandler : IRequestHandler<ReservasByEstadoIdQuery, List<ReservaViewModel>>
    {
        private readonly string _connectionString;

        public ReservasByEstadoIdHandler(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DbConnection");
        }
        public async Task<List<ReservaViewModel>> Handle(ReservasByEstadoIdQuery request, CancellationToken cancellationToken)
        {
            List<ReservaViewModel> data = new List<ReservaViewModel>();;

            string query = $"SELECT r.* FROM reserva r INNER JOIN estado e ON e.Id = r.estadoId WHERE e.Id = '{request.EstadoId}'";

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        MySqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            ReservaViewModel reserva = new ReservaViewModel();
                            reserva.SolucitudId = int.Parse(reader["SolucitudId"].ToString());
                            reserva.EstadoId = int.Parse(reader["EstadoId"].ToString());
                            reserva.FacturaId = int.Parse(reader["FacturaId"].ToString());
                            reserva.Id = int.Parse(reader["Id"].ToString());

                            data.Add(reserva);
                        }

                        reader.Close();

                        return data;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
