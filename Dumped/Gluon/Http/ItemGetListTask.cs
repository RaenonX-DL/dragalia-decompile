using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ItemGetListTask : IHttpTask
	{
		private byte[] postData;

		private Action<ItemGetListResponse> onSuccess;

		private Action<ErrorType, int, ItemGetListResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ItemGetListTask(ItemGetListRequest request, Action<ItemGetListResponse> onSuccess, Action<ErrorType, int, ItemGetListResponse> onError)
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
