
using System;
using System.Text;
using System.Collections.Generic;
using Dominio_dsmGen.ApplicationCore.Exceptions;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm;


/*PROTECTED REGION ID(usingDominio_dsmGen.ApplicationCore.CEN.Dominio_dsm_Articulo_dec_stock) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace Dominio_dsmGen.ApplicationCore.CEN.Dominio_dsm
{
public partial class ArticuloCEN
{
public void Dec_stock (int p_oid, int p_cantidad)
{
            /*PROTECTED REGION ID(Dominio_dsmGen.ApplicationCore.CEN.Dominio_dsm_Articulo_dec_stock) ENABLED START*/

            // Write here your custom code...
             Console.WriteLine("Decrementando stock del articulo con oid: " + p_oid + " en " + p_cantidad + " unidades");
            ArticuloEN en = _IArticuloRepository.DameOID(p_oid);
            Console.WriteLine("En stock:" + en.Stock);

            if(!(en.Stock >= p_cantidad))
                throw new Exception("La cantidad siempre tiene que ser inferior o igual al stock");

            en.Stock -= p_cantidad;

            _IArticuloRepository.ModifyDefault(en);
         
            /*PROTECTED REGION END*/
        }
}
}
