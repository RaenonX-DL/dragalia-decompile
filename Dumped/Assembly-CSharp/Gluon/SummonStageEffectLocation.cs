/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonStageEffectLocation : SingletonMonoBehaviour<Gluon.SummonStageEffectLocation>
	{
		// Fields
		[Header]
		[SerializeField]
		public Transform[] locations;
		public Transform[] weapons;
		public Transform[] moons;
		public SummonStageShadowReceiver[] shadows;
		public TweenSequenceVisualizer pillarMovement;
		public Animator statueAnimator;
		[Header]
		[SerializeField]
		public GameObject modelParent;
	
		// Constructors
		public SummonStageEffectLocation();
	
		// Methods
		public void ClearShadows();
	}
}
