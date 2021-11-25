using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class Setup2ndElementsData : ActionParts.PartsData
	{
		public enum ParameterSet
		{
			Default,
			Set_01,
			Set_02,
			Set_03,
			Set_04,
			Set_05,
			Set_06,
			Set_07,
			Set_08,
			Set_09,
			Set_10,
			Set_11,
			Set_12,
			Set_13,
			Set_14,
			Set_15
		}

		public static readonly int PARAMETER_SET_NUM;

		[SerializeField]
		[HideInInspector]
		private ParameterSet _paramSet;

		[SerializeField]
		[HideInInspector]
		private int[] _paramId;

		[SerializeField]
		[HideInInspector]
		private float[] _cursePoint;

		[SerializeField]
		[HideInInspector]
		private float[] _firePoint;

		[SerializeField]
		[HideInInspector]
		private float[] _windPoint;

		[SerializeField]
		[HideInInspector]
		private float[] _blessPoint;

		[SerializeField]
		[HideInInspector]
		private float[] _cursePower;

		[SerializeField]
		[HideInInspector]
		private float[] _firePower;

		[SerializeField]
		[HideInInspector]
		private float[] _windPower;

		[SerializeField]
		[HideInInspector]
		private float[] _blessPower;

		[SerializeField]
		[HideInInspector]
		private int _actionId;

		public ParameterSet paramSet => default(ParameterSet);

		public int[] paramId => null;

		public float[] cursePoint => null;

		public float[] firePoint => null;

		public float[] windPoint => null;

		public float[] blessPoint => null;

		public float[] cursePower => null;

		public float[] firePower => null;

		public float[] windPower => null;

		public float[] blessPower => null;

		public int actionId => default(int);
	}
}
