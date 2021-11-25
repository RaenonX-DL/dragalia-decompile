using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class StampGetStampTask : IHttpTask
	{
		private byte[] postData;

		private Action<StampGetStampResponse> onSuccess;

		private Action<ErrorType, int, StampGetStampResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public StampGetStampTask(StampGetStampRequest request, Action<StampGetStampResponse> onSuccess, Action<ErrorType, int, StampGetStampResponse> onError)
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
