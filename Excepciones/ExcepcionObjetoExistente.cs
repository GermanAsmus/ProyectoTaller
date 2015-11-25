using System;
//Esta excepcion se lanza cuando un objeto ya existe.
namespace capaExcepciones
{
    public class ExcepcionObjetoExistente : ApplicationException
    {
        public ExcepcionObjetoExistente(String pMensaje) : base(pMensaje) { }
    }
}
