using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MazeEventEntryTask : IHttpTask
	{
		private byte[] postData;

		private Action<MazeEventEntryResponse> onSuccess;

		private Action<ErrorType, int, MazeEventEntryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MazeEventEntryTask(MazeEventEntryRequest request, Action<MazeEventEntryResponse> onSuccess, Action<ErrorType, int, MazeEventEntryResponse> onError)
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
