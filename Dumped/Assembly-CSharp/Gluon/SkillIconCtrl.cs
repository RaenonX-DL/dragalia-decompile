/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SkillIconCtrl : FastUpdateMonoBehaviour
	{
		// Fields
		private const float addVolumeSpeedTime = 0.1f;
		private float _addStartTime;
		private float _goalVolume;
		private float _startVolume;
		private float _currVolume;
		private bool _isUpdate;
		private SpriteRenderer _image;
		private bool _isLeftFlag;
	
		// Constructors
		public SkillIconCtrl();
	
		// Methods
		public void Initialize(bool isLeft);
		public void SetImage(SpriteRenderer image);
		public bool IsChanging();
		private void SetShaderParameter(float volume);
		public void SetValue(float gaugeValue, bool isForce);
		public override void FastUpdate();
	}
}
