using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Agregar referencias a Excepciones y Misc

namespace capaRepo
{
    /// <summary>
    /// Clase abstracta que implementa la interfaz generica IRepositorio.
    /// Esta clase tambien utiliza el tipo generico.
    /// </summary>
    /// <typeparam name="T">Tipo generico</typeparam>
    public abstract class Repositorio<T> : IRepositorio<T>  
    {
        //Lista que contendrá el elemento de tipo T.
        public IList<T> iRepositorio;

        /// <summary>
        /// Constructor de la clase
        /// Se inicializa la lista del repositorio
        /// </summary>
        public Repositorio()
        {
            this.iRepositorio = new List<T>();
        }
        /// <summary>
        /// Definición del metodo virtual Agregar
        /// Agrega al repositorio un objeto de tipo T
        /// </summary>
        /// <param name="pObjeto">Objeto de tipo generico</param>
        public virtual void Agregar(T pObjeto)
        {
            T auxT= CopiadorDeObjetos.Clone<T>(pObjeto);
            this.iRepositorio.Add(auxT);
        }
        /// <summary>
        /// Definicion del metodo virtual Borrar.
	/// Antes de borrar el objeto se lo busca para verificar su existencia.
        /// </summary>
        /// <param name="pObjeto">Objeto de tipo generico</param>
        public virtual void Borrar(T pObjeto)
        {
	this.iRepositorio.Remove(this.Obtener(pObjeto));
        }
        /// <summary>
        /// Definición del metodo Obtener del tipo generico,
        /// Mediante Linq se obtiene aquel objeto que coincida con pObjeto.
        /// </summary>
        /// <param name="pObjeto">Objeto del tipo generico</param>
        /// <returns>Un Objeto del tipo T</returns>
        public virtual T Obtener(T pObjeto)
        {
            try
            {
		return this.iRepositorio.Single(x => this.Compare(x, pObjeto) == 0);
	    }
            catch (InvalidOperationException)
            {
                throw new ExcepcionObjetoInexistente("No hay niguna instancia referente a dicho objeto");
            }
            catch (ArgumentNullException)
            {
                throw new ApplicationException("argumento de ordenamiento invalido");
            }
        }
        /// <summary>
        /// Obtiene una lista de objetos ordenados.
        /// Se ordena mediante Linq y un tipo de ordenamiento del tipo IComparer.
        /// </summary>
        /// <param name="pComparador">Tipo de ordenamiento</param>
        /// <returns>Una lista del tipo generico</returns>
        public virtual IList<T> ObtenerOrdenados(IComparer<T> pComparador)
        {
            try
            {
                return this.iRepositorio.OrderBy(x => pComparador).ToList<T>();
            }
            catch (ArgumentNullException)
            {
                throw new ApplicationException("argumento de ordenamiento invalido");
            }
        }
        /// <summary>
        /// Compara dos objetos del tipo generico
        /// </summary>
        /// <param name="x">Primer objeto del tipo T</param>
        /// <param name="y">Segundo objeto del tipo T</param>
        /// <returns>Un entero que representa el resultado de la comparacion</returns>
        public virtual int Compare(T x, T y)
        {
            int resultado = 0;
            if (x.GetHashCode() > y.GetHashCode()) { resultado = 1; }
            else if (x.GetHashCode() < y.GetHashCode()) { resultado = -1; }
            return resultado;
        }
    }
}
