
using System;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm;

namespace Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm
{
public partial interface ILineaPedidoRepository
{
void setSessionCP (GenericSessionCP session);

LineaPedidoEN ReadOIDDefault (int num
                              );

void ModifyDefault (LineaPedidoEN lineaPedido);

System.Collections.Generic.IList<LineaPedidoEN> ReadAllDefault (int first, int size);



int Nuevo (LineaPedidoEN lineaPedido);

void Modificar (LineaPedidoEN lineaPedido);


void Eliminar (int num
               );


System.Collections.Generic.IList<LineaPedidoEN> DameALL (int first, int size);
}
}
