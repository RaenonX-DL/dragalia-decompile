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
	public class ContactAsset : ScriptableObject
	{
		// Fields
		[SerializeField]
		public int dragonBaseID;
		[Header]
		[SerializeField]
		public Vector3 baseViewCam;
		public Vector3 baseRotCam;
		public Vector3 actionViewCam;
		public Vector3 actionRotCam;
	
		// Constructors
		public ContactAsset();
	
		// Methods
		public void CopyFrom(ContactAsset sampleAsset);
	}
}
