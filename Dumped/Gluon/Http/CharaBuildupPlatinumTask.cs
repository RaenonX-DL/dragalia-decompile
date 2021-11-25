using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CharaBuildupPlatinumTask : IHttpTask
	{
		private byte[] postData;

		private Action<CharaBuildupPlatinumResponse> onSuccess;

		private Action<ErrorType, int, CharaBuildupPlatinumResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CharaBuildupPlatinumTask(CharaBuildupPlatinumRequest request, Action<CharaBuildupPlatinumResponse> onSuccess, Action<ErrorType, int, CharaBuildupPlatinumResponse> onError)
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
