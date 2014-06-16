namespace TempConverter.Model.Domain
{
    public struct Scale<T> where T: struct
    {
        public T Minimum { get; private set; }

        public T Maximum { get; private set; }

        public int ScaleBy { get; private set; }

  
        public Scale(T minimum, T maximum, int scaleBy)
            :this()
        {
            Minimum = minimum;
            Maximum = maximum;
            ScaleBy = scaleBy;
        }

        public override string ToString()
        {
            return string.Format("[{0}] Minimum: {1} Maximum: {2} ScaleBy: {3}",
                GetType().Name, Minimum, Maximum, ScaleBy);
        }
    }
}
