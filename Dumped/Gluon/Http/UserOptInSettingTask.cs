using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class UserOptInSettingTask : IHttpTask
	{
		private byte[] postData;

		private Action<UserOptInSettingResponse> onSuccess;

		private Action<ErrorType, int, UserOptInSettingResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public UserOptInSettingTask(UserOptInSettingRequest request, Action<UserOptInSettingResponse> onSuccess, Action<ErrorType, int, UserOptInSettingResponse> onError)
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
