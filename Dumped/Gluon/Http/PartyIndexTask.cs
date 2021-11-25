using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class PartyIndexTask : IHttpTask
	{
		private byte[] postData;

		private Action<PartyIndexResponse> onSuccess;

		private Action<ErrorType, int, PartyIndexResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public PartyIndexTask(PartyIndexRequest request, Action<PartyIndexResponse> onSuccess, Action<ErrorType, int, PartyIndexResponse> onError)
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
