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
	[RequireComponent]
	public class LocalizeTextLayoutAdjuster : MonoBehaviour
	{
		// Fields
		[Header]
		public float en_us_add_X;
		public float en_us_add_Y;
		public float zh_cn_add_X;
		public float zh_cn_add_Y;
		public float zh_tw_add_X;
		public float zh_tw_add_Y;
		[Header]
		public bool manualSpacing;
		[Header]
		public float ja_jp_manual_lineSpacing;
		public float en_us_manual_lineSpacing;
		public float zh_cn_manual_lineSpacing;
		public float zh_tw_manual_lineSpacing;
		public const float ja_jp_lineSpacing = 0.6f;
		public const float en_us_lineSpacing = 1.05f;
		public const float zh_cn_lineSpacing = 1.05f;
		public const float zh_tw_lineSpacing = 1.25f;
		private const float en_us_default_X = 0f;
		private const float en_us_default_Y = -2f;
		private const float zh_cn_default_X = 0f;
		private const float zh_cn_default_Y = 0f;
		private const float zh_tw_default_X = 0f;
		private const float zh_tw_default_Y = 0f;
	
		// Constructors
		public LocalizeTextLayoutAdjuster();
	
		// Methods
		private void Awake();
	}
}
