/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace com.adjust.sdk
{
	public class AdjustPlayStoreSubscription
	{
		// Fields
		internal string price;
		internal string currency;
		internal string sku;
		internal string orderId;
		internal string signature;
		internal string purchaseToken;
		internal string billingStore;
		internal string purchaseTime;
		internal List<string> partnerList;
		internal List<string> callbackList;
	
		// Constructors
		public AdjustPlayStoreSubscription(string price, string currency, string sku, string orderId, string signature, string purchaseToken);
	
		// Methods
		public void setPurchaseTime(string purchaseTime);
		public void addCallbackParameter(string key, string value);
		public void addPartnerParameter(string key, string value);
	}
}
