using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class UserRecoverStaminaByStoneTask : IHttpTask
	{
		private byte[] postData;

		private Action<UserRecoverStaminaByStoneResponse> onSuccess;

		private Action<ErrorType, int, UserRecoverStaminaByStoneResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public UserRecoverStaminaByStoneTask(UserRecoverStaminaByStoneRequest request, Action<UserRecoverStaminaByStoneResponse> onSuccess, Action<ErrorType, int, UserRecoverStaminaByStoneResponse> onError)
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
