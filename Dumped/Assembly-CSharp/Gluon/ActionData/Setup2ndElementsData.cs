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
	public class Setup2ndElementsData : ActionParts.PartsData
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
		private float[] _cursePoint;
		[HideInInspector]
		[SerializeField]
		private float[] _firePoint;
		[HideInInspector]
		[SerializeField]
		private float[] _windPoint;
		[HideInInspector]
		[SerializeField]
		private float[] _blessPoint;
		[HideInInspector]
		[SerializeField]
		private float[] _cursePower;
		[HideInInspector]
		[SerializeField]
		private float[] _firePower;
		[HideInInspector]
		[SerializeField]
		private float[] _windPower;
		[HideInInspector]
		[SerializeField]
		private float[] _blessPower;
		[HideInInspector]
		[SerializeField]
		private int _actionId;
	
		// Properties
		public ParameterSet paramSet { get; }
		public int[] paramId { get; }
		public float[] cursePoint { get; }
		public float[] firePoint { get; }
		public float[] windPoint { get; }
		public float[] blessPoint { get; }
		public float[] cursePower { get; }
		public float[] firePower { get; }
		public float[] windPower { get; }
		public float[] blessPower { get; }
		public int actionId { get; }
	
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
		public Setup2ndElementsData();
		static Setup2ndElementsData();
	}
}
