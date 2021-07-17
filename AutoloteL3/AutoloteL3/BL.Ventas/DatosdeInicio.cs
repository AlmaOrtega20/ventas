using BL.Ventas;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Rentas
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {

            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "1234";

            contexto.Usuarios.Add(usuarioAdmin);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "4x4";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Turismo";
            contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "4x2";
            contexto.Categorias.Add(categoria3);

            var categoria4 = new Categoria();
            categoria4.Descripcion = "Mecanico";
            contexto.Categorias.Add(categoria4);

            var categorias1 = new Categoria();
            categoria1.Descripcion = "4x4";
            contexto.Categorias.Add(categoria1);

            var categorias2 = new Categoria();
            categoria2.Descripcion = "Turismo";
            contexto.Categorias.Add(categoria2);

            var categorias3 = new Categoria();
            categoria3.Descripcion = "4x2";
            contexto.Categorias.Add(categoria3);

            var categorias4 = new Categoria();
            categoria4.Descripcion = "Mecanico";
            contexto.Categorias.Add(categoria4);

            var cliente1 = new Cliente();
            cliente1.Nombre = "Juan Ortega";
            contexto.Clientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Nombre = "Tony Clark";
            contexto.Clientes.Add(cliente2);

            base.Seed(contexto);
        }
    }
}