using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cute.Core;

namespace Cute.Http
{
	public class HttpManager : IUpdatable
	{
		private static HttpManager instance;

		private const float timeOut = 15f;

		private Queue<IHttpTask> taskQueue;

		private IWebRequest currentOperation;

		private float timeOutTime;

		private ResponseCache responseCache;

		private bool deserializing;

		private bool sendNextTask;

		private Dictionary<string, string> defaultHeader;

		public static HttpManager Instance => null;

		public string ServerUrl
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

		public ErrorType DebugErrorType
		{
			private get
			{
				return default(ErrorType);
			}
			set
			{
			}
		}

		public int DebugErrorCode
		{
			private get
			{
				return default(int);
			}
			set
			{
			}
		}

		public Dictionary<string, string> DefaultHeader => null;

		public Func<byte[], byte[]> EncryptFunc
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

		public Func<byte[], byte[]> DecryptFunc
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

		public RequestType RequestType
		{
			[CompilerGenerated]
			get
			{
				return default(RequestType);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public Func<string, Dictionary<string, string>, int> GetWWWErrorCodeFunc
		{
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public bool IsConnecting => default(bool);

		private HttpManager()
		{
		}

		public IWebRequest CreateRequest()
		{
			return null;
		}

		public Type GetCurrentTaskType()
		{
			return null;
		}

		public void ResetHeaders(Func<Type, bool> conditionFunc, string key, string value)
		{
		}

		public void EnqueueHttpTask(IHttpTask task)
		{
		}

		public void InterruptAuthTask(IHttpTask authTask)
		{
		}

		public void Retry()
		{
		}

		private void RetryLater()
		{
		}

		private void RetryImmediate()
		{
		}

		public void ClearAllTask()
		{
		}

		public void DisposeCurrentTaskError()
		{
		}

		public void ClearAllCache()
		{
		}

		public void ClearCache<T>() where T : IHttpTask
		{
		}

		void IUpdatable.FastUpdate()
		{
		}

		private void DisposeCurrentOperation()
		{
		}

		private void SendTask()
		{
		}
	}
}
