using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugHunterEventUpdateEventDataAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugHunterEventUpdateEventDataAllResponse> onSuccess;

		private Action<ErrorType, int, DebugHunterEventUpdateEventDataAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugHunterEventUpdateEventDataAllTask(DebugHunterEventUpdateEventDataAllRequest request, Action<DebugHunterEventUpdateEventDataAllResponse> onSuccess, Action<ErrorType, int, DebugHunterEventUpdateEventDataAllResponse> onError)
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
