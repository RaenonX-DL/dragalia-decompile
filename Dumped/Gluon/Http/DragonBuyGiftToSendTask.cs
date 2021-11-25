using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DragonBuyGiftToSendTask : IHttpTask
	{
		private byte[] postData;

		private Action<DragonBuyGiftToSendResponse> onSuccess;

		private Action<ErrorType, int, DragonBuyGiftToSendResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DragonBuyGiftToSendTask(DragonBuyGiftToSendRequest request, Action<DragonBuyGiftToSendResponse> onSuccess, Action<ErrorType, int, DragonBuyGiftToSendResponse> onError)
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
