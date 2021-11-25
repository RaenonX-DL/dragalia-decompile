using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestGetAbilityCrestSetListTask : IHttpTask
	{
		private byte[] postData;

		private Action<AbilityCrestGetAbilityCrestSetListResponse> onSuccess;

		private Action<ErrorType, int, AbilityCrestGetAbilityCrestSetListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AbilityCrestGetAbilityCrestSetListTask(AbilityCrestGetAbilityCrestSetListRequest request, Action<AbilityCrestGetAbilityCrestSetListResponse> onSuccess, Action<ErrorType, int, AbilityCrestGetAbilityCrestSetListResponse> onError)
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
