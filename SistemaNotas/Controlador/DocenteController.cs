using SistemaNotas.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace SistemaNotas.Controlador
{
    public class DocenteController
    {
        private List<Docente> listado = new List<Docente>();

        public Boolean Agregar(string cif, string nombres, string apellidos, DateTime fechaNac, string titulo)
        {
            Boolean resultado = false;
            try
            {
                Docente docente = new Docente();
                docente.Cif = cif;
                docente.Nombres = nombres;
                docente.Apellidos = apellidos;
                docente.FechaNac = fechaNac;
                docente.Titulo = titulo;
                listado.Add(docente);
                resultado= true;
            }catch (Exception)
            {
                resultado =false;
            }
            return resultado;
        }

        public List<Docente> GetDocentes()
        {
            return listado;
        }
            
    }
}
