using System;
using System.Collections.Generic;

namespace capaRepo
{
    /// <summary>
    /// Interfaz generica de un repositorio. 
    /// Cada clase que implemente esta interfaz 
    /// deberá cambiar el parámetro T por el tipo de la clase
    /// </summary>
    /// <typeparam name="T">Tipo generico</typeparam>
    public interface IRepositorio<T> : IComparer<T>
    {
        /// <summary>
        /// Define el mensaje Agregar
        /// </summary>
        /// <param name="pObjeto">Parametro del tipo T (generico)</param>
        void Agregar(T pObjeto);
        /// <summary>
        /// Define el mensaje Borrar
        /// </summary>
        /// <param name="pObjeto">Parametro del tipo T (generico)</param>
        void Borrar(T pObjeto);
        /// <summary>
        /// Define el mensaje Obtener
        /// </summary>
        /// <param name="pObjeto">Parametro del tipo T (generico)</param>
        T Obtener(T pObjeto);
        /// <summary>
        /// Define el mensaje ObtenerOrdenados, 
        /// hace uso de la interfaz IComparer<T> para definir el tipo de ordenamiento
        /// </summary>
        /// <param name="pComparador">Tipo de ordenamiento del tipo IComparer<T> </param>
        /// <returns>Lista de elementos ordenados</returns>
        IList<T> ObtenerOrdenados(IComparer<T> pComparador);
    }
}