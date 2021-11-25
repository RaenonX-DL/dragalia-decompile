using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDragonUpdateCountContactTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDragonUpdateCountContactResponse> onSuccess;

		private Action<ErrorType, int, DebugDragonUpdateCountContactResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDragonUpdateCountContactTask(DebugDragonUpdateCountContactRequest request, Action<DebugDragonUpdateCountContactResponse> onSuccess, Action<ErrorType, int, DebugDragonUpdateCountContactResponse> onError)
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
