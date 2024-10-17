
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
 * Clase Pedido:
 *
 */

namespace Dominio_dsmGen.Infraestructure.Repository.Dominio_dsm
{
public partial class PedidoRepository : BasicRepository, IPedidoRepository
{
public PedidoRepository() : base ()
{
}


public PedidoRepository(GenericSessionCP sessionAux) : base (sessionAux)
{
}


public void setSessionCP (GenericSessionCP session)
{
        sessionInside = false;
        this.session = (ISession)session.CurrentSession;
}


public PedidoEN ReadOIDDefault (int id
                                )
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(PedidoNH)).
                                         SetFirstResult (first).SetMaxResults (size).List<PedidoEN>();
                        else
                                result = session.CreateCriteria (typeof(PedidoNH)).List<PedidoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in PedidoRepository.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoNH pedidoNH = (PedidoNH)session.Load (typeof(PedidoNH), pedido.Id);



                pedidoNH.Estado = pedido.Estado;


                pedidoNH.Fecha = pedido.Fecha;


                pedidoNH.Entrega_est = pedido.Entrega_est;


                pedidoNH.Cod_promocional = pedido.Cod_promocional;


                pedidoNH.Gastos_envio = pedido.Gastos_envio;


                session.Update (pedidoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in PedidoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int Nuevo (PedidoEN pedido)
{
        PedidoNH pedidoNH = new PedidoNH (pedido);

        try
        {
                SessionInitializeTransaction ();
                if (pedido.Usuario != null) {
                        // Argumento OID y no colección.
                        pedidoNH
                        .Usuario = (Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.UsuarioEN)session.Load (typeof(Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.UsuarioEN), pedido.Usuario.Email);

                        pedidoNH.Usuario.Pedido
                        .Add (pedidoNH);
                }
                if (pedido.LineaPedido != null) {
                        foreach (Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.LineaPedidoEN item in pedido.LineaPedido) {
                                item.Pedido = pedido;
                                LineaPedidoNH itemNH = new LineaPedidoNH (item);
                                session.Save (itemNH);
                        }
                }
                if (pedido.Direccion != null) {
                        // Argumento OID y no colección.
                        pedidoNH
                        .Direccion = (Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.DireccionEN)session.Load (typeof(Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.DireccionEN), pedido.Direccion.Id);

                        pedidoNH.Direccion.Pedido
                        .Add (pedidoNH);
                }

                session.Save (pedidoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in PedidoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return pedidoNH.Id;
}

public void Modificar (PedidoEN pedido)
{
        try
        {
                SessionInitializeTransaction ();
                PedidoNH pedidoNH = (PedidoNH)session.Load (typeof(PedidoNH), pedido.Id);

                pedidoNH.Estado = pedido.Estado;


                pedidoNH.Fecha = pedido.Fecha;


                pedidoNH.Entrega_est = pedido.Entrega_est;


                pedidoNH.Cod_promocional = pedido.Cod_promocional;


                pedidoNH.Gastos_envio = pedido.Gastos_envio;

                session.Update (pedidoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in PedidoRepository.", ex);
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
                PedidoNH pedidoNH = (PedidoNH)session.Load (typeof(PedidoNH), id);
                session.Delete (pedidoNH);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in PedidoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: DameOID
//Con e: PedidoEN
public PedidoEN DameOID (int id
                         )
{
        PedidoEN pedidoEN = null;

        try
        {
                SessionInitializeTransaction ();
                pedidoEN = (PedidoEN)session.Get (typeof(PedidoNH), id);
                SessionCommit ();
        }

        catch (Exception) {
        }


        finally
        {
                SessionClose ();
        }

        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> DameALL (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(PedidoNH)).
                                 SetFirstResult (first).SetMaxResults (size).List<PedidoEN>();
                else
                        result = session.CreateCriteria (typeof(PedidoNH)).List<PedidoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is Dominio_dsmGen.ApplicationCore.Exceptions.ModelException)
                        throw;
                else throw new Dominio_dsmGen.ApplicationCore.Exceptions.DataLayerException ("Error in PedidoRepository.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
