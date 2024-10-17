
using System;
using System.Text;
using System.Collections.Generic;
using Dominio_dsmGen.ApplicationCore.Exceptions;
using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.CEN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.Utils;



namespace Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm
{
public partial class PedidoCP : GenericBasicCP
{
public PedidoCP(GenericSessionCP currentSession)
        : base (currentSession)
{
}

public PedidoCP(GenericSessionCP currentSession, GenericUnitOfWorkUtils unitUtils)
        : base (currentSession, unitUtils)
{
}
}
}
