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
	public class QuestClearType : IMaster<Gluon.Master.QuestClearType>
	{
		// Fields
		[SerializeField]
		private QuestClearTypeDictionary dict;
	
		// Properties
		public QuestClearTypeDictionary Dict { get; }
		public SerializableDictionary<int, QuestClearTypeElement> List { get; }
	
		// Constructors
		public QuestClearType();
	}
}
