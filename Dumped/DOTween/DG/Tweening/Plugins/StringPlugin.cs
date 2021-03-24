/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using DG.Tweening;
using DG.Tweening.Core;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Plugins
{
	public class StringPlugin : ABSTweenPlugin<string, string, StringOptions>
	{
		// Fields
		private static readonly StringBuilder _Buffer;
		private static readonly List<char> _OpenedTags;
	
		// Constructors
		public StringPlugin();
		static StringPlugin();
	
		// Methods
		public override void SetFrom(TweenerCore<string, string, StringOptions> t, bool isRelative);
		public override void Reset(TweenerCore<string, string, StringOptions> t);
		public override string ConvertToStartValue(TweenerCore<string, string, StringOptions> t, string value);
		public override void SetRelativeEndValue(TweenerCore<string, string, StringOptions> t);
		public override void SetChangeValue(TweenerCore<string, string, StringOptions> t);
		public override float GetSpeedBasedDuration(StringOptions options, float unitsXSecond, string changeValue);
		public override void EvaluateAndApply(StringOptions options, Tween t, bool isRelative, DOGetter<string> getter, DOSetter<string> setter, float elapsed, string startValue, string changeValue, float duration, bool usingInversePosition, UpdateNotice updateNotice);
		private StringBuilder Append(string value, int startIndex, int length, bool richTextEnabled);
		private char[] ScrambledCharsToUse(StringOptions options);
	}
}
