using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class SuggestionGetCategoryListTask : IHttpTask
	{
		private byte[] postData;

		private Action<SuggestionGetCategoryListResponse> onSuccess;

		private Action<ErrorType, int, SuggestionGetCategoryListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public SuggestionGetCategoryListTask(SuggestionGetCategoryListRequest request, Action<SuggestionGetCategoryListResponse> onSuccess, Action<ErrorType, int, SuggestionGetCategoryListResponse> onError)
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
