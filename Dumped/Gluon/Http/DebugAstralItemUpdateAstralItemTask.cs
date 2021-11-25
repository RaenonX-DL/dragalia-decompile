using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugAstralItemUpdateAstralItemTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugAstralItemUpdateAstralItemResponse> onSuccess;

		private Action<ErrorType, int, DebugAstralItemUpdateAstralItemResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugAstralItemUpdateAstralItemTask(DebugAstralItemUpdateAstralItemRequest request, Action<DebugAstralItemUpdateAstralItemResponse> onSuccess, Action<ErrorType, int, DebugAstralItemUpdateAstralItemResponse> onError)
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
