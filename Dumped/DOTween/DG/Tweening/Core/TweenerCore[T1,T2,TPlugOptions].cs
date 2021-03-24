/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using DG.Tweening.Core.Enums;
using DG.Tweening.Plugins.Core;
using DG.Tweening.Plugins.Options;

// Image 42: DOTween.dll - Assembly: DOTween, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null

namespace DG.Tweening.Core
{
	public class TweenerCore<T1, T2, TPlugOptions> : Tweener
		where TPlugOptions : struct, IPlugOptions
	{
		// Fields
		public T2 startValue;
		public T2 endValue;
		public T2 changeValue;
		public TPlugOptions plugOptions;
		public DOGetter<T1> getter;
		public DOSetter<T1> setter;
		internal ABSTweenPlugin<T1, T2, TPlugOptions> tweenPlugin;
		private const string _TxtCantChangeSequencedValues = "You cannot change the values of a tween contained inside a Sequence";
	
		// Constructors
		internal TweenerCore();
	
		// Methods
		public override Tweener ChangeStartValue(object newStartValue, float newDuration = -1f);
		public override Tweener ChangeEndValue(object newEndValue, bool snapStartValue);
		public override Tweener ChangeEndValue(object newEndValue, float newDuration = -1f, bool snapStartValue = false);
		public override Tweener ChangeValues(object newStartValue, object newEndValue, float newDuration = -1f);
		internal override Tweener SetFrom(bool relative);
		internal sealed override void Reset();
		internal override bool Validate();
		internal override float UpdateDelay(float elapsed);
		internal override bool Startup();
		internal override bool ApplyTween(float prevPosition, int prevCompletedLoops, int newCompletedSteps, bool useInversePosition, UpdateMode updateMode, UpdateNotice updateNotice);
	}
}
