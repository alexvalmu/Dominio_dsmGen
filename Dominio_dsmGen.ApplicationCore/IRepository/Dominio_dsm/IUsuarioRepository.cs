
using System;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm;

namespace Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm
{
public partial interface IUsuarioRepository
{
void setSessionCP (GenericSessionCP session);

UsuarioEN ReadOIDDefault (string email
                          );

void ModifyDefault (UsuarioEN usuario);

System.Collections.Generic.IList<UsuarioEN> ReadAllDefault (int first, int size);



string Nuevo (UsuarioEN usuario);

void Modificar (UsuarioEN usuario);


void Eliminar (string email
               );


UsuarioEN DameOID (string email
                   );


System.Collections.Generic.IList<UsuarioEN> DameALL (int first, int size);
}
}
