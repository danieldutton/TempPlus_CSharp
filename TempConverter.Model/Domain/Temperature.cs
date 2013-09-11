namespace TempConverter.Model.Domain
{
    public struct Temperature<T> where T : struct
    {
        public T Fahrenheit { get; set; }
        
        public T Kelvin { get; set; }
        
        public T Celsius { get; set; }


        public Temperature(T fahrenheit, T celsius, T kelvin)
            :this()
        {
            Fahrenheit = fahrenheit;
            Celsius = celsius;
            Kelvin = kelvin;
        }
        
        public override string ToString()
        {
            return "[" + GetType().Name + "]" +
                   string.Format("Fahrenheit:{0} Celsius:{1} Kelvin:{2}", Fahrenheit, Celsius, Kelvin);
        }
    }
}
