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
	public class CastleStory : IMaster<Gluon.Master.CastleStory>
	{
		// Fields
		[SerializeField]
		private CastleStoryDictionary dict;
	
		// Properties
		public CastleStoryDictionary Dict { get; }
		public SerializableDictionary<int, CastleStoryElement> List { get; }
	
		// Constructors
		public CastleStory();
	}
}
