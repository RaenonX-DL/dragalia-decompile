using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AmuletLimitBreakTask : IHttpTask
	{
		private byte[] postData;

		private Action<AmuletLimitBreakResponse> onSuccess;

		private Action<ErrorType, int, AmuletLimitBreakResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AmuletLimitBreakTask(AmuletLimitBreakRequest request, Action<AmuletLimitBreakResponse> onSuccess, Action<ErrorType, int, AmuletLimitBreakResponse> onError)
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
