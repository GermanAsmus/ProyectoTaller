using System;
using System.Collections.Generic;

namespace capaRepo
{
    /// <summary>
    /// Repositorio de Mensajes.
    /// Subclase de la clase abstracta Repositorio.
    /// </summary>
    public class RepositorioMensaje : Repositorio<MensajeDTO>
    {
        
	/// <summary>
        /// Constructor del repositorio
        /// </summary>
        public RepositorioMensaje() : base() { }
        
	/// <summary>
        /// Metodo que delega a la clase padre la responsabilidad de agregar un Mensaje.
        /// </summary>
        /// <param name="pMensaje">Objeto MensajeDTO</param>
        public override void Agregar(MensajeDTO pMensaje) { base.AgregarOActualizar(pMensaje); }
        
	/// <summary>
	/// Metodo que delega a la clase padre la responsabilidad de borrar un Mensaje.
        /// </summary>
        /// <param name="pMensaje">Objeto MensajeDTO</param>
        public override void Borrar(MensajeDTO pMensaje) { base.Borrar(pMensaje); }
        
	/// <summary>
	/// Metodo que delega a la clase padre la responsabilidad de obtener un Mensaje.
        /// </summary>
        /// <param name="pMensaje">Objeto MensajeDTO</param>
        /// <returns>Objeto MensajeDTO</returns>
        public override MensajeDTO Obtener(MensajeDTO pMensaje) { return base.Obtener(pMensaje); }
        
	/// <summary>
        /// Metodo que delega a la clase padre la responsabilidad de obtener un Mensaje mediante un metodo de ordenamiento.
        /// </summary>
        /// <param name="pComparador">Tipo de comparador</param>
        /// <returns>Una lista ordenada de objetos MensajeDTO</returns>
        public override IList<MensajeDTO> ObtenerOrdenados(IComparer<MensajeDTO> pComparador) { return base.ObtenerOrdenados(pComparador); }
        
	/// <summary>
        /// Metodo que delega a la clase padre la responsabilidad de comparar Mensajes.
        /// </summary>
        /// <param name="x">Pirmer MensajeDTO a comparar</param>
        /// <param name="y">Segundo MensajeDTO a comparar</param>
        /// <returns>Un entero respectivo al resultado de la comparación</returns>
        public override int Compare(MensajeDTO x, MensajeDTO y) { return base.Compare(x, y); }
    }