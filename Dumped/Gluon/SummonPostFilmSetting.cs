using System;
using Gluon.PostEffectParams;
using UnityEngine;

namespace Gluon
{
	public class SummonPostFilmSetting : SummonPostEffectSettingsBase
	{
		[Serializable]
		public class Setting : SettingBase
		{
			public PostFilmMode postFilmMode;

			public float postFilmPower;

			public Vector2 postFilmOffsetParam;

			public float vignetteIntensity;

			public float vignetteDecrement;

			public Color postFilmColor0;

			public Color postFilmColor1;

			public Color postFilmColor2;

			public Color postFilmColor3;

			public Setting MakeClone()
			{
				return null;
			}
		}

		[SerializeField]
		public Setting[] shot0102SettingList;

		public Setting[] shot03SettingList;

		private bool isFirstDeserialization0102;

		private int settingArrayLength0102;

		private bool isFirstDeserialization03;

		private int settingArrayLength03;

		protected override SettingBase[] GetShot0102SettingListBase()
		{
			return null;
		}

		protected override SettingBase[] GetShot03SettingListBase()
		{
			return null;
		}

		protected void OnValidate()
		{
		}

		protected void ValidateList(Setting[] settingList, ref bool isFirstDeserialization, ref int settingArrayLength)
		{
		}

		public override void ApplyToPostEffect(SettingBase settingBase)
		{
		}
	}
}
