namespace TimeXt
{
    public static class NumberExtensions
    {
        public static Interval Weeks(this double value)
        {
            return new Interval(value, UnitCollection.Week);
        }

        public static Interval Weeks(this int value)
        {
            return new Interval(value, UnitCollection.Week);
        }

        public static Interval Weeks(this uint value)
        {
            return new Interval(value, UnitCollection.Week);
        }

        public static Interval Weeks(this decimal value)
        {
            return new Interval((double)value, UnitCollection.Week);
        }

        public static Interval Weeks(this float value)
        {
            return new Interval(value, UnitCollection.Week);
        }

        public static Interval Days(this double value)
        {
            return new Interval(value, UnitCollection.Day);
        }

        public static Interval Days(this int value)
        {
            return new Interval(value, UnitCollection.Day);
        }

        public static Interval Days(this uint value)
        {
            return new Interval(value, UnitCollection.Day);
        }

        public static Interval Days(this decimal value)
        {
            return new Interval((double)value, UnitCollection.Day);
        }

        public static Interval Days(this float value)
        {
            return new Interval(value, UnitCollection.Day);
        }

        public static Interval Hours(this double value)
        {
            return new Interval(value, UnitCollection.Hour);
        }

        public static Interval Hours(this int value)
        {
            return new Interval(value, UnitCollection.Hour);
        }

        public static Interval Hours(this uint value)
        {
            return new Interval(value, UnitCollection.Hour);
        }

        public static Interval Hours(this decimal value)
        {
            return new Interval((double)value, UnitCollection.Hour);
        }

        public static Interval Hours(this float value)
        {
            return new Interval(value, UnitCollection.Hour);
        }

        public static Interval Minutes(this double value)
        {
            return new Interval(value, UnitCollection.Minute);
        }

        public static Interval Minutes(this int value)
        {
            return new Interval(value, UnitCollection.Minute);
        }

        public static Interval Minutes(this uint value)
        {
            return new Interval(value, UnitCollection.Minute);
        }

        public static Interval Minutes(this decimal value)
        {
            return new Interval((double)value, UnitCollection.Minute);
        }

        public static Interval Minutes(this float value)
        {
            return new Interval(value, UnitCollection.Minute);
        }

        public static Interval Seconds(this double value)
        {
            return new Interval(value, UnitCollection.Second);
        }

        public static Interval Seconds(this int value)
        {
            return new Interval(value, UnitCollection.Second);
        }

        public static Interval Seconds(this uint value)
        {
            return new Interval(value, UnitCollection.Second);
        }

        public static Interval Seconds(this decimal value)
        {
            return new Interval((double)value, UnitCollection.Second);
        }

        public static Interval Seconds(this float value)
        {
            return new Interval(value, UnitCollection.Second);
        }

        public static Interval MilliSeconds(this double value)
        {
            return new Interval(value, UnitCollection.MilliSecond);
        }

        public static Interval MilliSeconds(this int value)
        {
            return new Interval(value, UnitCollection.MilliSecond);
        }

        public static Interval MilliSeconds(this uint value)
        {
            return new Interval(value, UnitCollection.MilliSecond);
        }

        public static Interval MilliSeconds(this decimal value)
        {
            return new Interval((double)value, UnitCollection.MilliSecond);
        }

        public static Interval MilliSeconds(this float value)
        {
            return new Interval(value, UnitCollection.MilliSecond);
        }

        public static Interval MicroSeconds(this double value)
        {
            return new Interval(value, UnitCollection.MicroSecond);
        }

        public static Interval MicroSeconds(this int value)
        {
            return new Interval(value, UnitCollection.MicroSecond);
        }

        public static Interval MicroSeconds(this uint value)
        {
            return new Interval(value, UnitCollection.MicroSecond);
        }

        public static Interval MicroSeconds(this decimal value)
        {
            return new Interval((double)value, UnitCollection.MicroSecond);
        }

        public static Interval MicroSeconds(this float value)
        {
            return new Interval(value, UnitCollection.MicroSecond);
        }

        public static Interval NanoSeconds(this double value)
        {
            return new Interval(value, UnitCollection.NanoSecond);
        }

        public static Interval NanoSeconds(this int value)
        {
            return new Interval(value, UnitCollection.NanoSecond);
        }

        public static Interval NanoSeconds(this uint value)
        {
            return new Interval(value, UnitCollection.NanoSecond);
        }

        public static Interval NanoSeconds(this decimal value)
        {
            return new Interval((double)value, UnitCollection.NanoSecond);
        }

        public static Interval NanoSeconds(this float value)
        {
            return new Interval(value, UnitCollection.NanoSecond);
        }

        public static Interval PicoSeconds(this double value)
        {
            return new Interval(value, UnitCollection.PicoSecond);
        }

        public static Interval PicoSeconds(this int value)
        {
            return new Interval(value, UnitCollection.PicoSecond);
        }

        public static Interval PicoSeconds(this uint value)
        {
            return new Interval(value, UnitCollection.PicoSecond);
        }

        public static Interval PicoSeconds(this decimal value)
        {
            return new Interval((double)value, UnitCollection.PicoSecond);
        }

        public static Interval PicoSeconds(this float value)
        {
            return new Interval(value, UnitCollection.PicoSecond);
        }
    }
}
