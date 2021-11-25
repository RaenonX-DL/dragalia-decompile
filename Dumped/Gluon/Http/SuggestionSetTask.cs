using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SuggestionSetTask : IHttpTask
	{
		private byte[] postData;

		private Action<SuggestionSetResponse> onSuccess;

		private Action<ErrorType, int, SuggestionSetResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SuggestionSetTask(SuggestionSetRequest request, Action<SuggestionSetResponse> onSuccess, Action<ErrorType, int, SuggestionSetResponse> onError)
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
