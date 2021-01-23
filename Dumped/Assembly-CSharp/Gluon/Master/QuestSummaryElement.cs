/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class QuestSummaryElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private QuestClearType _QuestClearType;
		[SerializeField]
		private QuestFailedType _QuestFailedType;
		[SerializeField]
		private string _ShowStartMessage;
	
		// Properties
		public QuestClearType QuestClearType { get; }
		public QuestFailedType QuestFailedType { get; }
		public string ShowStartMessage { get; }
	
		// Constructors
		public QuestSummaryElement();
	}
}
