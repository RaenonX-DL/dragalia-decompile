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
	public class CharaModeData : IMaster<Gluon.Master.CharaModeData>
	{
		// Fields
		[SerializeField]
		private CharaModeDataDictionary dict;
	
		// Properties
		public CharaModeDataDictionary Dict { get; }
		public SerializableDictionary<int, CharaModeDataElement> List { get; }
	
		// Constructors
		public CharaModeData();
	}
}
