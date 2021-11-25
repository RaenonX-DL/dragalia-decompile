using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class MissionReceiveAlbumRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<MissionReceiveAlbumRewardResponse> onSuccess;

		private Action<ErrorType, int, MissionReceiveAlbumRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public MissionReceiveAlbumRewardTask(MissionReceiveAlbumRewardRequest request, Action<MissionReceiveAlbumRewardResponse> onSuccess, Action<ErrorType, int, MissionReceiveAlbumRewardResponse> onError)
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
