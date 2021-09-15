/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NPF;
using NPF.Audit;
using NPF.Subscription;

// Image 52: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Internal.ProtoBuf
{
	internal class ProtoBufBridgeMapperResolver : BaseProtoBufBridgeMapperResolver<ProtoBufBridgeMapperResolver>
	{
		// Nested types
		private static class Cache<T>
		{
			// Fields
			public static IProtoBufBridgeMapper<T> Mapper;
	
			// Constructors
			static Cache();
		}
	
		private class NPFErrorMapper : IProtoBufBridgeMapper<NPFError>
		{
			// Constructors
			public NPFErrorMapper();
		}
	
		private class ProfanityWordListMapper : IProtoBufBridgeMapper<IList<ProfanityWord>>
		{
			// Constructors
			public ProfanityWordListMapper();
		}
	
		private class ProfanityWordMapper : IProtoBufBridgeMapper<ProfanityWord>
		{
			// Constructors
			public ProfanityWordMapper();
		}
	
		private class SubscriptionTransactionMapper : IProtoBufBridgeMapper<SubscriptionTransaction>
		{
			// Constructors
			public SubscriptionTransactionMapper();
		}
	
		private class SubscriptionTransactionListMapper : IProtoBufBridgeMapper<SubscriptionTransaction[]>
		{
			// Constructors
			public SubscriptionTransactionListMapper();
		}
	
		// Constructors
		public ProtoBufBridgeMapperResolver();
	
		// Methods
		public override IProtoBufBridgeMapper<T> GetMapper<T>();
	}
}
