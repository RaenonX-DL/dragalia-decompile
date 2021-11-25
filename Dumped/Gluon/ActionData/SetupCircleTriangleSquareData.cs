using System;
using UnityEngine;

namespace Gluon.ActionData
{
	[Serializable]
	public class SetupCircleTriangleSquareData : ActionParts.PartsData
	{
		[SerializeField]
		[HideInInspector]
		private Gluon.ActionPartsSetupCircleTriangleSquare.OwnerType _ownerType;

		[SerializeField]
		[HideInInspector]
		private CTSUniqueCtrl.PatternType _patternType;

		[SerializeField]
		[HideInInspector]
		private CTSUniqueCtrl.ShapeType _shapeType;

		[SerializeField]
		[HideInInspector]
		private string _hitAttrLabel;

		[SerializeField]
		[HideInInspector]
		private float _radius;

		[SerializeField]
		[HideInInspector]
		private string _effName;

		[SerializeField]
		[HideInInspector]
		private int _effTrig;

		[SerializeField]
		[HideInInspector]
		private string _seName;

		[SerializeField]
		[HideInInspector]
		private bool _isCancelDragon;

		[SerializeField]
		[HideInInspector]
		private bool _guarantee;

		public Gluon.ActionPartsSetupCircleTriangleSquare.OwnerType ownerType => default(Gluon.ActionPartsSetupCircleTriangleSquare.OwnerType);

		public CTSUniqueCtrl.PatternType patternType => default(CTSUniqueCtrl.PatternType);

		public CTSUniqueCtrl.ShapeType shapeType => default(CTSUniqueCtrl.ShapeType);

		public string hitAttrLabel => null;

		public float radius => default(float);

		public string effName => null;

		public int effTrig => default(int);

		public string seName => null;

		public bool isCancelDragon => default(bool);

		public bool guarantee => default(bool);
	}
}
