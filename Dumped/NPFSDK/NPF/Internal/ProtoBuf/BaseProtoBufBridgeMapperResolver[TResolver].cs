/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Runtime.CompilerServices;
using JetBrains.Annotations;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.ProtoBuf
{
	internal abstract class BaseProtoBufBridgeMapperResolver<TResolver> : IProtoBufBridgeMapperResolver
		where TResolver : BaseProtoBufBridgeMapperResolver<TResolver>, new()
	{
		// Fields
		public static readonly IProtoBufBridgeMapperResolver Instance;
	
		// Constructors
		protected BaseProtoBufBridgeMapperResolver();
		static BaseProtoBufBridgeMapperResolver();
	
		// Methods
		[CanBeNull]
		public abstract IProtoBufBridgeMapper<T> GetMapper<T>();
	}
}
