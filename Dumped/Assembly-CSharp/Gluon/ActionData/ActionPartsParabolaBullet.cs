/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[AddComponentMenu]
	[HelpURL]
	public class ActionPartsParabolaBullet : ActionPartsBulletWithMarkerBase
	{
		// Fields
		[SerializeField]
		private ParabolaBulletData _data;
		public const float MAX_DURATION_AFTER_RUSH = 100f;
		public const float MAX_DROP_TIME = 100f;
	
		// Properties
		public override PartsData data { get; }
	
		// Constructors
		public ActionPartsParabolaBullet();
	}
}
