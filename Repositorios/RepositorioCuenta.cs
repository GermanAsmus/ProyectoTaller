using System;
using System.Collections.Generic;

namespace capaRepo
{
    /// <summary>
    /// Repositorio de cuentas.
    /// Subclase de la clase abstracta Repositorio.
    /// </summary>
    public class RepositorioCuenta : Repositorio<CuentaDTO>
    {
        
	/// <summary>
        /// Constructor del repositorio
        /// </summary>
        public RepositorioCuenta() : base() { }
        
	/// <summary>
        /// Metodo que delega a la clase padre la responsabilidad de agregar una cuenta.
        /// </summary>
        /// <param name="pCuenta">Objeto CuentaDTO</param>
        public override void Agregar(CuentaDTO pCuenta) { base.AgregarOActualizar(pCuenta); }
        
	/// <summary>
	/// Metodo que delega a la clase padre la responsabilidad de borrar una cuenta.
        /// </summary>
        /// <param name="pCuenta">Objeto CuentaDTO</param>
        public override void Borrar(CuentaDTO pCuenta) { base.Borrar(pCuenta); }
        
	/// <summary>
	/// Metodo que delega a la clase padre la responsabilidad de obtener una cuenta.
        /// </summary>
        /// <param name="pCuenta">Objeto CuentaDTO</param>
        /// <returns>Objeto CuentaDTO</returns>
        public override CuentaDTO Obtener(CuentaDTO pCuenta) { return base.Obtener(pCuenta); }
        
	/// <summary>
        /// Metodo que delega a la clase padre la responsabilidad de obtener una cuenta mediante un metodo de ordenamiento.
        /// </summary>
        /// <param name="pComparador">Tipo de comparador</param>
        /// <returns>Una lista ordenada de objetos CuentaDTO</returns>
        public override IList<CuentaDTO> ObtenerOrdenados(IComparer<CuentaDTO> pComparador) { return base.ObtenerOrdenados(pComparador); }
        
	/// <summary>
        /// Metodo que delega a la clase padre la responsabilidad de comparar cuentas.
        /// </summary>
        /// <param name="x">Pirmera CuentaDTO a comparar</param>
        /// <param name="y">Segunda CuentaDTO a comparar</param>
        /// <returns>Un entero respectivo al resultado de la comparación</returns>
        public override int Compare(CuentaDTO x, CuentaDTO y) { return base.Compare(x, y); }
    }