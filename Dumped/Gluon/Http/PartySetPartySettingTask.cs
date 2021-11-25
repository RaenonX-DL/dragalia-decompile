using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class PartySetPartySettingTask : IHttpTask
	{
		private byte[] postData;

		private Action<PartySetPartySettingResponse> onSuccess;

		private Action<ErrorType, int, PartySetPartySettingResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public PartySetPartySettingTask(PartySetPartySettingRequest request, Action<PartySetPartySettingResponse> onSuccess, Action<ErrorType, int, PartySetPartySettingResponse> onError)
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
