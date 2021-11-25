using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugAbilityCrestAddAbilityCrestTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugAbilityCrestAddAbilityCrestResponse> onSuccess;

		private Action<ErrorType, int, DebugAbilityCrestAddAbilityCrestResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugAbilityCrestAddAbilityCrestTask(DebugAbilityCrestAddAbilityCrestRequest request, Action<DebugAbilityCrestAddAbilityCrestResponse> onSuccess, Action<ErrorType, int, DebugAbilityCrestAddAbilityCrestResponse> onError)
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
