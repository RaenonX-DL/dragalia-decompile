using System;
using UnityEngine;

namespace Gluon
{
	public static class SimpleCharacterUtils
	{
		public enum AnimatorType
		{
			Party,
			QuestPrepare,
			Mypage,
			Summon,
			Fort
		}

		public static string GetMypageAnimationFileName(int charaId)
		{
			return null;
		}

		public static string GetMypageAnimationFileNameSpecial(int charaId)
		{
			return null;
		}

		public static void LoadMypageCharacterAnimation(int charaId, bool isSyncLoad, Action<UnityEngine.Object> onLoaded)
		{
		}

		public static void LoadAsyncPartyAnimation(Action<UnityEngine.Object> onLoaded, bool isQuestAnimation, int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1)
		{
		}

		public static RuntimeAnimatorController LoadPartyAnimation(bool isQuestAnimation, int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1)
		{
			return null;
		}

		public static string GetPartyAnimationFileNameCommon(int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1)
		{
			return null;
		}

		public static string GetPartyAnimationFileNameSpecial(int charaId, WeaponType weaponType = WeaponType.NONE, int motionType = -1)
		{
			return null;
		}

		private static string GetPartAnimationFilenamePrefix(WeaponType weaponType)
		{
			return null;
		}

		public static string GetFortCharaAnimationFileName(int charaId, int personMotionType)
		{
			return null;
		}

		public static string GetFortCharaAnimationFileNameSpecial(int charaId)
		{
			return null;
		}

		public static string GetSummonCharaAnimationPath(int charaId, string baseFileName)
		{
			return null;
		}

		public static string GetSummonCharaAnimationPathSpecial(int charaId, string baseFileName)
		{
			return null;
		}

		public static void LoadOverrideMotionStateList(CharacterAnimatedAttachment attachment, AnimatorType animatorType)
		{
		}
	}
}
