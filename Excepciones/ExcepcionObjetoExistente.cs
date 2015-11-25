using System;

namespace capaExcepciones
{
    public class ExcepcionObjetoExistente : ApplicationException
    {
        public ExcepcionObjetoExistente(String pMensaje) : base(pMensaje) { }
    }
}