﻿/*
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
	public class RaidEventTalkElement : IMasterElement
	{
		// Fields
		[SerializeField]
		private int _CharaId;
		[SerializeField]
		private int _Category0;
		[SerializeField]
		private int _Category1;
		[SerializeField]
		private string _TargetName;
		[SerializeField]
		private int _Value;
		[SerializeField]
		private string _TopCharaImage;
		[SerializeField]
		private float _TopCharaImageOffsetX;
		[SerializeField]
		private float _TopCharaImageOffsetY;
		[SerializeField]
		private float _TopCharaImageMoveOffset;
		[SerializeField]
		private float _TopCharaImageMoveOffsetY;
		[SerializeField]
		private string _Text;
		[SerializeField]
		private string _VoiceData;
	
		// Properties
		public int CharaId { get; }
		public int Category0 { get; }
		public int Category1 { get; }
		public string TargetName { get; }
		public int Value { get; }
		public string TopCharaImage { get; }
		public float TopCharaImageOffsetX { get; }
		public float TopCharaImageOffsetY { get; }
		public float TopCharaImageMoveOffset { get; }
		public float TopCharaImageMoveOffsetY { get; }
		public string Text { get; }
		public string VoiceData { get; }
	
		// Constructors
		public RaidEventTalkElement();
	}
}
