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
	public class AdjustEvent
	{
		// Fields
		internal string currency;
		internal string eventToken;
		internal string callbackId;
		internal string transactionId;
		internal double? revenue;
		internal List<string> partnerList;
		internal List<string> callbackList;
		internal string receipt;
		internal bool isReceiptSet;
	
		// Constructors
		public AdjustEvent(string eventToken);
	
		// Methods
		public void setRevenue(double amount, string currency);
		public void addCallbackParameter(string key, string value);
		public void addPartnerParameter(string key, string value);
		public void setTransactionId(string transactionId);
		public void setCallbackId(string callbackId);
		[Obsolete]
		public void setReceipt(string receipt, string transactionId);
	}
}
