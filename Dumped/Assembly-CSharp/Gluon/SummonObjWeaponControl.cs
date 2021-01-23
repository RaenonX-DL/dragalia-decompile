/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonObjWeaponControl : MonoBehaviour
	{
		// Fields
		public Transform axe;
		public Transform bow;
		public Transform cane;
		public Transform dagger;
		public Transform katana;
		public Transform rod;
		public Transform lance;
		public Transform stone;
		public Transform sword;
		public Transform gun;
		public Animator anim;
	
		// Constructors
		public SummonObjWeaponControl();
	
		// Methods
		public Transform GetTransform(SummonStageUtil.SummonWeaponCategory weaponType);
	}
}
