using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class PartySetMainPartyNoTask : IHttpTask
	{
		private byte[] postData;

		private Action<PartySetMainPartyNoResponse> onSuccess;

		private Action<ErrorType, int, PartySetMainPartyNoResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public PartySetMainPartyNoTask(PartySetMainPartyNoRequest request, Action<PartySetMainPartyNoResponse> onSuccess, Action<ErrorType, int, PartySetMainPartyNoResponse> onError)
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
