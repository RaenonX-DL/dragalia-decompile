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
	public class EventTextData : IMaster<Gluon.Master.EventTextData>
	{
		// Fields
		[SerializeField]
		private EventTextDataDictionary dict;
	
		// Properties
		public EventTextDataDictionary Dict { get; }
		public SerializableDictionary<int, EventTextDataElement> List { get; }
	
		// Constructors
		public EventTextData();
	}
}
