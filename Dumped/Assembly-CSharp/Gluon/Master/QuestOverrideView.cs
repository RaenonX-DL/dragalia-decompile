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
	public class QuestOverrideView : IMaster<Gluon.Master.QuestOverrideView>
	{
		// Fields
		[SerializeField]
		private QuestOverrideViewDictionary dict;
	
		// Properties
		public QuestOverrideViewDictionary Dict { get; }
		public SerializableDictionary<int, QuestOverrideViewElement> List { get; }
	
		// Constructors
		public QuestOverrideView();
	}
}
