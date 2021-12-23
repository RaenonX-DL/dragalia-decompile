using UnityEngine.UI;

namespace Gluon
{
	public static class CommonTextUtil
	{
		public const string textTagElementOwner = "{element_owner}";

		public const string textTagWeaponTypeOwner = "{weapon_owner}";

		private const string fullSpaceChar = "\ufffd";

		private const string halfSpaceChar = " ";

		public static string GetElementalTypeName(ElementalType type)
		{
			return null;
		}

		public static string GetWeaponTypeName(WeaponType type)
		{
			return null;
		}

		public static string GetCharacterTypeName(UnitType type)
		{
			return null;
		}

		public static string GetAbilityName(AbilityConst.UnitType type, ElementalType unitElementType = ElementalType.NOELEMENT, WeaponType unitWeaponType = WeaponType.NONE, bool showLimit = true, int[] args)
		{
			return null;
		}

		public static string[] GetAbilityText(AbilityConst.UnitType type, ElementalType unitElementType = ElementalType.NOELEMENT, WeaponType unitWeaponType = WeaponType.NONE, int[] args)
		{
			return null;
		}

		public static string ToRomanNo(int arabicNo)
		{
			return null;
		}

		public static string GetMissionComment(int questId, QuestMissionCompleteType type, int param)
		{
			return null;
		}

		private static bool GetOverrideMissionCommentTemplate(int questId, QuestMissionCompleteType type, out string overrideTemplate)
		{
			return default(bool);
		}

		public static void OmitTextWithEllipsis(Text text, bool isSingleLineText = false)
		{
		}

		public static string OmitEnglishNumber(long number)
		{
			return null;
		}

		public static void ReduceTextSizeToFitAreaHeight(Text text)
		{
		}

		public static string RemoveRichTextTags(string text)
		{
			return null;
		}

		private static bool IsAcceptableCharacter(char input)
		{
			return default(bool);
		}

		private static string GetPattern()
		{
			return null;
		}

		public static string ConvertInvalidText(string inputText, bool isSurrogateCheckOnly = false)
		{
			return null;
		}

		public static string RemoveNewLine(string inputText, string convertTo = "")
		{
			return null;
		}

		public static string GetPresentReplaceText(MessageReplaceTextType type, int Id, out bool shouldRemoveNewLine)
		{
			return null;
		}

		public static bool IsCharASCII(char c)
		{
			return default(bool);
		}

		public static int GetNormalizedTextCount(string s)
		{
			return default(int);
		}

		public static string ConvertLineBreakSpaceAccordingToLanguageSetting(string text, bool withNewLineConversion = true)
		{
			return null;
		}

		public static string GenerateCountTextWithX(long num)
		{
			return null;
		}

		public static int GetStringCount(string str, string foundString)
		{
			return default(int);
		}
	}
}
