using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestSetAbilityCrestSetTask : IHttpTask
	{
		private byte[] postData;

		private Action<AbilityCrestSetAbilityCrestSetResponse> onSuccess;

		private Action<ErrorType, int, AbilityCrestSetAbilityCrestSetResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AbilityCrestSetAbilityCrestSetTask(AbilityCrestSetAbilityCrestSetRequest request, Action<AbilityCrestSetAbilityCrestSetResponse> onSuccess, Action<ErrorType, int, AbilityCrestSetAbilityCrestSetResponse> onError)
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
