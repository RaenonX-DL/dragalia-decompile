/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Runtime.CompilerServices;

// Image 49: NPFSDK.dll - Assembly: NPFSDK, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace NPF.Subscription
{
	public class SubscriptionTransaction
	{
		// Fields
		[CompilerGenerated]
		private string _OrderId_k__BackingField;
		[CompilerGenerated]
		private string _ProductId_k__BackingField;
		[CompilerGenerated]
		private SubscriptionTransactionState _State_k__BackingField;
	
		// Properties
		internal string OrderId { [CompilerGenerated] set; }
		internal string ProductId { [CompilerGenerated] set; }
		internal SubscriptionTransactionState State { [CompilerGenerated] set; }
	
		// Constructors
		internal SubscriptionTransaction(string orderId, string productId, SubscriptionTransactionState state);
	}
}
