using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DmodeEntryTask : IHttpTask
	{
		private byte[] postData;

		private Action<DmodeEntryResponse> onSuccess;

		private Action<ErrorType, int, DmodeEntryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DmodeEntryTask(DmodeEntryRequest request, Action<DmodeEntryResponse> onSuccess, Action<ErrorType, int, DmodeEntryResponse> onError)
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
