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
	public class SetupCircleTriangleSquareData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsSetupCircleTriangleSquare.OwnerType _ownerType;
		[HideInInspector]
		[SerializeField]
		private CTSUniqueCtrl.PatternType _patternType;
		[HideInInspector]
		[SerializeField]
		private CTSUniqueCtrl.ShapeType _shapeType;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private float _radius;
		[HideInInspector]
		[SerializeField]
		private string _effName;
		[HideInInspector]
		[SerializeField]
		private int _effTrig;
		[HideInInspector]
		[SerializeField]
		private string _seName;
		[HideInInspector]
		[SerializeField]
		private bool _isCancelDragon;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsSetupCircleTriangleSquare.OwnerType ownerType { get; }
		public CTSUniqueCtrl.PatternType patternType { get; }
		public CTSUniqueCtrl.ShapeType shapeType { get; }
		public string hitAttrLabel { get; }
		public float radius { get; }
		public string effName { get; }
		public int effTrig { get; }
		public string seName { get; }
		public bool isCancelDragon { get; }
		public bool guarantee { get; }
	
		// Constructors
		public SetupCircleTriangleSquareData();
	}
}
