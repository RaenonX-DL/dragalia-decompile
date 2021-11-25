using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CharaLimitBreakTask : IHttpTask
	{
		private byte[] postData;

		private Action<CharaLimitBreakResponse> onSuccess;

		private Action<ErrorType, int, CharaLimitBreakResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CharaLimitBreakTask(CharaLimitBreakRequest request, Action<CharaLimitBreakResponse> onSuccess, Action<ErrorType, int, CharaLimitBreakResponse> onError)
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
