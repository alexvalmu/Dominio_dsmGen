
using System;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm;

namespace Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm
{
public partial interface IDireccionRepository
{
void setSessionCP (GenericSessionCP session);

DireccionEN ReadOIDDefault (int id
                            );

void ModifyDefault (DireccionEN direccion);

System.Collections.Generic.IList<DireccionEN> ReadAllDefault (int first, int size);



int Nuevo (DireccionEN direccion);
}
}
