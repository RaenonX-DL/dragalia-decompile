using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AmuletSellTask : IHttpTask
	{
		private byte[] postData;

		private Action<AmuletSellResponse> onSuccess;

		private Action<ErrorType, int, AmuletSellResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AmuletSellTask(AmuletSellRequest request, Action<AmuletSellResponse> onSuccess, Action<ErrorType, int, AmuletSellResponse> onError)
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
