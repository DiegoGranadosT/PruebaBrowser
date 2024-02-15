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
    public class ReservasByMedioPagoIdQuery : IRequest<List<ReservaViewModel>>
    {
        public int MedioPagoId { get; set; }
    }

    public class ReservaHandler : IRequestHandler<ReservasByMedioPagoIdQuery, List<ReservaViewModel>>
    {
        private readonly string _connectionString;

        public ReservaHandler(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DbConnection");
        }
        public async Task<List<ReservaViewModel>> Handle(ReservasByMedioPagoIdQuery request, CancellationToken cancellationToken)
        {
            List<ReservaViewModel> data = new List<ReservaViewModel>();;

            string query = $"SELECT r.* FROM reserva r INNER JOIN factura f ON r.facturaId = f.Id INNER JOIN medioPago m ON m.Id = f.medioPagoId WHERE m.Id = '{request.MedioPagoId}'";

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
                            reserva.SolucitudId = int.Parse(reader["SolicitudId"].ToString());
                            reserva.EstadoId = int.Parse(reader["EstadoId"].ToString());
                            reserva.MedioPagoId = int.Parse(reader["MedioPagoId"].ToString());

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
