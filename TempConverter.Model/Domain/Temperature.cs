namespace TempConverter.Model.Domain
{
    public struct Temperature<T> where T : struct
    {
        public T Fahrenheit { get; private set; }

        public T Celsius { get; private set; }

        public T Kelvin { get; private set; }
        

        public Temperature(T fahrenheit, T celsius, T kelvin)
            :this()
        {
            Fahrenheit = fahrenheit;
            Celsius = celsius;
            Kelvin = kelvin;
        }
        
        public override string ToString()
        {
            return string.Format("[{0}] Fahrenheit: {1} Celsius: {2} Kelvin: {3}",
                GetType().Name, Fahrenheit, Celsius, Kelvin);
        }
    }
}
