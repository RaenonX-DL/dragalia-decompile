using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using UnityEngine;

namespace Cute.Core
{
	public class RemoteLogger : MonoBehaviour
	{
		public enum Level
		{
			DEBUG = 1,
			INFO = 2,
			WARNING = 4,
			ERROR = 8,
			EXCEPTION = 0x10
		}

		public class TimestampedRecord
		{
			public string type;

			public DateTime Now
			{
				[CompilerGenerated]
				get
				{
					return default(DateTime);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			protected void AppendString(StringBuilder builder, string member, string value)
			{
			}

			protected void AppendNumber(StringBuilder builder, string member, object value)
			{
			}

			protected void AppendComma(StringBuilder builder)
			{
			}

			public virtual void Serialize(StringBuilder builder)
			{
			}

			public void AppendTimeStamp(StringBuilder builder)
			{
			}

			public void StartAppendingWithTimestamp(StringBuilder builder)
			{
			}
		}

		public class StatusLogRecord : TimestampedRecord
		{
			public string Log
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

			public string Name
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

			public Level Level
			{
				[CompilerGenerated]
				get
				{
					return default(Level);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public StatusLogRecord(Level level, string log, string name)
			{
			}

			public override void Serialize(StringBuilder builder)
			{
			}
		}

		private const string TAG = "default";

		private const int REMOTELOG_LEVEL = 30;

		private const int MAX_LOGQUEUE_LEN = 4096;

		private string elasticSearchPostUrl;

		private static RemoteLogger instance;

		private Queue<TimestampedRecord> queuedRecords;

		private string commonJsonHeader;

		private bool giveup;

		private bool logHook;

		private bool sendingExceptionLog;

		private string prevExceptionLog;

		public bool IsEnabled => default(bool);

		public string PostUrl
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SessionId
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

		public string LogName
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public static RemoteLogger Instance => null;

		private void Awake()
		{
		}

		public void HookExceptionLog()
		{
		}

		private void LogCallbackHandler(string condition, string stackTrace, LogType type)
		{
		}

		public void Enqueue(TimestampedRecord record)
		{
		}

		public void Log(Level level, string msg)
		{
		}

		public void LogInfo(string msg)
		{
		}

		private string ComputeSHA1(string seed)
		{
			return null;
		}

		private string CreateSessionId()
		{
			return null;
		}

		public void AppendCommonHeader(string key, string value)
		{
		}

		public void SendAll([Optional] Action next)
		{
		}

		private IEnumerator _PostES(string url, string json, [Optional] Action next)
		{
			return null;
		}

		public void SendRemoteLog(string url, string json, [Optional] Action next)
		{
		}

		public void GiveUp()
		{
		}
	}
}
