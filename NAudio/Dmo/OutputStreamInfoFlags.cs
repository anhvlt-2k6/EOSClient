﻿using System;

namespace NAudio.Dmo
{
    [Flags]
    internal enum OutputStreamInfoFlags
    {
        DMO_OUTPUT_STREAMF_WHOLE_SAMPLES = 1,
        DMO_OUTPUT_STREAMF_SINGLE_SAMPLE_PER_BUFFER = 2,
        DMO_OUTPUT_STREAMF_FIXED_SAMPLE_SIZE = 4,
        DMO_OUTPUT_STREAMF_DISCARDABLE = 8,
        DMO_OUTPUT_STREAMF_OPTIONAL = 16
    }
}
