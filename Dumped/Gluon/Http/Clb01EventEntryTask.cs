using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class Clb01EventEntryTask : IHttpTask
	{
		private byte[] postData;

		private Action<Clb01EventEntryResponse> onSuccess;

		private Action<ErrorType, int, Clb01EventEntryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public Clb01EventEntryTask(Clb01EventEntryRequest request, Action<Clb01EventEntryResponse> onSuccess, Action<ErrorType, int, Clb01EventEntryResponse> onError)
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
