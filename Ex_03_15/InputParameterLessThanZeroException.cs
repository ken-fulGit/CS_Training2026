namespace Ex_03_15;

public class InputParameterLessThanZeroException : Exception
{
    public InputParameterLessThanZeroException(int param) : base($"引数に{param}が入りました")
    {

    }
}