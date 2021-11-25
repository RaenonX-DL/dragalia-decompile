using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugSummonTicketAddTicketTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugSummonTicketAddTicketResponse> onSuccess;

		private Action<ErrorType, int, DebugSummonTicketAddTicketResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugSummonTicketAddTicketTask(DebugSummonTicketAddTicketRequest request, Action<DebugSummonTicketAddTicketResponse> onSuccess, Action<ErrorType, int, DebugSummonTicketAddTicketResponse> onError)
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
