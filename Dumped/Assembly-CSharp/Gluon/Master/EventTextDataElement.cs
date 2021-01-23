/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EventTextDataElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _EventId;
		[SerializeField]
		private string _StaticTextLabel;
		[SerializeField]
		private string _EventText;
	
		// Properties
		public int Id { get; }
		public int EventId { get; }
		public string StaticTextLabel { get; }
		public string EventText { get; }
	
		// Constructors
		public EventTextDataElement();
	}
}
