﻿/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.PostEffectParams;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonPostEffectTypeSetting : SummonPostEffectSettingsBase
	{
		// Fields
		[SerializeField]
		public Setting[] shot0102SettingList;
		public Setting[] shot03SettingList;
		private bool isFirstDeserialization0102;
		private int settingArrayLength0102;
		private bool isFirstDeserialization03;
		private int settingArrayLength03;
	
		// Nested types
		[Serializable]
		public class Setting : SummonPostEffectSettingsBase.SettingBase
		{
			// Fields
			public FilterType filterType;
			public bool isEnableDof;
	
			// Constructors
			public Setting();
	
			// Methods
			public Setting MakeClone();
		}
	
		// Constructors
		public SummonPostEffectTypeSetting();
	
		// Methods
		protected override SettingBase[] GetShot0102SettingListBase();
		protected override SettingBase[] GetShot03SettingListBase();
		protected void OnValidate();
		protected void ValidateList(Setting[] settingList, ref bool isFirstDeserialization, ref int settingArrayLength);
		public override void ApplyToPostEffect(SettingBase settingBase);
	}
}
