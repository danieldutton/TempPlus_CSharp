namespace TempConverter.Model.Domain
{
    public struct Scale<T> where T: struct
    {
        public T Minimum { get; set; }

        public T Maximum { get; set; }

        public int ScaleBy { get; set; }

  
        public Scale(T minimum, T maximum, int scaleBy)
            :this()
        {
            Minimum = minimum;
            Maximum = maximum;
            ScaleBy = scaleBy;
        }

        public override string ToString()
        {
            return "[" + GetType().Name + "] " + string.Format("Minimum: {0} " + "Maximum: {1} " + "ScaleBy: {2}"
                ,Minimum, Maximum, ScaleBy);
        }
    }
}
