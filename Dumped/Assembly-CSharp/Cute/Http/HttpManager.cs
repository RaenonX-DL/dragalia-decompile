/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Http
{
	public class HttpManager : IUpdatable
	{
		// Fields
		private static HttpManager instance;
		private const float timeOut = 15f;
		private Queue<IHttpTask> taskQueue;
		private IWebRequest currentOperation;
		private float timeOutTime;
		private ResponseCache responseCache;
		private bool deserializing;
		private bool sendNextTask;
		[CompilerGenerated]
		private string _ServerUrl_k__BackingField;
		private Dictionary<string, string> defaultHeader;
		[CompilerGenerated]
		private Func<byte[], byte[]> _EncryptFunc_k__BackingField;
		[CompilerGenerated]
		private Func<byte[], byte[]> _DecryptFunc_k__BackingField;
		[CompilerGenerated]
		private RequestType _RequestType_k__BackingField;
		[CompilerGenerated]
		private Func<string, Dictionary<string, string>, int> _GetWWWErrorCodeFunc_k__BackingField;
	
		// Properties
		public static HttpManager Instance { get; }
		public string ServerUrl { [CompilerGenerated] get; [CompilerGenerated] set; }
		public ErrorType DebugErrorType { private get; set; }
		public int DebugErrorCode { private get; set; }
		public Dictionary<string, string> DefaultHeader { get; }
		public Func<byte[], byte[]> EncryptFunc { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Func<byte[], byte[]> DecryptFunc { [CompilerGenerated] get; [CompilerGenerated] set; }
		public RequestType RequestType { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Func<string, Dictionary<string, string>, int> GetWWWErrorCodeFunc { [CompilerGenerated] private get; [CompilerGenerated] set; }
		public bool IsConnecting { get; }
	
		// Constructors
		private HttpManager();
		static HttpManager();
	
		// Methods
		public IWebRequest CreateRequest();
		public Type GetCurrentTaskType();
		public void ResetHeaders(Func<Type, bool> conditionFunc, string key, string value);
		public void EnqueueHttpTask(IHttpTask task);
		public void InterruptAuthTask(IHttpTask authTask);
		public void Retry();
		private void RetryLater();
		private void RetryImmediate();
		public void ClearAllTask();
		public void DisposeCurrentTaskError();
		public void ClearAllCache();
		public void ClearCache<T>()
			where T : IHttpTask;
		void IUpdatable.FastUpdate();
		private void DisposeCurrentOperation();
		private void SendTask();
	}
}
