using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugAstralItemAddAstralItemAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugAstralItemAddAstralItemAllResponse> onSuccess;

		private Action<ErrorType, int, DebugAstralItemAddAstralItemAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugAstralItemAddAstralItemAllTask(DebugAstralItemAddAstralItemAllRequest request, Action<DebugAstralItemAddAstralItemAllResponse> onSuccess, Action<ErrorType, int, DebugAstralItemAddAstralItemAllResponse> onError)
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
