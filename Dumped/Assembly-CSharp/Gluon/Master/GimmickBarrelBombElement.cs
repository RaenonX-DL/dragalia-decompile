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
	public class GimmickBarrelBombElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private string _Id;
		[SerializeField]
		private int _Attack;
		[SerializeField]
		private int _RateDamage;
		[SerializeField]
		private float _BlastHeight;
		[SerializeField]
		private float _BlastAngle;
		[SerializeField]
		private float _BlastGravity;
		[SerializeField]
		private float _ExplosionRange;
		[SerializeField]
		private float _InstallationTime;
	
		// Properties
		public string Id { get; }
		public int Attack { get; }
		public int RateDamage { get; }
		public float BlastHeight { get; }
		public float BlastAngle { get; }
		public float BlastGravity { get; }
		public float ExplosionRange { get; }
		public float InstallationTime { get; }
	
		// Constructors
		public GimmickBarrelBombElement();
	}
}
