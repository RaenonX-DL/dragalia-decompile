﻿/*
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
	public class EventTopData : IMaster<Gluon.Master.EventTopData>
	{
		// Fields
		[SerializeField]
		private EventTopDataDictionary dict;
	
		// Properties
		public EventTopDataDictionary Dict { get; }
		public SerializableDictionary<int, EventTopDataElement> List { get; }
	
		// Constructors
		public EventTopData();
	}
}
