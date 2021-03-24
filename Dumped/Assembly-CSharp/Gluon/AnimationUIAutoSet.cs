/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AnimationUIAutoSet : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public float enterScaleMin;
		public float enterScaleMax;
		public bool randomEnterScale;
		[Header]
		[SerializeField]
		public int enterDelayMin;
		public int enterDelayMax;
		[Header]
		[SerializeField]
		public int exitDelayMin;
		public int exitDelayMax;
		[Header]
		[SerializeField]
		public bool overrideOriginal;
		public GameObject[] objectsInSet;
		private AnimationUIAutoPublisher publisher;
	
		// Constructors
		public AnimationUIAutoSet();
	
		// Methods
		public void Preheat(AnimationUIAutoPublisher publisher);
		public void Publish(AnimationUIAutoPublisher publisher);
		public void PlayEnterAnimation();
		public void PlayExitAnimation();
		public void ClearPlayedState(bool enterState = false, bool exitState = false);
		public void CompleteRunningAnimation();
	}
}
