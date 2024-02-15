using AutoMapper;
using PruebaTBrowser.Application.Feature.Clientes.Commands;
using PruebaTBrowser.Models.Entities;
using PruebaTBrowser.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTBrowser.Application.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Cliente, CreateClienteCommand>().ReverseMap();

            CreateMap<Cliente, ClienteViewModel>().ReverseMap();

            CreateMap<Ciudad, CiudadViewModel>().ReverseMap();

            CreateMap<Departamento, DepartamentoViewModel>().ReverseMap();

            CreateMap<Pais, PaisViewModel>().ReverseMap();

            CreateMap<Estado, EstadoViewModel>().ReverseMap();

            CreateMap<MedioPago, MedioPagoViewModel>().ReverseMap();

        }
    }
}
