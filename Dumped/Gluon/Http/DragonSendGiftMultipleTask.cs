using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DragonSendGiftMultipleTask : IHttpTask
	{
		private byte[] postData;

		private Action<DragonSendGiftMultipleResponse> onSuccess;

		private Action<ErrorType, int, DragonSendGiftMultipleResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DragonSendGiftMultipleTask(DragonSendGiftMultipleRequest request, Action<DragonSendGiftMultipleResponse> onSuccess, Action<ErrorType, int, DragonSendGiftMultipleResponse> onError)
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
