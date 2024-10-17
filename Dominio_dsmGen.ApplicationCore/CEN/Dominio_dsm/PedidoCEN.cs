

using System;
using System.Text;
using System.Collections.Generic;

using Dominio_dsmGen.ApplicationCore.Exceptions;

using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm;


namespace Dominio_dsmGen.ApplicationCore.CEN.Dominio_dsm
{
/*
 *      Definition of the class PedidoCEN
 *
 */
public partial class PedidoCEN
{
private IPedidoRepository _IPedidoRepository;

public PedidoCEN(IPedidoRepository _IPedidoRepository)
{
        this._IPedidoRepository = _IPedidoRepository;
}

public IPedidoRepository get_IPedidoRepository ()
{
        return this._IPedidoRepository;
}

public int Nuevo (string p_usuario, System.Collections.Generic.IList<Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.LineaPedidoEN> p_lineaPedido, Dominio_dsmGen.ApplicationCore.Enumerated.Dominio_dsm.EstadoPedidoEnum p_estado, Nullable<DateTime> p_fecha, Nullable<DateTime> p_entrega_est, long p_cod_promocional, string p_gastos_envio, int p_direccion)
{
        PedidoEN pedidoEN = null;
        int oid;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();

        if (p_usuario != null) {
                // El argumento p_usuario -> Property usuario es oid = false
                // Lista de oids id
                pedidoEN.Usuario = new Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.UsuarioEN ();
                pedidoEN.Usuario.Email = p_usuario;
        }

        pedidoEN.LineaPedido = p_lineaPedido;

        pedidoEN.Estado = p_estado;

        pedidoEN.Fecha = p_fecha;

        pedidoEN.Entrega_est = p_entrega_est;

        pedidoEN.Cod_promocional = p_cod_promocional;

        pedidoEN.Gastos_envio = p_gastos_envio;


        if (p_direccion != -1) {
                // El argumento p_direccion -> Property direccion es oid = false
                // Lista de oids id
                pedidoEN.Direccion = new Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.DireccionEN ();
                pedidoEN.Direccion.Id = p_direccion;
        }



        oid = _IPedidoRepository.Nuevo (pedidoEN);
        return oid;
}

public void Modificar (int p_Pedido_OID, Dominio_dsmGen.ApplicationCore.Enumerated.Dominio_dsm.EstadoPedidoEnum p_estado, Nullable<DateTime> p_fecha, Nullable<DateTime> p_entrega_est, long p_cod_promocional, string p_gastos_envio)
{
        PedidoEN pedidoEN = null;

        //Initialized PedidoEN
        pedidoEN = new PedidoEN ();
        pedidoEN.Id = p_Pedido_OID;
        pedidoEN.Estado = p_estado;
        pedidoEN.Fecha = p_fecha;
        pedidoEN.Entrega_est = p_entrega_est;
        pedidoEN.Cod_promocional = p_cod_promocional;
        pedidoEN.Gastos_envio = p_gastos_envio;
        //Call to PedidoRepository

        _IPedidoRepository.Modificar (pedidoEN);
}

public void Eliminar (int id
                      )
{
        _IPedidoRepository.Eliminar (id);
}

public PedidoEN DameOID (int id
                         )
{
        PedidoEN pedidoEN = null;

        pedidoEN = _IPedidoRepository.DameOID (id);
        return pedidoEN;
}

public System.Collections.Generic.IList<PedidoEN> DameALL (int first, int size)
{
        System.Collections.Generic.IList<PedidoEN> list = null;

        list = _IPedidoRepository.DameALL (first, size);
        return list;
}
}
}
