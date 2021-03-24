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
	[Serializable]
	public class NavigateNPCData : ActionParts.PartsData
	{
		// Fields
		[HideInInspector]
		[SerializeField]
		private int _talkId;
		[HideInInspector]
		[SerializeField]
		private bool _isLeftIcon;
		[HideInInspector]
		[SerializeField]
		private bool _isOneTime;
		public const int TALKER_NUM = 10;
		[HideInInspector]
		[SerializeField]
		private int[] _talkers;
	
		// Properties
		public int talk { get; }
		public bool isLeftIcon { get; }
		public bool isOneTime { get; }
		public int[] talkers { get; }
	
		// Constructors
		public NavigateNPCData();
	}
}
