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
		// Fields
		protected bool isVisible;
	
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
		public virtual void UpdatePosition(bool interpolation = true);
		protected Vector2 GetScreenPos(Vector3 pos);
		public virtual void SetPlayerNo(int no, bool own);
		public virtual void SetVisible(bool visible);
		public virtual bool IsVisible();
		public virtual void CreateCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public virtual void ShowCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public virtual void HideCircleGaugeUI(CharaCircleGaugeUI.Type type);
		public virtual void SetCircleGaugeUIGaugeTimer(CharaCircleGaugeUI.Type type, float time, float initialTime);
		public virtual void SetCircleGaugeUICount(CharaCircleGaugeUI.Type type, int count);
		public virtual void SetCircleGaugeUIAdjustPos(CharaCircleGaugeUI.Type type, Vector3 pos);
		public virtual void SetCircleGaugeUIAdjustScale(CharaCircleGaugeUI.Type type, float scale);
		protected bool CheckVisible();
		public virtual void OnUpdateHpGaugeShineGaugeFade(float value);
		public virtual void OnUpdateHpGaugeShineLocalPosX(float value);
	}
}
