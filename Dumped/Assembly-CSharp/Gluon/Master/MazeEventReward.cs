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
	[Serializable]
	public class MazeEventReward : IMasterGroupElement
	{
		// Fields
		[SerializeField]
		private MazeEventRewardDictionary dict;
	
		// Properties
		public MazeEventRewardDictionary Dict { get; }
		public SerializableDictionary<int, MazeEventRewardElement> List { get; }
	
		// Constructors
		public MazeEventReward();
	}
}
