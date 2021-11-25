using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DragonResetPlusCountTask : IHttpTask
	{
		private byte[] postData;

		private Action<DragonResetPlusCountResponse> onSuccess;

		private Action<ErrorType, int, DragonResetPlusCountResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DragonResetPlusCountTask(DragonResetPlusCountRequest request, Action<DragonResetPlusCountResponse> onSuccess, Action<ErrorType, int, DragonResetPlusCountResponse> onError)
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
