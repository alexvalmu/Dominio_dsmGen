
using System;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm;

namespace Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm
{
public partial interface IMarcaRepository
{
void setSessionCP (GenericSessionCP session);

MarcaEN ReadOIDDefault (string nombre
                        );

void ModifyDefault (MarcaEN marca);

System.Collections.Generic.IList<MarcaEN> ReadAllDefault (int first, int size);



string Nuevo (MarcaEN marca);

void Modificar (MarcaEN marca);


void Eliminar (string nombre
               );


System.Collections.Generic.IList<MarcaEN> DameALL (int first, int size);
}
}
