using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DebugDragonUpdateDragonReliabilityAllTask : IHttpTask
	{
		private byte[] postData;

		private Action<DebugDragonUpdateDragonReliabilityAllResponse> onSuccess;

		private Action<ErrorType, int, DebugDragonUpdateDragonReliabilityAllResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DebugDragonUpdateDragonReliabilityAllTask(DebugDragonUpdateDragonReliabilityAllRequest request, Action<DebugDragonUpdateDragonReliabilityAllResponse> onSuccess, Action<ErrorType, int, DebugDragonUpdateDragonReliabilityAllResponse> onError)
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
