using System.Numerics;

/// <summary>
/// 演算を行うクラス
/// </summary>
/// <typeparam name="T">演算対象の型。加算可能な型限定</typeparam>
public class Calculator<T>
{
    T Value1 { get; set; }
    T Value2 { get; set; }

    public Calculator(T value1, T value2)
    {
        Value1 = value1;
        Value2 = value2;
    }

    public string Add()
    {
        return string.Concat(Value1, Value2);
    }


}