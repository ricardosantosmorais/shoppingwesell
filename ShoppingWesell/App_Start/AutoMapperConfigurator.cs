using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Shopping.Admin.Models;
using Shopping.Dominio.Entidades;

namespace ShoppingWesell
{
    public class AutoMapperConfigurator
    {
        public static void Configure()
        {
            Mapper.CreateMap<CategoriaViewModel, Categoria>();
            Mapper.CreateMap<Categoria, CategoriaViewModel>();
            Mapper.CreateMap<Departamento, DepartamentoViewModel>();
            Mapper.CreateMap<DepartamentoViewModel, Departamento>();
            Mapper.CreateMap<LojaViewModel, Loja>();
            Mapper.CreateMap<Loja, LojaViewModel>();
        }
    }
}