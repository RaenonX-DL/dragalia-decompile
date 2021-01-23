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
	public class RemoveBuffTriggerBombData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _targetActionConditionId;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private bool _useSameComponent;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private string _seName;
	
		// Properties
		public int targetActionConditionId { get; }
		public string hitAttrLabel { get; }
		public bool useSameComponent { get; }
		public string effectName { get; }
		public string seName { get; }
	
		// Constructors
		public RemoveBuffTriggerBombData();
	}
}
