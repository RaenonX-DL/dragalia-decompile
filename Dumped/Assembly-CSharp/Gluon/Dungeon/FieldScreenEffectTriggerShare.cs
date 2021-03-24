/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class FieldScreenEffectTriggerShare : FieldScreenEffectTrigger
	{
		// Fields
		private static float shareEffectAlpha;
		protected static Coroutine shareProgressCoroutine;
		protected static FieldScreenEffectTrigger shareLastCoroutineStarter;
	
		// Properties
		protected override float effectAlpha { get; set; }
		protected override Coroutine progressCoroutine { get; set; }
		protected override FieldScreenEffectTrigger lastCoroutineStarter { get; set; }
	
		// Constructors
		public FieldScreenEffectTriggerShare();
		static FieldScreenEffectTriggerShare();
	}
}
