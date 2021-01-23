/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ContactGodRay : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public MeshRenderer[] rayItems;
		private List<Material> matList;
	
		// Constructors
		public ContactGodRay();
	
		// Methods
		private void Awake();
		public Tweener Brighten(float duration);
		public Tweener Dim(float duration);
		public void SetColorPower(float value);
		[CompilerGenerated]
		private void _Brighten_b__3_0(float x);
		[CompilerGenerated]
		private void _Dim_b__4_0(float x);
	}
}
