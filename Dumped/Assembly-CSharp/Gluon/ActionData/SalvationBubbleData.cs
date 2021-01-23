/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.ActionData
{
	[Serializable]
	public class SalvationBubbleData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private float _safeAreaRadius;
		[HideInInspector]
		[SerializeField]
		private string _effectName;
		[HideInInspector]
		[SerializeField]
		private string _controlKey;
		[HideInInspector]
		[SerializeField]
		private int[] _stateEffTrig;
		[HideInInspector]
		[SerializeField]
		private string[] _stateSeName;
	
		// Properties
		public float safeAreaRadius { get; }
		public string effectName { get; }
		public string controlKey { get; }
		public int[] stateEffTrig { get; }
		public string[] stateSeName { get; }
	
		// Nested types
		public enum BubbleState
		{
			Appear = 0,
			Dilation = 1,
			Revert = 2,
			Deflate = 3,
			NUM = 4
		}
	
		// Constructors
		public SalvationBubbleData();
	}
}
