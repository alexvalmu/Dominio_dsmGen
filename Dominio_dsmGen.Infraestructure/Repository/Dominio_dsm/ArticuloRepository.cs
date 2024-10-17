
using System;
using System.Text;
using Dominio_dsmGen.ApplicationCore.CEN.Dominio_dsm;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.Exceptions;
using Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm;
using Dominio_dsmGen.Infraestructure.EN.Dominio_dsm;


/*
 * Clase Articulo:
 *
 */

namespace Dominio_dsmGen.Infraestructure.Repository.Dominio_dsm
{
public partial class ArticuloRepository : BasicRepository, IArticuloRepository
{
public ArticuloRepository() : base ()
{
}


public ArticuloRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public ArticuloEN ReadOIDDefault (int id
                                  )
{
        ArticuloEN articuloEN = null;

        try
        {
                SessionInitializeTransaction ();
                articuloEN = (ArticuloEN)session.Get (typeof(ArticuloNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ArticuloNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<ArticuloEN>();
                        else
                                result = session.CreateCriteria (typeof(ArticuloNH)).List<ArticuloEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in ArticuloRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloNH articuloNH = (ArticuloNH)session.Load (typeof(ArticuloNH), articulo.Id);

                articuloNH.Nombre = articulo.Nombre;


                articuloNH.Precio = articulo.Precio;


                articuloNH.Descripcion = articulo.Descripcion;


                articuloNH.Talla = articulo.Talla;


                articuloNH.Recomendaciones = articulo.Recomendaciones;


                articuloNH.Check_verificado = articulo.Check_verificado;


                articuloNH.Desc_verificado = articulo.Desc_verificado;





                articuloNH.Stock = articulo.Stock;

                session.Update (articuloNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in ArticuloRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


//Sin e: DameOID
//Con e: ArticuloEN
public ArticuloEN DameOID (int id
                           )
{
        ArticuloEN articuloEN = null;

        try
        {
                SessionInitializeTransaction ();
                articuloEN = (ArticuloEN)session.Get (typeof(ArticuloNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> DameALL (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(ArticuloNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<ArticuloEN>();
                else
                        result = session.CreateCriteria (typeof(ArticuloNH)).List<ArticuloEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in ArticuloRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}

public int Nuevo (ArticuloEN articulo)
{
        ArticuloNH articuloNH = new ArticuloNH (articulo);

        try
        {
                SessionInitializeTransaction ();
                if (articulo.Marca != null) {
                        // Argumento OID y no colección.
                        articuloNH
                        .Marca = (Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.MarcaEN)session.Load (typeof(Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.MarcaEN), articulo.Marca.Nombre);

                        articuloNH.Marca.Articulo
                        .Add (articuloNH);
                }

                session.Save (articuloNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in ArticuloRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return articuloNH.Id;
}

public void Modificar (ArticuloEN articulo)
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloNH articuloNH = (ArticuloNH)session.Load (typeof(ArticuloNH), articulo.Id);

                articuloNH.Nombre = articulo.Nombre;


                articuloNH.Precio = articulo.Precio;


                articuloNH.Descripcion = articulo.Descripcion;


                articuloNH.Talla = articulo.Talla;


                articuloNH.Recomendaciones = articulo.Recomendaciones;


                articuloNH.Check_verificado = articulo.Check_verificado;


                articuloNH.Desc_verificado = articulo.Desc_verificado;


                articuloNH.Stock = articulo.Stock;

                session.Update (articuloNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in ArticuloRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Eliminar (int id
                      )
{
        try
        {
                SessionInitializeTransaction ();
                ArticuloNH articuloNH = (ArticuloNH)session.Load (typeof(ArticuloNH), id);
                session.Delete (articuloNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in ArticuloRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
