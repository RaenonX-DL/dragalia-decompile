/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterMarkUI : MonoBehaviour
	{
		// Nested types
		public enum DisplayType
		{
			None = 0,
			QuestHP = 1,
			Targeting = 2,
			UnTargeting = 3
		}
	
		// Constructors
		public CharacterMarkUI();
	
		// Methods
		public virtual void Show(DisplayType type, CharacterBase target = null);
		protected Vector2 GetScreenPos(Vector3 pos);
		public virtual void SetPlayerNo(int no, bool own);
		public virtual void SetVisible(bool visible);
		public virtual bool IsVisible();
		public virtual void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public virtual void ShowCircleGaugeUI();
		public virtual void HideCircleGaugeUI();
		public virtual void SetCircleGaugeUIGaugeTimer(float remainTime, float durationTime);
		public virtual void SetCircleGaugeUICount(int count);
		public virtual void SetCircleGaugeUIAdjustPos(Vector3 pos);
		public virtual void SetCircleGaugeUIAdjustScale(float scale);
	}
}
