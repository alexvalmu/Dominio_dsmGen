
using System;
// Definición clase FotoEN
namespace Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm
{
public partial class FotoEN
{
/**
 *	Atributo articulo
 */
private Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.ArticuloEN articulo;



/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo archivo
 */
private string archivo;



/**
 *	Atributo alt
 */
private string alt;






public virtual Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.ArticuloEN Articulo {
        get { return articulo; } set { articulo = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Archivo {
        get { return archivo; } set { archivo = value;  }
}



public virtual string Alt {
        get { return alt; } set { alt = value;  }
}





public FotoEN()
{
}



public FotoEN(int id, Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.ArticuloEN articulo, string archivo, string alt
              )
{
        this.init (Id, articulo, archivo, alt);
}


public FotoEN(FotoEN foto)
{
        this.init (foto.Id, foto.Articulo, foto.Archivo, foto.Alt);
}

private void init (int id
                   , Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.ArticuloEN articulo, string archivo, string alt)
{
        this.Id = id;


        this.Articulo = articulo;

        this.Archivo = archivo;

        this.Alt = alt;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        FotoEN t = obj as FotoEN;
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
