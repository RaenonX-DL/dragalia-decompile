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
	public class QuestTreasureData : IMaster<Gluon.Master.QuestTreasureData>
	{
		// Fields
		[SerializeField]
		private QuestTreasureDataDictionary dict;
	
		// Properties
		public QuestTreasureDataDictionary Dict { get; }
		public SerializableDictionary<int, QuestTreasureDataElement> List { get; }
	
		// Constructors
		public QuestTreasureData();
	}
}
