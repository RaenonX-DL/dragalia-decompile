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
	public class RankingData : IMaster<Gluon.Master.RankingData>
	{
		// Fields
		[SerializeField]
		private RankingDataDictionary dict;
	
		// Properties
		public RankingDataDictionary Dict { get; }
		public SerializableDictionary<int, RankingDataElement> List { get; }
	
		// Constructors
		public RankingData();
	}
}
