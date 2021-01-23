/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using SerializableCollections;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	public class QuestGuestData : IMaster<Gluon.Master.QuestGuestData>
	{
		// Fields
		[SerializeField]
		private QuestGuestDataDictionary dict;
	
		// Properties
		public QuestGuestDataDictionary Dict { get; }
		public SerializableDictionary<int, QuestGuestDataElement> List { get; }
	
		// Constructors
		public QuestGuestData();
	}
}
