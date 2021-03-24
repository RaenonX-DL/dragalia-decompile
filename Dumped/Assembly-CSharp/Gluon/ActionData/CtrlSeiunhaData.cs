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
	public class CtrlSeiunhaData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private ActionPartsCtrlSeiunha.Order _order;
		[HideInInspector]
		[SerializeField]
		private InGameDef.CharacterType _characterType;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabel;
		[HideInInspector]
		[SerializeField]
		private string _hitAttrLabelExplosion;
		[HideInInspector]
		[SerializeField]
		private float _radius;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offsetPos;
		[HideInInspector]
		[SerializeField]
		private float _offsetDir;
		[HideInInspector]
		[SerializeField]
		private float _bulletSpeed;
		[HideInInspector]
		[SerializeField]
		private float _lifetime;
		[HideInInspector]
		[SerializeField]
		private float _afterglowTime;
		[HideInInspector]
		[SerializeField]
		private bool _isHoming;
		[HideInInspector]
		[SerializeField]
		private float _scaleSpeed;
		[HideInInspector]
		[SerializeField]
		private float _radiusMax;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private string _seFire;
		[HideInInspector]
		[SerializeField]
		private string _seExplosion;
		[HideInInspector]
		[SerializeField]
		private bool _guarantee;
	
		// Properties
		public ActionPartsCtrlSeiunha.Order order { get; }
		public InGameDef.CharacterType characterType { get; }
		public string hitAttrLabel { get; }
		public string hitAttrLabelExplosion { get; }
		public float radius { get; }
		public Vector3 offsetPos { get; }
		public float offsetDir { get; }
		public float bulletSpeed { get; }
		public float lifetime { get; }
		public float afterglowTime { get; }
		public bool isHoming { get; }
		public float scaleSpeed { get; }
		public float radiusMax { get; }
		public string effectName { get; }
		public string seFire { get; }
		public string seExplosion { get; }
		public bool guarantee { get; }
	
		// Constructors
		public CtrlSeiunhaData();
	}
}
