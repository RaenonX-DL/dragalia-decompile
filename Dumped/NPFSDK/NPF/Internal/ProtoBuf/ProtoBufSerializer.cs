/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Runtime.CompilerServices;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.ProtoBuf
{
	internal class ProtoBufSerializer : IProtoBufSerializer
	{
		// Fields
		private readonly IBridgingModelSerializer _bridgingModelSerializer;
		private readonly IProtoBufBridgeMapperResolver[] _resolvers;
	
		// Constructors
		public ProtoBufSerializer(IBridgingModelSerializer bridgingModelSerializer, [System.ParamArray] IProtoBufBridgeMapperResolver[] resolvers);
	}
}
