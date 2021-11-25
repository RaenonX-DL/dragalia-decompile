using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class PartyUpdatePartyNameTask : IHttpTask
	{
		private byte[] postData;

		private Action<PartyUpdatePartyNameResponse> onSuccess;

		private Action<ErrorType, int, PartyUpdatePartyNameResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public PartyUpdatePartyNameTask(PartyUpdatePartyNameRequest request, Action<PartyUpdatePartyNameResponse> onSuccess, Action<ErrorType, int, PartyUpdatePartyNameResponse> onError)
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
