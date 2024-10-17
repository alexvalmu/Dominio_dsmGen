
using System;
// Definición clase LineaPedidoEN
namespace Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm
{
public partial class LineaPedidoEN
{
/**
 *	Atributo num
 */
private int num;



/**
 *	Atributo pedido
 */
private Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.PedidoEN pedido;



/**
 *	Atributo cantidad
 */
private int cantidad;



/**
 *	Atributo importe
 */
private string importe;



/**
 *	Atributo articulo
 */
private Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.ArticuloEN articulo;






public virtual int Num {
        get { return num; } set { num = value;  }
}



public virtual Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.PedidoEN Pedido {
        get { return pedido; } set { pedido = value;  }
}



public virtual int Cantidad {
        get { return cantidad; } set { cantidad = value;  }
}



public virtual string Importe {
        get { return importe; } set { importe = value;  }
}



public virtual Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.ArticuloEN Articulo {
        get { return articulo; } set { articulo = value;  }
}





public LineaPedidoEN()
{
}



public LineaPedidoEN(int num, Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.PedidoEN pedido, int cantidad, string importe, Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.ArticuloEN articulo
                     )
{
        this.init (Num, pedido, cantidad, importe, articulo);
}


public LineaPedidoEN(LineaPedidoEN lineaPedido)
{
        this.init (lineaPedido.Num, lineaPedido.Pedido, lineaPedido.Cantidad, lineaPedido.Importe, lineaPedido.Articulo);
}

private void init (int num
                   , Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.PedidoEN pedido, int cantidad, string importe, Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.ArticuloEN articulo)
{
        this.Num = num;


        this.Pedido = pedido;

        this.Cantidad = cantidad;

        this.Importe = importe;

        this.Articulo = articulo;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        LineaPedidoEN t = obj as LineaPedidoEN;
        if (t == null)
                return false;
        if (Num.Equals (t.Num))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Num.GetHashCode ();
        return hash;
}
}
}
