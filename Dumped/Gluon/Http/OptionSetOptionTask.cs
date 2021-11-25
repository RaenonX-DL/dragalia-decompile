using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class OptionSetOptionTask : IHttpTask
	{
		private byte[] postData;

		private Action<OptionSetOptionResponse> onSuccess;

		private Action<ErrorType, int, OptionSetOptionResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public OptionSetOptionTask(OptionSetOptionRequest request, Action<OptionSetOptionResponse> onSuccess, Action<ErrorType, int, OptionSetOptionResponse> onError)
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
