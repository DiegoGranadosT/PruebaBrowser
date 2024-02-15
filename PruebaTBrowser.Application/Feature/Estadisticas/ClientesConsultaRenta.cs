using MediatR;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using PruebaTBrowser.Shared.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Application.Feature.Estadisticas
{
    public class ClientesConsultaRenta : IRequest<ClientesConsultaRentaModel>
    {
    }

    public class ClientesConsultaRentaHandler : IRequestHandler<ClientesConsultaRenta, ClientesConsultaRentaModel>
    {
        private readonly string _connectionString;
        public ClientesConsultaRentaHandler(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DbConnection");
        }
        public async Task<ClientesConsultaRentaModel> Handle(ClientesConsultaRenta request, CancellationToken cancellationToken)
        {

            string query = $"SELECT COUNT(DISTINCT clienteId) AS cantidad_clientes FROM solicitud";

            using (MySqlConnection connection = new MySqlConnection(_connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        var result = new ClientesConsultaRentaModel
                        {
                            Cantidad = Convert.ToInt32(command.ExecuteScalar())
                        };
                        return result;
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
