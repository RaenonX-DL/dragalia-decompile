/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class HeadTextData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _text;
		[HideInInspector]
		[SerializeField]
		private ValueType _valueType;
		[HideInInspector]
		[SerializeField]
		private int _valueFactor;
		[HideInInspector]
		[SerializeField]
		private int _valueTargetConditionId;
		[HideInInspector]
		[SerializeField]
		private bool _isDispMasterTextNum;
		[HideInInspector]
		[SerializeField]
		private bool _isCheckAtActionStart;
	
		// Properties
		public string text { get; }
		public ValueType valueType { get; }
		public int valueFactor { get; }
		public int valueTargetConditionId { get; }
		public bool isDispMasterTextNum { get; }
		public bool isCheckAtActionStart { get; }
	
		// Nested types
		public enum ValueType
		{
			None = 0,
			BuffCount = 1,
			RemainTimes = 2,
			Aura = 3,
			BurstAura = 4
		}
	
		// Constructors
		public HeadTextData();
	}
}
