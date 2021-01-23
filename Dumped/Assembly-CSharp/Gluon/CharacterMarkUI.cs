/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterMarkUI : MonoBehaviour
	{
		// Fields
		protected ObjectType objectType;
	
		// Nested types
		public enum ObjectType
		{
			Human = 0,
			Dragon = 1,
			Enemy = 2
		}
	
		public enum Type
		{
			None = 0,
			QuestHP = 1,
			Targeting = 2,
			UnTargeting = 3
		}
	
		// Constructors
		public CharacterMarkUI();
	
		// Methods
		public ObjectType GetObjectType();
		public virtual void Display(Type type, CharacterBase target = null);
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
