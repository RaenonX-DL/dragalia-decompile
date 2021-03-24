/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	public class EventPassive : IMaster<Gluon.Master.EventPassive>
	{
		// Fields
		[SerializeField]
		private EventPassiveDictionary dict;
	
		// Properties
		public EventPassiveDictionary Dict { get; }
		public SerializableDictionary<int, EventPassiveElement> List { get; }
	
		// Constructors
		public EventPassive();
	}
}
