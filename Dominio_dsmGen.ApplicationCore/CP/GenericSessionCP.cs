

using System;
using System.Collections.Generic;
using System.Text;
using Dominio_dsmGen.ApplicationCore.IRepository;
using Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm;

namespace Dominio_dsmGen.ApplicationCore.CP.Dominio_dsm
{
public abstract class GenericSessionCP
{
bool insideTransaction = true;

public GenericSessionCP (object currentSession)
{
        this.CurrentSession = currentSession;
}

public GenericSessionCP()
{
}

public GenericUnitOfWorkRepository UnitRepo     {
        get; set;
}

public object CurrentSession {
        set; get;
}

public bool InsideTransaction
{
        get { return insideTransaction; }
        set { this.insideTransaction = value; }
}
public abstract void SessionInitializeTransaction ();

public abstract void SessionInitializeWithoutTransaction ();

public abstract void Commit ();

public abstract void RollBack ();

public abstract void SessionClose ();
}
}

