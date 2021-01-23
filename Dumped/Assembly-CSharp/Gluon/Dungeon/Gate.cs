/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon;
using UnityEngine;
using UnityEngine.AI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class Gate : Wall
	{
		// Fields
		protected Animator anim;
		private NavMeshObstacle _navMeshObs;
		protected int idle;
		protected GameObject arrow;
		protected Collider gateCollider;
		[Lock]
		[SerializeField]
		protected string effectId;
		[SerializeField]
		protected Vector3 effectOffset;
		[Lock]
		[SerializeField]
		protected string openEffectId;
		[Lock]
		[SerializeField]
		protected Vector3 openEffectOffset;
		[Lock]
		[SerializeField]
		protected string openedEffectId;
		protected EffectObject effectGameObject;
		protected EffectObject openEffectGameObject;
		[Lock]
		[SerializeField]
		protected string environmentSE;
		[Lock]
		[SerializeField]
		protected string openSE;
		protected AudioPlayback environmentSEPlayback;
		[Lock]
		[SerializeField]
		protected float openWaitTime;
		[Lock]
		[SerializeField]
		protected float nextArrowWaitTime;
		protected Dictionary<string, Localize.TextId> textDictionary;
	
		// Constructors
		public Gate();
	
		// Methods
		protected override void Start();
		protected override void OnDestroy();
		public override void Opened(bool sw);
		public virtual void Update();
		protected override void OnTriggerEvent();
	}
}
