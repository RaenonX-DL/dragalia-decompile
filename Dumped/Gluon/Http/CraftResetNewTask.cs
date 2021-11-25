using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CraftResetNewTask : IHttpTask
	{
		private byte[] postData;

		private Action<CraftResetNewResponse> onSuccess;

		private Action<ErrorType, int, CraftResetNewResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CraftResetNewTask(CraftResetNewRequest request, Action<CraftResetNewResponse> onSuccess, Action<ErrorType, int, CraftResetNewResponse> onError)
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
