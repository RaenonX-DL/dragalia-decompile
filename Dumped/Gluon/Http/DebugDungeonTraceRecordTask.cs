using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDungeonTraceRecordTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDungeonTraceRecordResponse> onSuccess;

		private Action<ErrorType, int, DebugDungeonTraceRecordResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDungeonTraceRecordTask(DebugDungeonTraceRecordRequest request, Action<DebugDungeonTraceRecordResponse> onSuccess, Action<ErrorType, int, DebugDungeonTraceRecordResponse> onError)
		{
		}

		public void SetHeader(string key, string value)
		{
		}

		public IWebRequest Send(string url)
		{
			return null;
		}

		public bool Deserialize(byte[] body)
		{
			return default(bool);
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}
	}
}
