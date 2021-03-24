/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class EmotionData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private NotifyCharacter.EmotionType _emotion;
	
		// Properties
		public NotifyCharacter.EmotionType emotion { get; }
	
		// Constructors
		public EmotionData();
	}
}
