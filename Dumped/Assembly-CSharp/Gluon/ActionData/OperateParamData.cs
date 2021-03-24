/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class OperateParamData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private InGameDef.CharacterType _characterType;
		[HideInInspector]
		[SerializeField]
		private ParameterType _parameterType;
		[HideInInspector]
		[SerializeField]
		private float _value;
	
		// Properties
		public InGameDef.CharacterType characterType { get; }
		public ParameterType parameterType { get; }
		public float value { get; }
	
		// Nested types
		public enum ParameterType
		{
			None = 0,
			BreakDamageRate = 1,
			Rage = 2
		}
	
		// Constructors
		public OperateParamData();
	}
}
