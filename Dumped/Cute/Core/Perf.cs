using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Cute.Core
{
	public class Perf
	{
		public class Memory
		{
			public class Mono : Memory
			{
				private static Mono instance;

				public static Mono Instance => null;

				private Mono()
				{
				}

				protected override long GetCurrentBytes()
				{
					return default(long);
				}
			}

			public class Unity : Memory
			{
				private static Unity instance;

				public static Unity Instance => null;

				private Unity()
				{
				}

				protected override long GetCurrentBytes()
				{
					return default(long);
				}
			}

			private class Record
			{
				public string name;

				public long startBytes;

				public int count;

				public long totalBytes;

				public long maxBytes;

				public long minBytes;

				public Record(string name)
				{
				}

				public void Reset()
				{
				}

				public double CalcAvgKB()
				{
					return default(double);
				}
			}

			private class CheckpointMemoryRecord : RemoteLogger.TimestampedRecord
			{
				public Record Record
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public CheckpointMemoryRecord(Record record, string type)
				{
				}

				public override void Serialize(StringBuilder builder)
				{
				}
			}

			protected string type;

			private Dictionary<string, Record> dictionary;

			private Dictionary<string, List<string>> subnameCoarceDictionary;

			private Memory()
			{
			}

			protected virtual long GetCurrentBytes()
			{
				return default(long);
			}

			public void LapStart(string name, [Optional] string subname)
			{
			}

			public void LapEnd(string name, bool flush = false, [Optional] string subname)
			{
			}

			public void Flush(string name)
			{
			}
		}

		public class Counter
		{
			private class Record
			{
				public string name;

				public int count;

				public long totalCnt;

				public long maxCnt;

				public long minCnt;

				public Record(string name)
				{
				}

				public void Reset()
				{
				}

				public double CalcAvgCount()
				{
					return default(double);
				}
			}

			private class CheckpointCounterRecord : RemoteLogger.TimestampedRecord
			{
				public Record Record
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public CheckpointCounterRecord(Record record)
				{
				}

				public override void Serialize(StringBuilder builder)
				{
				}
			}

			private static Counter instance;

			private Dictionary<string, Record> dictionary;

			public static Counter Instance => null;

			private Counter()
			{
			}

			public void CountUp(string name, long count, bool flush = false)
			{
			}

			public void Flush(string name)
			{
			}
		}

		public class FPSMeasure
		{
			private class Record
			{
				public string name;

				public int count;

				public float totalFps;

				public float maxFps;

				public float minFps;

				public Record(string name)
				{
				}

				public void Reset()
				{
				}

				public double CalcAvgCount()
				{
					return default(double);
				}
			}

			private class CheckFPSRecord : RemoteLogger.TimestampedRecord
			{
				public Record Record
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public CheckFPSRecord(Record record)
				{
				}

				public override void Serialize(StringBuilder builder)
				{
				}
			}

			private static FPSMeasure instance;

			private Dictionary<string, Record> dictionary;

			public static FPSMeasure Instance => null;

			private FPSMeasure()
			{
			}

			public void Mesure(string name, float fps, bool flush = false)
			{
			}

			public void Flush(string name)
			{
			}
		}

		public class Time
		{
			private class Record
			{
				public string name;

				public long startTick;

				public int count;

				public long totalTick;

				public long maxTick;

				public long minTick;

				public Record(string name)
				{
				}

				public void Reset()
				{
				}

				public double CalcAvgMSec()
				{
					return default(double);
				}
			}

			private class CheckpointTimeRecord : RemoteLogger.TimestampedRecord
			{
				public Record Record
				{
					[CompilerGenerated]
					get
					{
						return null;
					}
					[CompilerGenerated]
					private set
					{
					}
				}

				public CheckpointTimeRecord(Record record)
				{
				}

				public override void Serialize(StringBuilder builder)
				{
				}
			}

			private static Time instance;

			private Stopwatch sw;

			private Dictionary<string, Record> dictionary;

			private Dictionary<string, List<string>> subnameCoarceDictionary;

			public static Time Instance => null;

			private Time()
			{
			}

			public void LapStart(string name, [Optional] string subname)
			{
			}

			public void LapEnd(string name, bool flush = false, [Optional] string subname)
			{
			}

			public void Flush(string name)
			{
			}

			public void Cancel(string name)
			{
			}
		}

		public class LapScope : IDisposable
		{
			private string name;

			private bool flush;

			public LapScope(string name, bool flush = true)
			{
			}

			public void Dispose()
			{
			}
		}

		public static LapScope TimeBlock(string name, bool flush = true)
		{
			return null;
		}

		public static void TimeStart(string name, [Optional] string subname)
		{
		}

		public static void TimeEnd(string name, bool flush = true, [Optional] string subname)
		{
		}

		public static void TimeFlush(string name)
		{
		}

		public static void TimeCancel(string name)
		{
		}

		public static void MonoMemStart(string name, [Optional] string subname)
		{
		}

		public static void MonoMemEnd(string name, bool flush = true, [Optional] string subname)
		{
		}

		public static void MonoMemFlush(string name)
		{
		}

		public static void UnityMemStart(string name, [Optional] string subname)
		{
		}

		public static void UnityMemEnd(string name, bool flush = true, [Optional] string subname)
		{
		}

		public static void UnityMemFlush(string name)
		{
		}

		public static void CountUp(string name, long count, bool flush = true)
		{
		}

		public static void CountFlush(string name)
		{
		}

		public static void MeasureFPS(string name, float fps, bool flush = true)
		{
		}
	}
}
