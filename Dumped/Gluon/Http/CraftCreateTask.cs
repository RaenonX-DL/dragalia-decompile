using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CraftCreateTask : IHttpTask
	{
		private byte[] postData;

		private Action<CraftCreateResponse> onSuccess;

		private Action<ErrorType, int, CraftCreateResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CraftCreateTask(CraftCreateRequest request, Action<CraftCreateResponse> onSuccess, Action<ErrorType, int, CraftCreateResponse> onError)
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
