using System;
using System.Collections.Generic;

namespace Cute.Http
{
	public interface IWebRequest : IDisposable
	{
		byte[] bytes { get; }

		bool isDone { get; }

		string error { get; }

		Dictionary<string, string> responseHeaders { get; }

		void Post(string url, byte[] postData, Dictionary<string, string> headers);
	}
}
