using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class LoginPenaltyConfirmTask : IHttpTask
	{
		private byte[] postData;

		private Action<LoginPenaltyConfirmResponse> onSuccess;

		private Action<ErrorType, int, LoginPenaltyConfirmResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public LoginPenaltyConfirmTask(LoginPenaltyConfirmRequest request, Action<LoginPenaltyConfirmResponse> onSuccess, Action<ErrorType, int, LoginPenaltyConfirmResponse> onError)
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
