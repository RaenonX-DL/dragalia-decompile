using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace FLATOUT.Main
{
	public class FlGlobalData : ScriptableObject
	{
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

		public string UnityVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string LocalizeTarget
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public List<FlFontParameter> FontParameterList => null;

		public List<FlFontIconParameter> FontIconParameterList => null;

		public float BaseScreenWidth => default(float);

		public float ScrollStartPixel => default(float);

		public float ScrollSpeedValue => default(float);

		public float ScrollAccelValue => default(float);

		public float ScrollIncrementValue => default(float);

		public float DefaultLongTouchTime => default(float);

		public float KeyInputChangeStartDelayTime => default(float);

		public float KeyInputChangeDelayTime => default(float);

		public float RayInputSubmitDelay => default(float);

		public int TextSortOderRoundValue => default(int);

		public int StencilMaskOffset => default(int);

		public int StencilMaskInterval => default(int);

		public List<FlPlayerSetting> PlayerSettingList => null;

		public void _Initialize()
		{
		}

		private void _CreateTable()
		{
		}

		public void ReloadLocalizeTarget()
		{
		}

		private void _CreateCharTable()
		{
		}

		public void _SetLocalizeTarget(string localizeTarget)
		{
		}

		public Font _GetFont(string fontName)
		{
			return null;
		}

		public FlFontIconParameter _GetFontIconParameter(string fontIconName)
		{
			return null;
		}

		public FlFontLocalizeParameter _GetFontLocalizeParam(string fontName)
		{
			return null;
		}

		public bool _IsBanPrefixChar(char target)
		{
			return default(bool);
		}

		public bool _IsBanSuffixChar(char target)
		{
			return default(bool);
		}

		public bool _IsJoinChar(char target)
		{
			return default(bool);
		}

		public FlPlayerSetting _GetPlayerSetting(int playerIndex)
		{
			return null;
		}
	}
}
