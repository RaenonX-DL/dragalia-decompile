using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugAbilityCrestAddAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugAbilityCrestAddAllResponse> onSuccess;

		private Action<ErrorType, int, DebugAbilityCrestAddAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugAbilityCrestAddAllTask(DebugAbilityCrestAddAllRequest request, Action<DebugAbilityCrestAddAllResponse> onSuccess, Action<ErrorType, int, DebugAbilityCrestAddAllResponse> onError)
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
