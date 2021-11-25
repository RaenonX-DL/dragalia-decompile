using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MazeEventGetEventDataTask : IHttpTask
	{
		private byte[] postData;

		private Action<MazeEventGetEventDataResponse> onSuccess;

		private Action<ErrorType, int, MazeEventGetEventDataResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MazeEventGetEventDataTask(MazeEventGetEventDataRequest request, Action<MazeEventGetEventDataResponse> onSuccess, Action<ErrorType, int, MazeEventGetEventDataResponse> onError)
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
