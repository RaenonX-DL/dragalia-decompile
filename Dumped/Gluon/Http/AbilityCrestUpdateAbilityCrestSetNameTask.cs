using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestUpdateAbilityCrestSetNameTask : IHttpTask
	{
		private byte[] postData;

		private Action<AbilityCrestUpdateAbilityCrestSetNameResponse> onSuccess;

		private Action<ErrorType, int, AbilityCrestUpdateAbilityCrestSetNameResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AbilityCrestUpdateAbilityCrestSetNameTask(AbilityCrestUpdateAbilityCrestSetNameRequest request, Action<AbilityCrestUpdateAbilityCrestSetNameResponse> onSuccess, Action<ErrorType, int, AbilityCrestUpdateAbilityCrestSetNameResponse> onError)
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
