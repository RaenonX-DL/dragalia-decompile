/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestElementFilter : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text elementLabelText;
		[SerializeField]
		private UnityEngine.UI.Text currentElementText;
		[SerializeField]
		private GameObject[] elementIconObjArray;
		[SerializeField]
		private GameObject checkIconObj;
		[SerializeField]
		private GameObject bgObj;
		private ElementalType _currentElement;
		private readonly float initialValueDuration;
		private readonly float preIntervalDuration;
		private readonly float moveBgCloseDuration;
		private readonly float bgInitialRelativeY;
	
		// Properties
		public ElementalType currentElement { get; private set; }
	
		// Constructors
		public QuestElementFilter();
	
		// Methods
		private void Start();
		public void SetFireElement();
		public void SetWaterElement();
		public void SetWindElement();
		public void SetLightElement();
		public void SetDarkElement();
		public void SetAllElement();
		private GameObject GetElementObj(int index);
		private GameObject GetElementObj(ElementalType type);
		public void SetCurrentElement(ElementalType type);
		private string GetElementText(ElementalType type);
		public void SetFavorableElement(int questId);
		private Sequence GetLocalMoveYSequence(GameObject targetObj, float targetY, Ease easeType, float duration, float preInterval = 0f, bool isRelative = true);
		private void JoinFadeSequence(Sequence seq, GameObject targetObj, float targetAlpha, Ease easeType, float duration, float preInterval = 0f);
		private void SetLocalPositionY(Transform trans, float valueY);
		private void SetAlpha(GameObject targetObj, float alpha);
		private void InitParts();
		public void OnOpen();
		public void OnClose();
	}
}
