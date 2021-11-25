using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugAstralItemAddAstralItemTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugAstralItemAddAstralItemResponse> onSuccess;

		private Action<ErrorType, int, DebugAstralItemAddAstralItemResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugAstralItemAddAstralItemTask(DebugAstralItemAddAstralItemRequest request, Action<DebugAstralItemAddAstralItemResponse> onSuccess, Action<ErrorType, int, DebugAstralItemAddAstralItemResponse> onError)
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
