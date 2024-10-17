

using System;
using System.Text;
using System.Collections.Generic;

using Dominio_dsmGen.ApplicationCore.Exceptions;

using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm;


namespace Dominio_dsmGen.ApplicationCore.CEN.Dominio_dsm
{
/*
 *      Definition of the class ArticuloCEN
 *
 */
public partial class ArticuloCEN
{
private IArticuloRepository _IArticuloRepository;

public ArticuloCEN(IArticuloRepository _IArticuloRepository)
{
        this._IArticuloRepository = _IArticuloRepository;
}

public IArticuloRepository get_IArticuloRepository ()
{
        return this._IArticuloRepository;
}

public ArticuloEN DameOID (int id
                           )
{
        ArticuloEN articuloEN = null;

        articuloEN = _IArticuloRepository.DameOID (id);
        return articuloEN;
}

public System.Collections.Generic.IList<ArticuloEN> DameALL (int first, int size)
{
        System.Collections.Generic.IList<ArticuloEN> list = null;

        list = _IArticuloRepository.DameALL (first, size);
        return list;
}
public int Nuevo (string p_nombre, string p_precio, string p_descripcion, Dominio_dsmGen.ApplicationCore.Enumerated.Dominio_dsm.Talla_artEnum p_talla, string p_recomendaciones, bool p_check_verificado, string p_desc_verificado, string p_marca, int p_stock)
{
        ArticuloEN articuloEN = null;
        int oid;

        //Initialized ArticuloEN
        articuloEN = new ArticuloEN ();
        articuloEN.Nombre = p_nombre;

        articuloEN.Precio = p_precio;

        articuloEN.Descripcion = p_descripcion;

        articuloEN.Talla = p_talla;

        articuloEN.Recomendaciones = p_recomendaciones;

        articuloEN.Check_verificado = p_check_verificado;

        articuloEN.Desc_verificado = p_desc_verificado;


        if (p_marca != null) {
                // El argumento p_marca -> Property marca es oid = false
                // Lista de oids id
                articuloEN.Marca = new Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm.MarcaEN ();
                articuloEN.Marca.Nombre = p_marca;
        }

        articuloEN.Stock = p_stock;



        oid = _IArticuloRepository.Nuevo (articuloEN);
        return oid;
}

public void Modificar (int p_Articulo_OID, string p_nombre, string p_precio, string p_descripcion, Dominio_dsmGen.ApplicationCore.Enumerated.Dominio_dsm.Talla_artEnum p_talla, string p_recomendaciones, bool p_check_verificado, string p_desc_verificado, int p_stock)
{
        ArticuloEN articuloEN = null;

        //Initialized ArticuloEN
        articuloEN = new ArticuloEN ();
        articuloEN.Id = p_Articulo_OID;
        articuloEN.Nombre = p_nombre;
        articuloEN.Precio = p_precio;
        articuloEN.Descripcion = p_descripcion;
        articuloEN.Talla = p_talla;
        articuloEN.Recomendaciones = p_recomendaciones;
        articuloEN.Check_verificado = p_check_verificado;
        articuloEN.Desc_verificado = p_desc_verificado;
        articuloEN.Stock = p_stock;
        //Call to ArticuloRepository

        _IArticuloRepository.Modificar (articuloEN);
}

public void Eliminar (int id
                      )
{
        _IArticuloRepository.Eliminar (id);
}
}
}
