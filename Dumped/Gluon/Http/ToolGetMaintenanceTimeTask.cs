using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class ToolGetMaintenanceTimeTask : IHttpTask
	{
		private byte[] postData;

		private Action<ToolGetMaintenanceTimeResponse> onSuccess;

		private Action<ErrorType, int, ToolGetMaintenanceTimeResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public ToolGetMaintenanceTimeTask(ToolGetMaintenanceTimeRequest request, Action<ToolGetMaintenanceTimeResponse> onSuccess, Action<ErrorType, int, ToolGetMaintenanceTimeResponse> onError)
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
