/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cute.Cri
{
	public class AudioListenerController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CriAtomListener listener;
		private float listenerLerpValue;
	
		// Constructors
		public AudioListenerController();
	
		// Methods
		public void Enable3dListener(bool isEnable);
		public void SetListenerLerpValue(float listenerLerpValue);
		public void Update3dListenerPos(Transform cameraTrans, Transform playerTrans);
		public Vector3 Get3dListenerPos();
		public void Set3dListenerPos(Vector3 listenerPos);
		public Quaternion Get3dListenerRot();
		public void Set3dListenerRot(Quaternion listenerRot);
		public void OnDrawGizmos();
	}
}
