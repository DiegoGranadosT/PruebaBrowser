using MediatR;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using PruebaTBrowser.Models.Entities;
using PruebaTBrowser.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Application.Feature.Estadisticas
{
    public class Clientes : IRequest<List<ClienteViewModel>>
    {
        public int CiudadId { get; set; }
    }

    public class ClienteHandler : IRequestHandler<Clientes, List<ClienteViewModel>>
    {
        private readonly string _connectionString;

        public ClienteHandler(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DbConnection");
        }
        public async Task<List<ClienteViewModel>> Handle(Clientes request, CancellationToken cancellationToken)
        {
            List<ClienteViewModel> clientes = new List<ClienteViewModel>();

            string query = $"SELECT DISTINCT c.* FROM cliente c INNER JOIN solicitud s ON s.ClienteId = c.Id INNER JOIN reserva r ON s.Id = r.SolucitudId WHERE c.Edad >= 40 and c.CiudadId = '{request.CiudadId}'";

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
                            ClienteViewModel cliente = new ClienteViewModel();
                            cliente.Nombres = reader["Nombres"].ToString();
                            cliente.Apellidos = reader["Apellidos"].ToString();
                            cliente.CorreoElectronico = reader["CorreoElectronico"].ToString();
                            cliente.Telefono = reader["Telefono"].ToString();
                            cliente.Genero = reader["Genero"].ToString();
                            cliente.EmpresaId = int.Parse(reader["EmpresaId"].ToString());
                            cliente.CiudadId = int.Parse(reader["CiudadId"].ToString());
                            cliente.Id = int.Parse(reader["Id"].ToString());

                            clientes.Add(cliente);
                        }

                        reader.Close();

                        return clientes;
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
