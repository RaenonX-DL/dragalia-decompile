using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class RaidEventEntryTask : IHttpTask
	{
		private byte[] postData;

		private Action<RaidEventEntryResponse> onSuccess;

		private Action<ErrorType, int, RaidEventEntryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public RaidEventEntryTask(RaidEventEntryRequest request, Action<RaidEventEntryResponse> onSuccess, Action<ErrorType, int, RaidEventEntryResponse> onError)
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
