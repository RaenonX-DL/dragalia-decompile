using System;
using UnityEngine;

namespace Gluon
{
	public class SummonPostEffectSetting : SummonPostEffectSettingsBase
	{
		[Serializable]
		public class Setting : SettingBase
		{
			public bool enableDof;

			public float bloomDofWeight;

			public float bloomThreshhold;

			public float bloomIntensity;

			public float focalSize;

			public float dofMaxBlurSpread;

			public float dofFocalPoint;

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
