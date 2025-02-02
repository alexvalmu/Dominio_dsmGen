
using System;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm;

namespace Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm
{
public partial interface IArticuloRepository
{
void setSessionCP (GenericSessionCP session);

ArticuloEN ReadOIDDefault (int id
                           );

void ModifyDefault (ArticuloEN articulo);

System.Collections.Generic.IList<ArticuloEN> ReadAllDefault (int first, int size);



ArticuloEN DameOID (int id
                    );


System.Collections.Generic.IList<ArticuloEN> DameALL (int first, int size);


int Nuevo (ArticuloEN articulo);

void Modificar (ArticuloEN articulo);


void Eliminar (int id
               );
}
}
