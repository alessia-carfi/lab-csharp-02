namespace ExtensionMethods
{
    using System;

    /// <inheritdoc cref="IComplex"/>
    public class Complex : IComplex
    {
        private readonly double _re;
        private readonly double _im;

        /// <summary>
        /// Initializes a new instance of the <see cref="Complex"/> class.
        /// </summary>
        /// <param name="re">the real part.</param>
        /// <param name="im">the imaginary part.</param>
        public Complex(double re, double im)
        {
            _re = re;
            _im = im;
        }

        /// <inheritdoc cref="IComplex.Real"/>
        public double Real { get; set; }

        /// <inheritdoc cref="IComplex.Imaginary"/>
        public double Imaginary { get; set; }

        /// <inheritdoc cref="IComplex.Modulus"/>
        public double Modulus => Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginary, 2));

        /// <inheritdoc cref="IComplex.Phase"/>
        public double Phase => Math.Atan2(Imaginary, Real);

        /// <inheritdoc cref="IComplex.ToString"/>
        public override string ToString()
        {   
            if (Real == 0 && Imaginary == 0)
                return "0.0";
            String result = Real == 0 ? "" : Real.ToString();
            if (Imaginary == 0)
                return result;
            result += Imaginary > 0 ? $"{(Real != 0 ? "+" : "")}{(Imaginary > 1 ? Imaginary : "")}i" : $"-{(Imaginary > 1 ? Imaginary : "")}i";
            return result;
        }

        /// <inheritdoc cref="IEquatable{T}.Equals(T)"/>
        public bool Equals(IComplex other)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc cref="object.Equals(object?)"/>
        public override bool Equals(object obj)
        {
            return obj is Complex complex &&
                   Real == complex.Real &&
                   Imaginary == complex.Imaginary &&
                   Modulus == complex.Modulus &&
                   Phase == complex.Phase;
        }

        /// <inheritdoc cref="object.GetHashCode"/>
        public override int GetHashCode()
        {
            // TODO improve
            return base.GetHashCode();
        }
    }
}
