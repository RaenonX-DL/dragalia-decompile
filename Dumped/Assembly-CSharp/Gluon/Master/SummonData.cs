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
	public class SummonData : IMaster<Gluon.Master.SummonData>
	{
		// Fields
		[SerializeField]
		private SummonDataDictionary dict;
	
		// Properties
		public SummonDataDictionary Dict { get; }
		public SerializableDictionary<int, SummonDataElement> List { get; }
	
		// Constructors
		public SummonData();
	}
}
