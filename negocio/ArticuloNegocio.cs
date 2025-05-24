using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("select a.id, a.codigo, a.nombre, a.descripcion, m.descripcion as marca, c.descripcion as categoria, a.IdMarca, a.IdCategoria, a.imagenurl, a.precio from ARTICULOS a, MARCAS m, CATEGORIAS c where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)accesoDatos.Lector["id"];
                    aux.Codigo = (string)accesoDatos.Lector["codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)accesoDatos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)accesoDatos.Lector["marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)accesoDatos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)accesoDatos.Lector["categoria"];
                    aux.ImagenUrl = (string)accesoDatos.Lector["imagenurl"];
                    aux.Precio = (decimal)accesoDatos.Lector["precio"];

                    lista.Add(aux);
                }

                return lista;

            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                accesoDatos.cerrarLectura();
            }
            
        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                accesoDatos.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values (@codigo, @nombre, @descripcion, @idmarca, @idcategoria, @imagenurl, @precio)");
                accesoDatos.setearParametro("@codigo", nuevo.Codigo);
                accesoDatos.setearParametro("@nombre", nuevo.Nombre);
                accesoDatos.setearParametro("@descripcion", nuevo.Descripcion);
                accesoDatos.setearParametro("@idmarca", nuevo.Marca.Id);
                accesoDatos.setearParametro("@idcategoria", nuevo.Categoria.Id);
                accesoDatos.setearParametro("@imagenurl", nuevo.ImagenUrl);
                accesoDatos.setearParametro("@precio", nuevo.Precio);
                accesoDatos.ejecutarNonQuery();  

            }
            catch (Exception err)
            {
                throw err;
            }
            finally 
            {
                accesoDatos.cerrarLectura();
            }   
        }

        public void modificar(Articulo modificable)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, ImagenUrl = @imagenurl, Precio = @precio where Id = @id");
                accesoDatos.setearParametro("@codigo", modificable.Codigo);
                accesoDatos.setearParametro("@nombre", modificable.Nombre);
                accesoDatos.setearParametro("@descripcion", modificable.Descripcion);
                accesoDatos.setearParametro("@idmarca", modificable.Marca.Id);
                accesoDatos.setearParametro("@idcategoria", modificable.Categoria.Id);
                accesoDatos.setearParametro("@imagenurl", modificable.ImagenUrl);
                accesoDatos.setearParametro("@precio", modificable.Precio);
                accesoDatos.setearParametro("@id", modificable.Id);
                accesoDatos.ejecutarNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally 
            {
                accesoDatos.cerrarLectura();
            }
        }

        public void eliminar(int articulo)
        {
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("delete ARTICULOS where id = @id");
                accesoDatos.setearParametro("@id", articulo);
                accesoDatos.ejecutarNonQuery();
            }
            catch (Exception err)
            {
                throw err;
            }
            finally
            {
                accesoDatos.cerrarLectura();
            }

        }
    }
}
