using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DragonSellTask : IHttpTask
	{
		private byte[] postData;

		private Action<DragonSellResponse> onSuccess;

		private Action<ErrorType, int, DragonSellResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DragonSellTask(DragonSellRequest request, Action<DragonSellResponse> onSuccess, Action<ErrorType, int, DragonSellResponse> onError)
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
