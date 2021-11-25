using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class OptionGetOptionTask : IHttpTask
	{
		private byte[] postData;

		private Action<OptionGetOptionResponse> onSuccess;

		private Action<ErrorType, int, OptionGetOptionResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public OptionGetOptionTask(OptionGetOptionRequest request, Action<OptionGetOptionResponse> onSuccess, Action<ErrorType, int, OptionGetOptionResponse> onError)
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
