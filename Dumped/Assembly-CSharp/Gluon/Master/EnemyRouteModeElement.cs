/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EnemyRouteModeElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private float _MoveSpeed;
		[SerializeField]
		private float _BackSpeed;
		[SerializeField]
		private float _DistanceOfSight;
		[SerializeField]
		private float _AngleOfSight;
		[SerializeField]
		private float _OutOfRange;
		[SerializeField]
		private int _Obtuse;
	
		// Properties
		public int Id { get; }
		public float MoveSpeed { get; }
		public float BackSpeed { get; }
		public float DistanceOfSight { get; }
		public float AngleOfSight { get; }
		public float OutOfRange { get; }
		public int Obtuse { get; }
	
		// Constructors
		public EnemyRouteModeElement();
	}
}
