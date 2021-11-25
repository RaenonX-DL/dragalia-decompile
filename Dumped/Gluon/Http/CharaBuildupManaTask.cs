using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CharaBuildupManaTask : IHttpTask
	{
		private byte[] postData;

		private Action<CharaBuildupManaResponse> onSuccess;

		private Action<ErrorType, int, CharaBuildupManaResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CharaBuildupManaTask(CharaBuildupManaRequest request, Action<CharaBuildupManaResponse> onSuccess, Action<ErrorType, int, CharaBuildupManaResponse> onError)
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
