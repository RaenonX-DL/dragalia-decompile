/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FirstCharaSelectController : TableViewController<Gluon.FirstCharaSelectData>
	{
		// Fields
		[SerializeField]
		private AnimationListOneCol listAnimation;
	
		// Constructors
		public FirstCharaSelectController();
	
		// Methods
		public void LoadData(List<FirstCharaSelectData> data, Action<int> onClick);
	}
}
