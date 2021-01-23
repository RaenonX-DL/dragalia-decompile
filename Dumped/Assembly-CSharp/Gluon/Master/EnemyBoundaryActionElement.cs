/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class EnemyBoundaryActionElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _Id;
		[SerializeField]
		private int _DataId;
		[SerializeField]
		private int _ParamId;
		[SerializeField]
		private int _BoundaryValue;
		[SerializeField]
		private float _BoundaryRate;
		[SerializeField]
		private int _Action;
		[SerializeField]
		private EnemyBoundaryCondition _Condition;
	
		// Properties
		public int Id { get; }
		public int DataId { get; }
		public int ParamId { get; }
		public int BoundaryValue { get; }
		public float BoundaryRate { get; }
		public int Action { get; }
		public EnemyBoundaryCondition Condition { get; }
	
		// Constructors
		public EnemyBoundaryActionElement();
	}
}
