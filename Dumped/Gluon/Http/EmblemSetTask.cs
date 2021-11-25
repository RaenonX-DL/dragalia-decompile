using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EmblemSetTask : IHttpTask
	{
		private byte[] postData;

		private Action<EmblemSetResponse> onSuccess;

		private Action<ErrorType, int, EmblemSetResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EmblemSetTask(EmblemSetRequest request, Action<EmblemSetResponse> onSuccess, Action<ErrorType, int, EmblemSetResponse> onError)
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
