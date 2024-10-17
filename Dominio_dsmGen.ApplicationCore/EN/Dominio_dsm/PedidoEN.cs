
using System;
// Definición clase PedidoEN
namespace Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm
{
public partial class PedidoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo usuario
 */
private Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.UsuarioEN usuario;



/**
 *	Atributo lineaPedido
 */
private System.Collections.Generic.IList<Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.LineaPedidoEN> lineaPedido;



/**
 *	Atributo estado
 */
private Dominio_dsmGen.ApplicationCore.Enumerated.Dominio_dsm.EstadoPedidoEnum estado;



/**
 *	Atributo fecha
 */
private Nullable<DateTime> fecha;



/**
 *	Atributo entrega_est
 */
private Nullable<DateTime> entrega_est;



/**
 *	Atributo cod_promocional
 */
private long cod_promocional;



/**
 *	Atributo gastos_envio
 */
private string gastos_envio;



/**
 *	Atributo direccion
 */
private Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.DireccionEN direccion;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.UsuarioEN Usuario {
        get { return usuario; } set { usuario = value;  }
}



public virtual System.Collections.Generic.IList<Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.LineaPedidoEN> LineaPedido {
        get { return lineaPedido; } set { lineaPedido = value;  }
}



public virtual Dominio_dsmGen.ApplicationCore.Enumerated.Dominio_dsm.EstadoPedidoEnum Estado {
        get { return estado; } set { estado = value;  }
}



public virtual Nullable<DateTime> Fecha {
        get { return fecha; } set { fecha = value;  }
}



public virtual Nullable<DateTime> Entrega_est {
        get { return entrega_est; } set { entrega_est = value;  }
}



public virtual long Cod_promocional {
        get { return cod_promocional; } set { cod_promocional = value;  }
}



public virtual string Gastos_envio {
        get { return gastos_envio; } set { gastos_envio = value;  }
}



public virtual Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.DireccionEN Direccion {
        get { return direccion; } set { direccion = value;  }
}





public PedidoEN()
{
        lineaPedido = new System.Collections.Generic.List<Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.LineaPedidoEN>();
}



public PedidoEN(int id, Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.UsuarioEN usuario, System.Collections.Generic.IList<Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.LineaPedidoEN> lineaPedido, Dominio_dsmGen.ApplicationCore.Enumerated.Dominio_dsm.EstadoPedidoEnum estado, Nullable<DateTime> fecha, Nullable<DateTime> entrega_est, long cod_promocional, string gastos_envio, Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.DireccionEN direccion
                )
{
        this.init (Id, usuario, lineaPedido, estado, fecha, entrega_est, cod_promocional, gastos_envio, direccion);
}


public PedidoEN(PedidoEN pedido)
{
        this.init (pedido.Id, pedido.Usuario, pedido.LineaPedido, pedido.Estado, pedido.Fecha, pedido.Entrega_est, pedido.Cod_promocional, pedido.Gastos_envio, pedido.Direccion);
}

private void init (int id
                   , Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.UsuarioEN usuario, System.Collections.Generic.IList<Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.LineaPedidoEN> lineaPedido, Dominio_dsmGen.ApplicationCore.Enumerated.Dominio_dsm.EstadoPedidoEnum estado, Nullable<DateTime> fecha, Nullable<DateTime> entrega_est, long cod_promocional, string gastos_envio, Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.DireccionEN direccion)
{
        this.Id = id;


        this.Usuario = usuario;

        this.LineaPedido = lineaPedido;

        this.Estado = estado;

        this.Fecha = fecha;

        this.Entrega_est = entrega_est;

        this.Cod_promocional = cod_promocional;

        this.Gastos_envio = gastos_envio;

        this.Direccion = direccion;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        PedidoEN t = obj as PedidoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
