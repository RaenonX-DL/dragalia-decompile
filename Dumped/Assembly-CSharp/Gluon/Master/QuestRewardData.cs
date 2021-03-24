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
	public class QuestRewardData : IMaster<Gluon.Master.QuestRewardData>
	{
		// Fields
		[SerializeField]
		private QuestRewardDataDictionary dict;
	
		// Properties
		public QuestRewardDataDictionary Dict { get; }
		public SerializableDictionary<int, QuestRewardDataElement> List { get; }
	
		// Constructors
		public QuestRewardData();
	}
}
