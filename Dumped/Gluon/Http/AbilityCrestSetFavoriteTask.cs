using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestSetFavoriteTask : IHttpTask
	{
		private byte[] postData;

		private Action<AbilityCrestSetFavoriteResponse> onSuccess;

		private Action<ErrorType, int, AbilityCrestSetFavoriteResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AbilityCrestSetFavoriteTask(AbilityCrestSetFavoriteRequest request, Action<AbilityCrestSetFavoriteResponse> onSuccess, Action<ErrorType, int, AbilityCrestSetFavoriteResponse> onError)
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
