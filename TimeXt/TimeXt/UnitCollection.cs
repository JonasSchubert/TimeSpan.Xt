using System.Collections.Generic;

namespace TimeXt
{
    public class UnitCollection
    {
        public static Unit Week = new Unit(7 * 24 * 60 * 60);
        public static Unit Day = new Unit(24 * 60 * 60);
        public static Unit Hour = new Unit(60 * 60);
        public static Unit Minute = new Unit(60);
        public static Unit Second = new Unit(1);
        public static Unit MilliSecond = new Unit(1e-3);
        public static Unit MicroSecond = new Unit(1e-6);
        public static Unit NanoSecond = new Unit(1e-9);
        public static Unit PicoSecond = new Unit(1e-12);

        public static IList<Unit> Values = new List<Unit>() {
            Week,
            Day,
            Hour,
            Minute,
            Second,
            MilliSecond,
            MicroSecond,
            NanoSecond,
            PicoSecond
        };
    }
}
