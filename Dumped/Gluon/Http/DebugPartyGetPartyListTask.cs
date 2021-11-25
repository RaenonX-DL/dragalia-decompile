using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugPartyGetPartyListTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugPartyGetPartyListResponse> onSuccess;

		private Action<ErrorType, int, DebugPartyGetPartyListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugPartyGetPartyListTask(DebugPartyGetPartyListRequest request, Action<DebugPartyGetPartyListResponse> onSuccess, Action<ErrorType, int, DebugPartyGetPartyListResponse> onError)
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
