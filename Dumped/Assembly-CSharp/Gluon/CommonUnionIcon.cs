/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CommonUnionIcon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Graphic unionIcon;
	
		// Constructors
		public CommonUnionIcon();
	
		// Methods
		private void Awake();
		public void SetUnionByCrestId(int crestId, IconLoader.Size size = IconLoader.Size.S);
		public void SetUnionByUnionGroupId(int unionGroupId, IconLoader.Size size = IconLoader.Size.S);
	}
}
