using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DragonSetLockTask : IHttpTask
	{
		private byte[] postData;

		private Action<DragonSetLockResponse> onSuccess;

		private Action<ErrorType, int, DragonSetLockResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DragonSetLockTask(DragonSetLockRequest request, Action<DragonSetLockResponse> onSuccess, Action<ErrorType, int, DragonSetLockResponse> onError)
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
