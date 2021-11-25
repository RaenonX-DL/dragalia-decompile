using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class GuildUpdateUserSettingTask : IHttpTask
	{
		private byte[] postData;

		private Action<GuildUpdateUserSettingResponse> onSuccess;

		private Action<ErrorType, int, GuildUpdateUserSettingResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public GuildUpdateUserSettingTask(GuildUpdateUserSettingRequest request, Action<GuildUpdateUserSettingResponse> onSuccess, Action<ErrorType, int, GuildUpdateUserSettingResponse> onError)
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
