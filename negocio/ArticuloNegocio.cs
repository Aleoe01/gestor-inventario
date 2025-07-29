using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        // Devuelve una lista completa de artículos desde la base de datos, incluyendo marca y categoría
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setearConsulta("select a.id, a.codigo, a.nombre, a.descripcion, m.descripcion as marca, c.descripcion as categoria, a.IdMarca, a.IdCategoria, a.imagenurl, a.precio from ARTICULOS a, MARCAS m, CATEGORIAS c where a.IdMarca = m.Id and a.IdCategoria = c.Id");
                accesoDatos.ejecutarLectura();

                // Carga cada artículo encontrado en una lista
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
                // Inserta el nuevo artículo usando parámetros
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
                // Actualiza todos los campos del artículo
                accesoDatos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, IdMarca = @idmarca, IdCategoria = @idcategoria, ImagenUrl = @imagenurl, Precio = @precio where Id = @id");
                accesoDatos.setearParametro("@codigo", modificable.Codigo);
                accesoDatos.setearParametro("@nombre", modificable.Nombre);
                accesoDatos.setearParametro("@descripcion", modificable.Descripcion);
                accesoDatos.setearParametro("@idmarca", modificable.Marca.Id);
                accesoDatos.setearParametro("@idcategoria", modificable.Categoria.Id);
                accesoDatos.setearParametro("@imagenurl", modificable.ImagenUrl);
                accesoDatos.setearParametro("@precio", modificable.Precio);
                accesoDatos.setearParametro("@id", modificable.Id);
                accesoDatos.ejecutarNonQuery(); // Ejecuta UPDATE
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
                accesoDatos.ejecutarNonQuery(); // Ejecuta DELETE
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

        // Devuelve una lista filtrada de artículos según los criterios ingresados por el usuario
        public List<Articulo> filtrar(string nombre, string marca, string categoria, decimal? min, decimal? max) 
        {
            List<Articulo> articulos = new List<Articulo>();
            
            AccesoDatos accesoDatos = new AccesoDatos();


            // Acá se pone complicado, pero es lo mejor que pude hacer con nada mas que lo aprendido y sin usar (demasiado) chatGPT
            try
            {
                string consulta = "select a.id, a.codigo, a.nombre, a.descripcion, m.descripcion as marca, c.descripcion as categoria, a.IdMarca, a.IdCategoria, a.imagenurl, a.precio from ARTICULOS a, MARCAS m, CATEGORIAS c where a.IdMarca = m.Id and a.IdCategoria = c.Id";
                
                // Se agrega a la consulta todos los parametros que no se encuentren vacios
                if (!string.IsNullOrEmpty(nombre))
                {
                    consulta += " and a.Nombre like @nombre";
                    accesoDatos.setearParametro("@nombre", "%" + nombre + "%");
                }
                if (!string.IsNullOrEmpty(marca))
                {
                    consulta += " and m.descripcion like @marca";
                    accesoDatos.setearParametro("@marca", "%" + marca + "%");
                }
                if (!string.IsNullOrEmpty(categoria))
                {
                    consulta += " and c.descripcion like @categoria";
                    accesoDatos.setearParametro("@categoria", "%" + categoria + "%");
                }
                if (min.HasValue)
                {
                    consulta += " and a.precio >= @precioMin";
                    accesoDatos.setearParametro("@precioMin", min);
                }
                if (max.HasValue)
                {
                    consulta += " and a.precio <= @precioMax";
                    accesoDatos.setearParametro("@precioMax", max);
                }

                accesoDatos.setearConsulta(consulta);                
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

                    articulos.Add(aux);
                }

                return articulos;
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
