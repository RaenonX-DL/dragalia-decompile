using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class PushNotificationUpdateSettingTask : IHttpTask
	{
		private byte[] postData;

		private Action<PushNotificationUpdateSettingResponse> onSuccess;

		private Action<ErrorType, int, PushNotificationUpdateSettingResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public PushNotificationUpdateSettingTask(PushNotificationUpdateSettingRequest request, Action<PushNotificationUpdateSettingResponse> onSuccess, Action<ErrorType, int, PushNotificationUpdateSettingResponse> onError)
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
