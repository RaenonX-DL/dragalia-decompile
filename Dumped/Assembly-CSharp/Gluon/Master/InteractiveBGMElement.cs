/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Master
{
	[Serializable]
	public class InteractiveBGMElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private string _CueName;
		[SerializeField]
		private int[] _BlockTimes;
		[SerializeField]
		private int[] _CallbackMarkerTimes;
		[SerializeField]
		private int[] _CallbackMarkerBitFlags;
		[SerializeField]
		private int _TransitionBlockId;
	
		// Properties
		public string CueName { get; }
		public int[] BlockTimes { get; }
		public int[] CallbackMarkerTimes { get; }
		public int[] CallbackMarkerBitFlags { get; }
		public int TransitionBlockId { get; }
	
		// Constructors
		public InteractiveBGMElement();
	}
}
