/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EventPassiveElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _EventId;
		[SerializeField]
		private int _PassiveNum;
		[SerializeField]
		private EventPassiveType _EventPassiveType;
		[SerializeField]
		private string _EventPassiveNameText;
		[SerializeField]
		private string _EventPassiveDetailText;
		[SerializeField]
		private int _MaxGrowValue;
		[SerializeField]
		private int _UpGrowValue;
		[SerializeField]
		private int _ViewRarity;
		[SerializeField]
		private int _PartyPowerGrowValue;
		[SerializeField]
		private int _IconImage;
	
		// Properties
		public int Id { get; }
		public int EventId { get; }
		public int PassiveNum { get; }
		public EventPassiveType EventPassiveType { get; }
		public string EventPassiveNameText { get; }
		public string EventPassiveDetailText { get; }
		public int MaxGrowValue { get; }
		public int UpGrowValue { get; }
		public int ViewRarity { get; }
		public int PartyPowerGrowValue { get; }
		public int IconImage { get; }
	
		// Constructors
		public EventPassiveElement();
	}
}
