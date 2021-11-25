using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugPartyPartySettingTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugPartyPartySettingResponse> onSuccess;

		private Action<ErrorType, int, DebugPartyPartySettingResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugPartyPartySettingTask(DebugPartyPartySettingRequest request, Action<DebugPartyPartySettingResponse> onSuccess, Action<ErrorType, int, DebugPartyPartySettingResponse> onError)
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
