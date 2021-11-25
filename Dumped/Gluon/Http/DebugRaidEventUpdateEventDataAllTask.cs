using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugRaidEventUpdateEventDataAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugRaidEventUpdateEventDataAllResponse> onSuccess;

		private Action<ErrorType, int, DebugRaidEventUpdateEventDataAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugRaidEventUpdateEventDataAllTask(DebugRaidEventUpdateEventDataAllRequest request, Action<DebugRaidEventUpdateEventDataAllResponse> onSuccess, Action<ErrorType, int, DebugRaidEventUpdateEventDataAllResponse> onError)
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
