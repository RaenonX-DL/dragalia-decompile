using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class AbilityCrestBuildupPieceTask : IHttpTask
	{
		private byte[] postData;

		private Action<AbilityCrestBuildupPieceResponse> onSuccess;

		private Action<ErrorType, int, AbilityCrestBuildupPieceResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public AbilityCrestBuildupPieceTask(AbilityCrestBuildupPieceRequest request, Action<AbilityCrestBuildupPieceResponse> onSuccess, Action<ErrorType, int, AbilityCrestBuildupPieceResponse> onError)
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
