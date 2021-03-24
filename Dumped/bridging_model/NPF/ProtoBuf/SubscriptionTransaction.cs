/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using ProtoBuf;

// Image 41: bridging_model.dll - Assembly: bridging_model, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.ProtoBuf
{
	[Serializable]
	[ProtoContract]
	public class SubscriptionTransaction : IExtensible
	{
		// Fields
		private string _order_id;
		private string _product_id;
		private SubscriptionTransactionState? _state;
		private IExtension extensionObject;
	
		// Properties
		[ProtoMember]
		public string order_id { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool order_idSpecified { get; set; }
		[ProtoMember]
		public string product_id { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool product_idSpecified { get; set; }
		[ProtoMember]
		public SubscriptionTransactionState? state { get; set; }
		[Browsable]
		[XmlIgnore]
		public bool stateSpecified { get; set; }
	
		// Nested types
		[ProtoContract]
		public enum SubscriptionTransactionState
		{
			PENDING = 0,
			PURCHASED = 1,
			DEFERRED = 2
		}
	
		// Constructors
		public SubscriptionTransaction();
	
		// Methods
		IExtension IExtensible.GetExtensionObject(bool createIfMissing);
		private bool ShouldSerializeorder_id();
		private void Resetorder_id();
		private bool ShouldSerializeproduct_id();
		private void Resetproduct_id();
		private bool ShouldSerializestate();
		private void Resetstate();
	}
}
