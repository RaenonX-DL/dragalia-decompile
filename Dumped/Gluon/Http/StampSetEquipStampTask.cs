using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class StampSetEquipStampTask : IHttpTask
	{
		private byte[] postData;

		private Action<StampSetEquipStampResponse> onSuccess;

		private Action<ErrorType, int, StampSetEquipStampResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public StampSetEquipStampTask(StampSetEquipStampRequest request, Action<StampSetEquipStampResponse> onSuccess, Action<ErrorType, int, StampSetEquipStampResponse> onError)
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
