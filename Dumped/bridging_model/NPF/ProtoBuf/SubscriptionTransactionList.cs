/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ProtoBuf;

// Image 41: bridging_model.dll - Assembly: bridging_model, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.ProtoBuf
{
	[Serializable]
	[ProtoContract]
	public class SubscriptionTransactionList : IExtensible
	{
		// Fields
		private readonly List<SubscriptionTransaction> _subscription_transaction;
		private IExtension extensionObject;
	
		// Properties
		[ProtoMember]
		public List<SubscriptionTransaction> subscription_transaction { get; }
	
		// Constructors
		public SubscriptionTransactionList();
	
		// Methods
		IExtension IExtensible.GetExtensionObject(bool createIfMissing);
	}
}
