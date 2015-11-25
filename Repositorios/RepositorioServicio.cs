using System;
using System.Collections.Generic;

namespace capaRepo
{
    /// <summary>
    /// Repositorio de Servicios.
    /// Subclase de la clase abstracta Repositorio.
    /// </summary>
    public class RepositorioServicio : Repositorio<ServicioDTO>
    {
        
	/// <summary>
        /// Constructor del repositorio
        /// </summary>
        public RepositorioServicio() : base() { }
        
	/// <summary>
        /// Metodo que delega a la clase padre la responsabilidad de agregar un Servicio.
        /// </summary>
        /// <param name="pServicio">Objeto ServicioDTO</param>
        public override void Agregar(ServicioDTO pServicio) { base.AgregarOActualizar(pServicio); }
        
	/// <summary>
	/// Metodo que delega a la clase padre la responsabilidad de borrar un Servicio.
        /// </summary>
        /// <param name="pServicio">Objeto ServicioDTO</param>
        public override void Borrar(ServicioDTO pServicio) { base.Borrar(pServicio); }
        
	/// <summary>
	/// Metodo que delega a la clase padre la responsabilidad de obtener un Servicio.
        /// </summary>
        /// <param name="pServicio">Objeto ServicioDTO</param>
        /// <returns>Objeto ServicioDTO</returns>
        public override ServicioDTO Obtener(ServicioDTO pServicio) { return base.Obtener(pServicio); }
        
	/// <summary>
        /// Metodo que delega a la clase padre la responsabilidad de obtener un Servicio mediante un metodo de ordenamiento.
        /// </summary>
        /// <param name="pComparador">Tipo de comparador</param>
        /// <returns>Una lista ordenada de objetos ServicioDTO</returns>
        public override IList<ServicioDTO> ObtenerOrdenados(IComparer<ServicioDTO> pComparador) { return base.ObtenerOrdenados(pComparador); }
        
	/// <summary>
        /// Metodo que delega a la clase padre la responsabilidad de comparar Servicios.
        /// </summary>
        /// <param name="x">Pirmer ServicioDTO a comparar</param>
        /// <param name="y">Seguno ServicioDTO a comparar</param>
        /// <returns>Un entero respectivo al resultado de la comparación</returns>
        public override int Compare(ServicioDTO x, ServicioDTO y) { return base.Compare(x, y); }
    }