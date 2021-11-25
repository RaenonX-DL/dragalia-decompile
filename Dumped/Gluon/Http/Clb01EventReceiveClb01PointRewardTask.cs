using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class Clb01EventReceiveClb01PointRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<Clb01EventReceiveClb01PointRewardResponse> onSuccess;

		private Action<ErrorType, int, Clb01EventReceiveClb01PointRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public Clb01EventReceiveClb01PointRewardTask(Clb01EventReceiveClb01PointRewardRequest request, Action<Clb01EventReceiveClb01PointRewardResponse> onSuccess, Action<ErrorType, int, Clb01EventReceiveClb01PointRewardResponse> onError)
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
