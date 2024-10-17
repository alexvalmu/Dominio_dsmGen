

using System;
using System.Text;
using System.Collections.Generic;

using Dominio_dsmGen.ApplicationCore.Exceptions;

using Dominio_dsmGen.ApplicationCore.EN.Dominio_dsm;
using Dominio_dsmGen.ApplicationCore.IRepository.Dominio_dsm;


namespace Dominio_dsmGen.ApplicationCore.CEN.Dominio_dsm
{
/*
 *      Definition of the class Usuario_adminCEN
 *
 */
public partial class Usuario_adminCEN
{
private IUsuario_adminRepository _IUsuario_adminRepository;

public Usuario_adminCEN(IUsuario_adminRepository _IUsuario_adminRepository)
{
        this._IUsuario_adminRepository = _IUsuario_adminRepository;
}

public IUsuario_adminRepository get_IUsuario_adminRepository ()
{
        return this._IUsuario_adminRepository;
}

public string Nuevo (string p_email, string p_nombre, Nullable<DateTime> p_fechaNac, String p_pass, int p_numSocio)
{
        Usuario_adminEN usuario_adminEN = null;
        string oid;

        //Initialized Usuario_adminEN
        usuario_adminEN = new Usuario_adminEN ();
        usuario_adminEN.Email = p_email;

        usuario_adminEN.Nombre = p_nombre;

        usuario_adminEN.FechaNac = p_fechaNac;

        usuario_adminEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);

        usuario_adminEN.NumSocio = p_numSocio;



        oid = _IUsuario_adminRepository.Nuevo (usuario_adminEN);
        return oid;
}

public void Modificar (string p_Usuario_admin_OID, string p_nombre, Nullable<DateTime> p_fechaNac, String p_pass, int p_numSocio)
{
        Usuario_adminEN usuario_adminEN = null;

        //Initialized Usuario_adminEN
        usuario_adminEN = new Usuario_adminEN ();
        usuario_adminEN.Email = p_Usuario_admin_OID;
        usuario_adminEN.Nombre = p_nombre;
        usuario_adminEN.FechaNac = p_fechaNac;
        usuario_adminEN.Pass = Utils.Util.GetEncondeMD5 (p_pass);
        usuario_adminEN.NumSocio = p_numSocio;
        //Call to Usuario_adminRepository

        _IUsuario_adminRepository.Modificar (usuario_adminEN);
}

public void Eliminar (string email
                      )
{
        _IUsuario_adminRepository.Eliminar (email);
}
}
}
