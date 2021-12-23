using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeGetDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeGetDataResponse> onSuccess;

		private Action<ErrorType, int, DmodeGetDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeGetDataTask(DmodeGetDataRequest request, Action<DmodeGetDataResponse> onSuccess, Action<ErrorType, int, DmodeGetDataResponse> onError)
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
