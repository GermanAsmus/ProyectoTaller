using System;

namespace capaExcepciones
{
    public class ExcepcionObjetoInexistente : ApplicationException
    {
        public ExcepcionObjetoInexistente(String pMensaje) : base(pMensaje) { }
    }
}