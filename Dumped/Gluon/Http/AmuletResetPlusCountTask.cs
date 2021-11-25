using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AmuletResetPlusCountTask : IHttpTask
	{
		private byte[] postData;

		private Action<AmuletResetPlusCountResponse> onSuccess;

		private Action<ErrorType, int, AmuletResetPlusCountResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AmuletResetPlusCountTask(AmuletResetPlusCountRequest request, Action<AmuletResetPlusCountResponse> onSuccess, Action<ErrorType, int, AmuletResetPlusCountResponse> onError)
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
