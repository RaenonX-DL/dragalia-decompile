/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterChangeEffect : FastUpdateMonoBehaviour
	{
		// Fields
		private CharacterSelector owner;
		private CharacterSelector target;
		private EffectObject effect;
		private Vector3 startPoint;
		private Vector3 relayPoint;
		private Vector3 endPoint;
		private float elapsedTime;
		private float durationTime;
	
		// Constructors
		public CharacterChangeEffect();
	
		// Methods
		public static CharacterChangeEffect Create(CharacterSelector src, CharacterSelector dst);
		public void Initialize(CharacterSelector src, CharacterSelector dst);
		public override void FastUpdate();
		private Vector3 CalcPoint(float step);
	}
}
