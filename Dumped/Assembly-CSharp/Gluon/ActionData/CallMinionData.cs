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
	public class CallMinionData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private string _generatorLabel;
		[HideInInspector]
		[SerializeField]
		private PopStyle _popStyle;
		[HideInInspector]
		[SerializeField]
		private BaseType _baseType;
		[HideInInspector]
		[SerializeField]
		private float _angle;
		[HideInInspector]
		[SerializeField]
		private float _radius;
		[HideInInspector]
		[SerializeField]
		private Vector3 _offset;
		[HideInInspector]
		[SerializeField]
		public bool _isMinionDirEdit;
		[HideInInspector]
		[SerializeField]
		private float _minionForward;
		[HideInInspector]
		[SerializeField]
		private float _minionAreaRadius;
		[HideInInspector]
		[SerializeField]
		private bool _isHostSync;
	
		// Properties
		public string generatorLabel { get; }
		public PopStyle popStyle { get; }
		public BaseType baseType { get; }
		public float angle { get; }
		public float radius { get; }
		public Vector3 offset { get; }
		public bool isMinionDirEdit { get; }
		public float minionForward { get; }
		public float minionAreaRadius { get; }
		public bool IsHostSync { get; }
	
		// Nested types
		public enum PopStyle
		{
			Offset = 0,
			Around = 1
		}
	
		public enum BaseType
		{
			Generator = 0,
			Owner = 1,
			WorldCenter = 2,
			Target = 3,
			AreaAnchor = 4
		}
	
		// Constructors
		public CallMinionData();
	}
}
