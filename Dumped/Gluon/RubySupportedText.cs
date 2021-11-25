using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class RubySupportedText : MonoBehaviour
	{
		public int textSize;

		public int rubyTextSize;

		public float textPatting;

		public bool isPreIn;

		[HideInInspector]
		public string nowSetText;

		private const string simpleTextPrefabPath = "Prefabs/OutGame/Common/Ruby/SimpleText";

		private const string rubyTextPrefabPath = "Prefabs/OutGame/Common/Ruby/AddRubyText";

		private const string textLinePrefabPath = "Prefabs/OutGame/Common/Ruby/LineLayout";

		private List<Text> allNormalText;

		private List<Text> allRubyText;

		private void Init()
		{
		}

		public void SetText(string text)
		{
		}

		public void SetTextColor(Color textColor, Color rubyColor)
		{
		}

		public void SetFadeText(float endValue, float duration, [Optional] UnityAction callBack)
		{
		}

		public void ClearText()
		{
		}
	}
}
