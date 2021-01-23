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
	public class ServantData : ActionParts.PartsData
	{
		// Fields
		public static readonly int popNumMax;
		[HideInInspector]
		[SerializeField]
		private int _popNum;
		[HideInInspector]
		[SerializeField]
		private PopStyle _popStyle;
		[HideInInspector]
		[SerializeField]
		private BasePoint _basePoint;
		[HideInInspector]
		[SerializeField]
		private float[] _angle;
		[HideInInspector]
		[SerializeField]
		private float[] _radius;
		[HideInInspector]
		[SerializeField]
		private Vector3[] _offset;
	
		// Properties
		public int popNum { get; }
		public PopStyle popStyle { get; }
		public BasePoint basePoint { get; }
		public float[] angle { get; }
		public float[] radius { get; }
		public Vector3[] offset { get; }
	
		// Nested types
		public enum PopStyle
		{
			Offset = 0,
			Around = 1
		}
	
		public enum BasePoint
		{
			Owner = 0,
			Target = 1
		}
	
		// Constructors
		public ServantData();
		static ServantData();
	}
}
