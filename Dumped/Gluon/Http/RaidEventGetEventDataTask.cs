using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class RaidEventGetEventDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<RaidEventGetEventDataResponse> onSuccess;

		private Action<ErrorType, int, RaidEventGetEventDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public RaidEventGetEventDataTask(RaidEventGetEventDataRequest request, Action<RaidEventGetEventDataResponse> onSuccess, Action<ErrorType, int, RaidEventGetEventDataResponse> onError)
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
