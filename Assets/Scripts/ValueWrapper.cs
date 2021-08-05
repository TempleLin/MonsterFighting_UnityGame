
/*
 * @Wrapper for turning value type into reference type. 
 */
public class ValueWrapper<T>
{
    public T Value { get; set; }

    public ValueWrapper(T value)
    {
        this.Value = value;
    }
}
