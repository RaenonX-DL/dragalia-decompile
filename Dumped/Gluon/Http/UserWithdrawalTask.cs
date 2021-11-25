using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class UserWithdrawalTask : IHttpTask
	{
		private byte[] postData;

		private Action<UserWithdrawalResponse> onSuccess;

		private Action<ErrorType, int, UserWithdrawalResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public UserWithdrawalTask(UserWithdrawalRequest request, Action<UserWithdrawalResponse> onSuccess, Action<ErrorType, int, UserWithdrawalResponse> onError)
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
