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
	public class MultiMarkerNeedRegisterPositionData : MarkerData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private MultiGenerateStyle _multiGenerateStyle;
		[HideInInspector]
		[SerializeField]
		private float _generateRangeMin;
		[HideInInspector]
		[SerializeField]
		private float _generateRangeMax;
		[HideInInspector]
		[SerializeField]
		private bool _isGenerateRangeRandom;
		[HideInInspector]
		[SerializeField]
		private int _generateNum;
		[HideInInspector]
		[SerializeField]
		private Vector3 _generateOffsetPos;
	
		// Properties
		public MultiGenerateStyle multiGenerateStyle { get; }
		public float generateRangeMin { get; }
		public float generateRangeMax { get; }
		public bool isGenerateRangeRandom { get; }
		public int generateNum { get; }
		public Vector3 generateOffsetPos { get; }
	
		// Nested types
		public enum MultiGenerateStyle
		{
			ControlPlayers = 0,
			AreaAnchorRandomOffsetAddAnchorPos = 1
		}
	
		// Constructors
		public MultiMarkerNeedRegisterPositionData();
	}
}
