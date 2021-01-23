/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace FLATOUT.Main
{
	public class FlGlobalData : ScriptableObject
	{
		// Fields
		[SerializeField]
		private string _unityVersion;
		[SerializeField]
		private string _localizeTarget;
		[SerializeField]
		private List<FlFontParameter> _fontParameterList;
		[SerializeField]
		private List<FlFontIconParameter> _fontIconParameterList;
		[SerializeField]
		private float _baseScreenWidth;
		[SerializeField]
		private int _textSortOderRoundValue;
		[SerializeField]
		private int _stencilMaskOffset;
		[SerializeField]
		private int _stencilMaskInterval;
		[SerializeField]
		private float _defaultLongTouchTime;
		[SerializeField]
		private float _scrollStartPixel;
		[SerializeField]
		private float _scrollSpeedValue;
		[SerializeField]
		private float _scrollAccelValue;
		[SerializeField]
		private float _scrollIncrementValue;
		[SerializeField]
		private float _keyInputChangeStartDelayTime;
		[SerializeField]
		private float _keyInputChangeDelayTime;
		[SerializeField]
		private float _rayInputSubmitDelay;
		[SerializeField]
		private List<FlPlayerSetting> _playerSettingList;
		private string _banPrefixChar;
		private string _banSuffixChar;
		private string _joinChar;
		public Hashtable _fontTable;
		public Hashtable _fontIconParameterTable;
		private Hashtable _fontLocalizeParamTable;
		private Font _defaultFont;
		private Hashtable _banPrefixCharTable;
		private Hashtable _banSuffixCharTable;
		private Hashtable _joinCharTable;
	
		// Properties
		public string UnityVersion { get; set; }
		public string LocalizeTarget { get; set; }
		public List<FlFontParameter> FontParameterList { get; }
		public List<FlFontIconParameter> FontIconParameterList { get; }
		public float BaseScreenWidth { get; }
		public float ScrollStartPixel { get; }
		public float ScrollSpeedValue { get; }
		public float ScrollAccelValue { get; }
		public float ScrollIncrementValue { get; }
		public float DefaultLongTouchTime { get; }
		public float KeyInputChangeStartDelayTime { get; }
		public float KeyInputChangeDelayTime { get; }
		public float RayInputSubmitDelay { get; }
		public int TextSortOderRoundValue { get; }
		public int StencilMaskOffset { get; }
		public int StencilMaskInterval { get; }
		public List<FlPlayerSetting> PlayerSettingList { get; }
	
		// Constructors
		public FlGlobalData();
	
		// Methods
		public void _Initialize();
		private void _CreateTable();
		public void ReloadLocalizeTarget();
		private void _CreateCharTable();
		public void _SetLocalizeTarget(string localizeTarget);
		public Font _GetFont(string fontName);
		public FlFontIconParameter _GetFontIconParameter(string fontIconName);
		public FlFontLocalizeParameter _GetFontLocalizeParam(string fontName);
		public bool _IsBanPrefixChar(char target);
		public bool _IsBanSuffixChar(char target);
		public bool _IsJoinChar(char target);
		public FlPlayerSetting _GetPlayerSetting(int playerIndex);
	}
}
