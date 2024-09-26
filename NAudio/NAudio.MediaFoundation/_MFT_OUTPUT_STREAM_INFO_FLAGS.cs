using System;

namespace NAudio.MediaFoundation;

[Flags]
public enum _MFT_OUTPUT_STREAM_INFO_FLAGS
{
	None = 0,
	MFT_OUTPUT_STREAM_WHOLE_SAMPLES = 1,
	MFT_OUTPUT_STREAM_SINGLE_SAMPLE_PER_BUFFER = 2,
	MFT_OUTPUT_STREAM_FIXED_SAMPLE_SIZE = 4,
	MFT_OUTPUT_STREAM_DISCARDABLE = 8,
	MFT_OUTPUT_STREAM_OPTIONAL = 0x10,
	MFT_OUTPUT_STREAM_PROVIDES_SAMPLES = 0x100,
	MFT_OUTPUT_STREAM_CAN_PROVIDE_SAMPLES = 0x200,
	MFT_OUTPUT_STREAM_LAZY_READ = 0x400,
	MFT_OUTPUT_STREAM_REMOVABLE = 0x800
}
