/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class Perf
	{
		// Nested types
		public class Memory
		{
			// Fields
			protected string type;
			private Dictionary<string, Record> dictionary;
			private Dictionary<string, List<string>> subnameCoarceDictionary;
	
			// Nested types
			public class Mono : Memory
			{
				// Fields
				private static Mono instance;
	
				// Properties
				public static Mono Instance { get; }
	
				// Constructors
				private Mono();
				static Mono();
	
				// Methods
				protected override long GetCurrentBytes();
			}
	
			public class Unity : Memory
			{
				// Fields
				private static Unity instance;
	
				// Properties
				public static Unity Instance { get; }
	
				// Constructors
				private Unity();
				static Unity();
	
				// Methods
				protected override long GetCurrentBytes();
			}
	
			private class Record
			{
				// Fields
				public string name;
				public long startBytes;
				public int count;
				public long totalBytes;
				public long maxBytes;
				public long minBytes;
	
				// Constructors
				public Record(string name);
	
				// Methods
				public void Reset();
				public double CalcAvgKB();
			}
	
			private class CheckpointMemoryRecord : RemoteLogger.TimestampedRecord
			{
				// Fields
				[CompilerGenerated]
				private Record _Record_k__BackingField;
	
				// Properties
				public Record Record { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
				// Constructors
				public CheckpointMemoryRecord(Record record, string type);
	
				// Methods
				public override void Serialize(StringBuilder builder);
			}
	
			// Constructors
			private Memory();
	
			// Methods
			protected virtual long GetCurrentBytes();
			public void LapStart(string name, string subname = null);
			public void LapEnd(string name, bool flush = false, string subname = null);
			public void Flush(string name);
		}
	
		public class Counter
		{
			// Fields
			private static Counter instance;
			private Dictionary<string, Record> dictionary;
	
			// Properties
			public static Counter Instance { get; }
	
			// Nested types
			private class Record
			{
				// Fields
				public string name;
				public int count;
				public long totalCnt;
				public long maxCnt;
				public long minCnt;
	
				// Constructors
				public Record(string name);
	
				// Methods
				public void Reset();
				public double CalcAvgCount();
			}
	
			private class CheckpointCounterRecord : RemoteLogger.TimestampedRecord
			{
				// Fields
				[CompilerGenerated]
				private Record _Record_k__BackingField;
	
				// Properties
				public Record Record { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
				// Constructors
				public CheckpointCounterRecord(Record record);
	
				// Methods
				public override void Serialize(StringBuilder builder);
			}
	
			// Constructors
			private Counter();
			static Counter();
	
			// Methods
			public void CountUp(string name, long count, bool flush = false);
			public void Flush(string name);
		}
	
		public class FPSMeasure
		{
			// Fields
			private static FPSMeasure instance;
			private Dictionary<string, Record> dictionary;
	
			// Properties
			public static FPSMeasure Instance { get; }
	
			// Nested types
			private class Record
			{
				// Fields
				public string name;
				public int count;
				public float totalFps;
				public float maxFps;
				public float minFps;
	
				// Constructors
				public Record(string name);
	
				// Methods
				public void Reset();
				public double CalcAvgCount();
			}
	
			private class CheckFPSRecord : RemoteLogger.TimestampedRecord
			{
				// Fields
				[CompilerGenerated]
				private Record _Record_k__BackingField;
	
				// Properties
				public Record Record { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
				// Constructors
				public CheckFPSRecord(Record record);
	
				// Methods
				public override void Serialize(StringBuilder builder);
			}
	
			// Constructors
			private FPSMeasure();
			static FPSMeasure();
	
			// Methods
			public void Mesure(string name, float fps, bool flush = false);
			public void Flush(string name);
		}
	
		public class Time
		{
			// Fields
			private static Time instance;
			private Stopwatch sw;
			private Dictionary<string, Record> dictionary;
			private Dictionary<string, List<string>> subnameCoarceDictionary;
	
			// Properties
			public static Time Instance { get; }
	
			// Nested types
			private class Record
			{
				// Fields
				public string name;
				public long startTick;
				public int count;
				public long totalTick;
				public long maxTick;
				public long minTick;
	
				// Constructors
				public Record(string name);
	
				// Methods
				public void Reset();
				public double CalcAvgMSec();
			}
	
			private class CheckpointTimeRecord : RemoteLogger.TimestampedRecord
			{
				// Fields
				[CompilerGenerated]
				private Record _Record_k__BackingField;
	
				// Properties
				public Record Record { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
				// Constructors
				public CheckpointTimeRecord(Record record);
	
				// Methods
				public override void Serialize(StringBuilder builder);
			}
	
			// Constructors
			private Time();
			static Time();
	
			// Methods
			public void LapStart(string name, string subname = null);
			public void LapEnd(string name, bool flush = false, string subname = null);
			public void Flush(string name);
			public void Cancel(string name);
		}
	
		public class LapScope : IDisposable
		{
			// Fields
			private string name;
			private bool flush;
	
			// Constructors
			public LapScope(string name, bool flush = true);
	
			// Methods
			public void Dispose();
		}
	
		// Constructors
		public Perf();
	
		// Methods
		public static LapScope TimeBlock(string name, bool flush = true);
		public static void TimeStart(string name, string subname = null);
		public static void TimeEnd(string name, bool flush = true, string subname = null);
		public static void TimeFlush(string name);
		public static void TimeCancel(string name);
		public static void MonoMemStart(string name, string subname = null);
		public static void MonoMemEnd(string name, bool flush = true, string subname = null);
		public static void MonoMemFlush(string name);
		public static void UnityMemStart(string name, string subname = null);
		public static void UnityMemEnd(string name, bool flush = true, string subname = null);
		public static void UnityMemFlush(string name);
		public static void CountUp(string name, long count, bool flush = true);
		public static void CountFlush(string name);
		public static void MeasureFPS(string name, float fps, bool flush = true);
	}
}
