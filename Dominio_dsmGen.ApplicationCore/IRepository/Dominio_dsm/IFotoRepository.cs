
using System;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm;

namespace Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm
{
public partial interface IFotoRepository
{
void setSessionCP (GenericSessionCP session);

FotoEN ReadOIDDefault (int id
                       );

void ModifyDefault (FotoEN foto);

System.Collections.Generic.IList<FotoEN> ReadAllDefault (int first, int size);



int Nuevo (FotoEN foto);

void Modificar (FotoEN foto);


void Eliminar (int id
               );


FotoEN DameOID (int id
                );


System.Collections.Generic.IList<FotoEN> DameALL (int first, int size);
}
}
