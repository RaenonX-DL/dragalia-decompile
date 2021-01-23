/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Core
{
	public class RemoteLogger : MonoBehaviour
	{
		// Fields
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
		[CompilerGenerated]
		private string _SessionId_k__BackingField;
		[CompilerGenerated]
		private string _LogName_k__BackingField;
	
		// Properties
		public bool IsEnabled { get; }
		public string PostUrl { get; set; }
		public string SessionId { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public string LogName { [CompilerGenerated] get; [CompilerGenerated] set; }
		public static RemoteLogger Instance { get; }
	
		// Nested types
		public enum Level
		{
			DEBUG = 1,
			INFO = 2,
			WARNING = 4,
			ERROR = 8,
			EXCEPTION = 16
		}
	
		public class TimestampedRecord
		{
			// Fields
			[CompilerGenerated]
			private DateTime _Now_k__BackingField;
			public string type;
	
			// Properties
			public DateTime Now { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public TimestampedRecord();
	
			// Methods
			protected void AppendString(StringBuilder builder, string member, string value);
			protected void AppendNumber(StringBuilder builder, string member, object value);
			protected void AppendComma(StringBuilder builder);
			public virtual void Serialize(StringBuilder builder);
			public void AppendTimeStamp(StringBuilder builder);
			public void StartAppendingWithTimestamp(StringBuilder builder);
		}
	
		public class StatusLogRecord : TimestampedRecord
		{
			// Fields
			[CompilerGenerated]
			private string _Log_k__BackingField;
			[CompilerGenerated]
			private string _Name_k__BackingField;
			[CompilerGenerated]
			private Level _Level_k__BackingField;
	
			// Properties
			public string Log { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public string Name { [CompilerGenerated] get; [CompilerGenerated] private set; }
			public Level Level { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
			// Constructors
			public StatusLogRecord(Level level, string log, string name);
	
			// Methods
			public override void Serialize(StringBuilder builder);
		}
	
		[CompilerGenerated]
		private sealed class __PostES_d__37 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public string json;
			public string url;
			public Action next;
			private UnityWebRequest _request_5__2;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public __PostES_d__37(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			private void __m__Finally1();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		// Constructors
		public RemoteLogger();
		static RemoteLogger();
	
		// Methods
		private void Awake();
		public void HookExceptionLog();
		private void LogCallbackHandler(string condition, string stackTrace, LogType type);
		public void Enqueue(TimestampedRecord record);
		public void Log(Level level, string msg);
		public void LogInfo(string msg);
		private string ComputeSHA1(string seed);
		private string CreateSessionId();
		public void AppendCommonHeader(string key, string value);
		public void SendAll(Action next = null);
		[IteratorStateMachine]
		private IEnumerator _PostES(string url, string json, Action next = null);
		public void SendRemoteLog(string url, string json, Action next = null);
		public void GiveUp();
		[CompilerGenerated]
		private void _LogCallbackHandler_b__29_0();
	}
}
