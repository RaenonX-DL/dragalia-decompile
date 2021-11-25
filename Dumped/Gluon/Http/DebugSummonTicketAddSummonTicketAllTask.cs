using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugSummonTicketAddSummonTicketAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugSummonTicketAddSummonTicketAllResponse> onSuccess;

		private Action<ErrorType, int, DebugSummonTicketAddSummonTicketAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugSummonTicketAddSummonTicketAllTask(DebugSummonTicketAddSummonTicketAllRequest request, Action<DebugSummonTicketAddSummonTicketAllResponse> onSuccess, Action<ErrorType, int, DebugSummonTicketAddSummonTicketAllResponse> onError)
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
