namespace Glitch9.Collections
{
    public interface IKeyValuePair<TKey, TValue>
    {
        TKey Key { get; set; }
        TValue Value { get; set; }
    }
}