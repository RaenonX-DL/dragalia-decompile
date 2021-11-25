using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum PhotonEventSerializerType
	{
		MsgPack,
		MessagePackCSharp,
		MessagePackCSharpWithSequenceId,
		LZ4MessagePackCSharp,
		LZ4MessagePackCSharpWithSequenceId
	}
}
