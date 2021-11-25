using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CharaBuildupTask : IHttpTask
	{
		private byte[] postData;

		private Action<CharaBuildupResponse> onSuccess;

		private Action<ErrorType, int, CharaBuildupResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CharaBuildupTask(CharaBuildupRequest request, Action<CharaBuildupResponse> onSuccess, Action<ErrorType, int, CharaBuildupResponse> onError)
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
