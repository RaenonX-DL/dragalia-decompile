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
	public class FacilityEffectSetter : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private string effName;
		[SerializeField]
		private Color color;
		[SerializeField]
		private bool needApplyColor;
		[SerializeField]
		private int triggerId;
		private GameObject effectObj;
	
		// Constructors
		public FacilityEffectSetter();
	
		// Methods
		private void Start();
		private string GetEffectPath(string fileName);
		private void DummyForAvoidingWarning(string name, int triggerId, GameObject obj);
	}
}
