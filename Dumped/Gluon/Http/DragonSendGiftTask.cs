using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DragonSendGiftTask : IHttpTask
	{
		private byte[] postData;

		private Action<DragonSendGiftResponse> onSuccess;

		private Action<ErrorType, int, DragonSendGiftResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DragonSendGiftTask(DragonSendGiftRequest request, Action<DragonSendGiftResponse> onSuccess, Action<ErrorType, int, DragonSendGiftResponse> onError)
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
