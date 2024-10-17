
using System;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm;

namespace Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm
{
public partial interface IUsuario_adminRepository
{
void setSessionCP (GenericSessionCP session);

Usuario_adminEN ReadOIDDefault (string email
                                );

void ModifyDefault (Usuario_adminEN usuario_admin);

System.Collections.Generic.IList<Usuario_adminEN> ReadAllDefault (int first, int size);



string Nuevo (Usuario_adminEN usuario_admin);

void Modificar (Usuario_adminEN usuario_admin);


void Eliminar (string email
               );
}
}
