
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
 * Clase Direccion:
 *
 */

namespace Dominio_dsmGen.Infraestructure.Repository.Dominio_dsm
{
public partial class DireccionRepository : BasicRepository, IDireccionRepository
{
public DireccionRepository() : base ()
{
}


public DireccionRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public DireccionEN ReadOIDDefault (int id
                                   )
{
        DireccionEN direccionEN = null;

        try
        {
                SessionInitializeTransaction ();
                direccionEN = (DireccionEN)session.Get (typeof(DireccionNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return direccionEN;
}

public System.Collections.Generic.IList<DireccionEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<DireccionEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(DireccionNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<DireccionEN>();
                        else
                                result = session.CreateCriteria (typeof(DireccionNH)).List<DireccionEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in DireccionRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (DireccionEN direccion)
{
        try
        {
                SessionInitializeTransaction ();
                DireccionNH direccionNH = (DireccionNH)session.Load (typeof(DireccionNH), direccion.Id);

                direccionNH.Calle = direccion.Calle;


                direccionNH.Provincia = direccion.Provincia;


                direccionNH.CodPost = direccion.CodPost;


                direccionNH.Telf = direccion.Telf;


                direccionNH.NombreCompleto = direccion.NombreCompleto;


                session.Update (direccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in DireccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (DireccionEN direccion)
{
        DireccionNH direccionNH = new DireccionNH (direccion);

        try
        {
                SessionInitializeTransaction ();

                session.Save (direccionNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in DireccionRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return direccionNH.Id;
}
}
}
