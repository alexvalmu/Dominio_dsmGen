
using System;
// Definición clase Usuario_adminEN
namespace Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm
{
public partial class Usuario_adminEN                                                                        : Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.UsuarioEN


{
/**
 *	Atributo numSocio
 */
private int numSocio;






public virtual int NumSocio {
        get { return numSocio; } set { numSocio = value;  }
}





public Usuario_adminEN() : base ()
{
}



public Usuario_adminEN(string email, int numSocio
                       , string nombre, Nullable<DateTime> fechaNac, System.Collections.Generic.IList<Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.PedidoEN> pedido, String pass
                       )
{
        this.init (Email, numSocio, nombre, fechaNac, pedido, pass);
}


public Usuario_adminEN(Usuario_adminEN usuario_admin)
{
        this.init (usuario_admin.Email, usuario_admin.NumSocio, usuario_admin.Nombre, usuario_admin.FechaNac, usuario_admin.Pedido, usuario_admin.Pass);
}

private void init (string email
                   , int numSocio, string nombre, Nullable<DateTime> fechaNac, System.Collections.Generic.IList<Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.PedidoEN> pedido, String pass)
{
        this.Email = email;


        this.NumSocio = numSocio;

        this.Nombre = nombre;

        this.FechaNac = fechaNac;

        this.Pedido = pedido;

        this.Pass = pass;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Usuario_adminEN t = obj as Usuario_adminEN;
        if (t == null)
                return false;
        if (Email.Equals (t.Email))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Email.GetHashCode ();
        return hash;
}
}
}
