namespace DesafioProjetoHospedagem.Exceptions
{
    public class NegocioException : Exception
    {
        public NegocioException() { }

        public NegocioException(string message) : base(message) { }

        public NegocioException(string message, Exception innerException) : base(message, innerException) { }
    }
}
