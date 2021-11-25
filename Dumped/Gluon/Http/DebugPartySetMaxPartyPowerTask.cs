using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugPartySetMaxPartyPowerTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugPartySetMaxPartyPowerResponse> onSuccess;

		private Action<ErrorType, int, DebugPartySetMaxPartyPowerResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugPartySetMaxPartyPowerTask(DebugPartySetMaxPartyPowerRequest request, Action<DebugPartySetMaxPartyPowerResponse> onSuccess, Action<ErrorType, int, DebugPartySetMaxPartyPowerResponse> onError)
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
