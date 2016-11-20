using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Backend
{
    public class ServiceASettings
    {
        public ServiceASettings(int someCount, string someString)
        {
            SomeCount = someCount;
            SomeString = someString;
        }

        public int SomeCount { get; private set; }
        public string SomeString { get; private set; }
    }
}