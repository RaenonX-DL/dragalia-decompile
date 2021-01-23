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
	public class MiasmaPointUpData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _defaultPoint;
		[HideInInspector]
		[SerializeField]
		private PointForEnemyParam[] _pointForParam;
		[HideInInspector]
		[SerializeField]
		private bool _isSetPoint;
	
		// Properties
		public float defaultPoint { get; }
		public PointForEnemyParam[] pointForParam { get; }
		public bool isSetPoint { get; }
	
		// Nested types
		[Serializable]
		public struct PointForEnemyParam
		{
			// Fields
			public float point;
			public int enemyParamId;
		}
	
		// Constructors
		public MiasmaPointUpData();
	}
}
