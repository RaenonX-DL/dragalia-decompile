/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public static class CommonTextUtil
	{
		// Fields
		public const string textTagElementOwner = "{element_owner}";
		private const string fullSpaceChar = "\uFFFD";
		private const string halfSpaceChar = " ";
	
		// Methods
		public static string GetElementalTypeName(ElementalType type);
		public static string GetWeaponTypeName(WeaponType type);
		public static string GetCharacterTypeName(UnitType type);
		public static string GetAbilityName(AbilityConst.UnitType type, ElementalType unitElementType = ElementalType.NOELEMENT, bool showLimit = true, params int[] args);
		public static string[] GetAbilityText(AbilityConst.UnitType type, ElementalType unitElementType = ElementalType.NOELEMENT, params int[] args);
		public static string ToRomanNo(int arabicNo);
		public static string GetMissionComment(QuestMissionCompleteType type, int param);
		public static void OmitTextWithEllipsis(UnityEngine.UI.Text text, bool isSingleLineText = false);
		public static void ReduceTextSizeToFitAreaHeight(UnityEngine.UI.Text text);
		public static string RemoveRichTextTags(string text);
		private static bool IsAcceptableCharacter(char input);
		private static string GetPattern();
		public static string ConvertInvalidText(string inputText, bool isSurrogateCheckOnly = false);
		public static string RemoveNewLine(string inputText, string convertTo = "");
		public static string GetPresentReplaceText(MessageReplaceTextType type, int Id, out bool shouldRemoveNewLine);
		public static bool IsCharASCII(char c);
		public static int GetNormalizedTextCount(string s);
		public static string ConvertLineBreakSpaceAccordingToLanguageSetting(string text, bool withNewLineConversion = true);
		public static string GenerateCountTextWithX(long num);
		public static int GetStringCount(string str, string foundString);
	}
}
