using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CombatEventGetEventDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<CombatEventGetEventDataResponse> onSuccess;

		private Action<ErrorType, int, CombatEventGetEventDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CombatEventGetEventDataTask(CombatEventGetEventDataRequest request, Action<CombatEventGetEventDataResponse> onSuccess, Action<ErrorType, int, CombatEventGetEventDataResponse> onError)
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
