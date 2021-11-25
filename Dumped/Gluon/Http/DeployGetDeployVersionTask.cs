using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class DeployGetDeployVersionTask : IHttpTask
	{
		private byte[] postData;

		private Action<DeployGetDeployVersionResponse> onSuccess;

		private Action<ErrorType, int, DeployGetDeployVersionResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public DeployGetDeployVersionTask(DeployGetDeployVersionRequest request, Action<DeployGetDeployVersionResponse> onSuccess, Action<ErrorType, int, DeployGetDeployVersionResponse> onError)
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
