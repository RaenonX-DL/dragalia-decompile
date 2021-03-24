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
	public class SetupAlloutAssaultData : ActionParts.PartsData
	{
		// Fields
		public static readonly int PARAMETER_SET_NUM;
		[HideInInspector]
		[SerializeField]
		private ParameterSet _paramSet;
		[HideInInspector]
		[SerializeField]
		private int[] _paramId;
		[HideInInspector]
		[SerializeField]
		private string[] _assaultHitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private string[] _voiceLabel;
	
		// Properties
		public ParameterSet paramSet { get; }
		public int[] paramId { get; }
		public string[] assaultHitAttrLabel { get; }
		public string[] voiceLabel { get; }
	
		// Nested types
		public enum ParameterSet
		{
			Default = 0,
			Set_01 = 1,
			Set_02 = 2,
			Set_03 = 3,
			Set_04 = 4,
			Set_05 = 5,
			Set_06 = 6,
			Set_07 = 7,
			Set_08 = 8,
			Set_09 = 9,
			Set_10 = 10,
			Set_11 = 11,
			Set_12 = 12,
			Set_13 = 13,
			Set_14 = 14,
			Set_15 = 15
		}
	
		// Constructors
		public SetupAlloutAssaultData();
		static SetupAlloutAssaultData();
	}
}
