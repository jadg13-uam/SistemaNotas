
using SistemaNotas.Modelos;
using System;
using System.Collections.Generic;

namespace SistemaNotas.Controlador
{
    //Create, Read, Update, Delete
    public class CarreraController
    {
        private List<Carrera> carreras = new List<Carrera>();

        public Boolean Agregar(string nombre, string codigo)
        {
            try
            {
                Carrera carrera = new Carrera(codigo, nombre);
                carreras.Add(carrera);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// Obtiene todos los registros de carrera
        /// </summary>
        /// <returns></returns>
        public List<Carrera> GetCarreras()
        {
            return carreras;
        }
        /// <summary>
        /// Busca un elemento y muestra todos los registros encontrados
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        public List<Carrera> GetCarreras(string dato)
        {
            return carreras.FindAll(c => c.Nombre.Contains(dato));
        }

        public Carrera GetCarrera(string codigo, string nombre)
        {
            Carrera carrera = carreras.Find(c => c.Codigo == codigo);
            return carrera;
        }

        public Boolean Eliminar(string nombre, string codigo)
        {
            Carrera carrera = GetCarrera(codigo, nombre);
            if (carrera == null)
            {
                return false;
            }
            carreras.Remove(carrera);
            return true;
        }


    }
}
