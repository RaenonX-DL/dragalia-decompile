using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DragonLimitBreakTask : IHttpTask
	{
		private byte[] postData;

		private Action<DragonLimitBreakResponse> onSuccess;

		private Action<ErrorType, int, DragonLimitBreakResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DragonLimitBreakTask(DragonLimitBreakRequest request, Action<DragonLimitBreakResponse> onSuccess, Action<ErrorType, int, DragonLimitBreakResponse> onError)
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
