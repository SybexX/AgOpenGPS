﻿using System.Diagnostics;

namespace AgOpenGPS.Core.ApplicationModels
{
    public class DebugAsserts
    {
        public static void AreEqual(double a, double b, double epsilon = 0.0001)
        {
            Debug.Assert(b < a + epsilon);
            Debug.Assert(a < b + epsilon);
        }

        public static void AssertEqual(bool a, bool b)
        {
            Debug.Assert(a == b);
        }

        public static void AreEqual(GeoCoord a, GeoCoord b)
        {
            AreEqual(a.Northing, b.Northing);
            AreEqual(a.Easting, b.Easting);
        }

        public static void AreEqual(GeoDir a, GeoDir b)
        {
            AreEqual(a.Cos, b.Cos);
            AreEqual(a.Sin, b.Sin);
        }

        public static void AreEqual(GeoPath a, GeoPath b)
        {
            DebugAsserts.AreEqual(a.Count, b.Count);
            for (int i = 0; i < a.Count; i++)
            {
                DebugAsserts.AreEqual(a[i], b[i]);
            }
        }

        public static void AreEqual(GeoPolygon a, GeoPolygon b)
        {
            DebugAsserts.AreEqual(a.Count, b.Count);
            for (int i = 0; i < a.Count; i++)
            {
                DebugAsserts.AreEqual(a[i], b[i]);
            }
        }
    }
}
