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
	public class DollFieldUniqueCtrl : EnemyUniqueCtrl
	{
		// Fields
		private const string effKey = "effkey_DollField";
		private float _timer;
		private bool _hasPlayEff;
	
		// Constructors
		public DollFieldUniqueCtrl();
	
		// Methods
		public override void FastUpdate();
		public void PlayEffect(string effName, float duration, Vector2 center, float scale, string seName);
	}
}
