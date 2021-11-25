using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugUserIncreaseCrystalTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugUserIncreaseCrystalResponse> onSuccess;

		private Action<ErrorType, int, DebugUserIncreaseCrystalResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugUserIncreaseCrystalTask(DebugUserIncreaseCrystalRequest request, Action<DebugUserIncreaseCrystalResponse> onSuccess, Action<ErrorType, int, DebugUserIncreaseCrystalResponse> onError)
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
