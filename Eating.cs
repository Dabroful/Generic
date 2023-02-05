namespace Generic
{
    public class Eating<T>
        //задали ограничение что кушать можно быть только Product или его наследника
    where T: Product<int>
    {
        public int Volume { get; private set; }
        public void Add(T product)
        {
            Volume += product.Volume * product.Energy;
        }
    }
}