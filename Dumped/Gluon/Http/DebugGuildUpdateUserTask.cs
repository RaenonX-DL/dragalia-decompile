using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugGuildUpdateUserTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugGuildUpdateUserResponse> onSuccess;

		private Action<ErrorType, int, DebugGuildUpdateUserResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugGuildUpdateUserTask(DebugGuildUpdateUserRequest request, Action<DebugGuildUpdateUserResponse> onSuccess, Action<ErrorType, int, DebugGuildUpdateUserResponse> onError)
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
