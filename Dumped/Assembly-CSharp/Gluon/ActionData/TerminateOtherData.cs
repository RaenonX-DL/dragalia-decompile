/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class TerminateOtherData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _startIndex;
		[HideInInspector]
		[SerializeField]
		private int _count;
		[HideInInspector]
		[SerializeField]
		private ConditionData _partConditionData;
		[HideInInspector]
		[SerializeField]
		private bool _toggleSkillNextAction;
		[HideInInspector]
		[SerializeField]
		private bool _skipRunningMotion;
	
		// Properties
		public int startIndex { get; }
		public int count { get; }
		public ConditionData partConditionData { get; }
		public bool toggleSkillNextAction { get; }
		public bool skipRunningMotion { get; }
	
		// Constructors
		public TerminateOtherData();
	}
}
