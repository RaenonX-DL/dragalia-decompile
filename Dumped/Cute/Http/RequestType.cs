using System.Runtime.InteropServices;

namespace Cute.Http
{
	[StructLayout(3, Size = 4)]
	public enum RequestType
	{
		SecureHttps,
		UnityWebRequest
	}
}
