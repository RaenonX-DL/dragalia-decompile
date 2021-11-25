using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class CraftDisassembleTask : IHttpTask
	{
		private byte[] postData;

		private Action<CraftDisassembleResponse> onSuccess;

		private Action<ErrorType, int, CraftDisassembleResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public CraftDisassembleTask(CraftDisassembleRequest request, Action<CraftDisassembleResponse> onSuccess, Action<ErrorType, int, CraftDisassembleResponse> onError)
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
