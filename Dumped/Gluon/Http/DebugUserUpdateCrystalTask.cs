using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserUpdateCrystalTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserUpdateCrystalResponse> onSuccess;

		private Action<ErrorType, int, DebugUserUpdateCrystalResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserUpdateCrystalTask(DebugUserUpdateCrystalRequest request, Action<DebugUserUpdateCrystalResponse> onSuccess, Action<ErrorType, int, DebugUserUpdateCrystalResponse> onError)
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
