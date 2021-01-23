/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	public class ExchangeTicket : ScriptableObject
	{
		// Fields
		[CompilerGenerated]
		private static ExchangeTicket _Instance_k__BackingField;
		public List<ExchangeTicketElement> List;
		private Dictionary<int, ExchangeTicketElement> dict;
	
		// Properties
		public static ExchangeTicket Instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public Dictionary<int, ExchangeTicketElement> Dict { get; }
	
		// Constructors
		public ExchangeTicket();
	
		// Methods
		private void OnEnable();
	}
}
