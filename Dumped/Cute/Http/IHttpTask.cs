namespace Cute.Http
{
	public interface IHttpTask
	{
		bool IsEncrypt { get; }

		int CacheTime { get; }

		IWebRequest Send(string url);

		bool Deserialize(byte[] body);

		void OnError(ErrorType errorType, int resultCode);

		void SetHeader(string key, string value);
	}
}
