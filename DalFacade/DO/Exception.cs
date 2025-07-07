

namespace DO;

[Serializable]
public class DalIdNotExistException : Exception
{
    public DalIdNotExistException(string message): base(message) { }
    public DalIdNotExistException(string message, Exception innerException) : base(message, innerException) { }

}
[Serializable]
public class DalCodeExistException : Exception
{
    public DalCodeExistException(string message) : base(message) { }
    public DalCodeExistException(string message, Exception innerException) : base(message, innerException) { }

}