using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class WeaponBodyBuildupPieceTask : IHttpTask
	{
		private byte[] postData;

		private Action<WeaponBodyBuildupPieceResponse> onSuccess;

		private Action<ErrorType, int, WeaponBodyBuildupPieceResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public WeaponBodyBuildupPieceTask(WeaponBodyBuildupPieceRequest request, Action<WeaponBodyBuildupPieceResponse> onSuccess, Action<ErrorType, int, WeaponBodyBuildupPieceResponse> onError)
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
