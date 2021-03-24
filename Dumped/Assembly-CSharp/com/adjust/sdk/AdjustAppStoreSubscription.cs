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
	public class AdjustAppStoreSubscription
	{
		// Fields
		internal string price;
		internal string currency;
		internal string transactionId;
		internal string receipt;
		internal string billingStore;
		internal string transactionDate;
		internal string salesRegion;
		internal List<string> partnerList;
		internal List<string> callbackList;
	
		// Constructors
		public AdjustAppStoreSubscription(string price, string currency, string transactionId, string receipt);
	
		// Methods
		public void setTransactionDate(string transactionDate);
		public void setSalesRegion(string salesRegion);
		public void addCallbackParameter(string key, string value);
		public void addPartnerParameter(string key, string value);
	}
}
