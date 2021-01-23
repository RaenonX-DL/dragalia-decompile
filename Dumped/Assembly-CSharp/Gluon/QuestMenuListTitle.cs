/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestMenuListTitle : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject rootObj;
		[SerializeField]
		private GameObject questDifficultyIconRoot;
		[SerializeField]
		private UiImageExchanger questDifficultyBg;
		[SerializeField]
		private Image landmarkIconImage;
		[SerializeField]
		private RectTransform _landmarkStartTrans;
		[SerializeField]
		private UnityEngine.UI.Text listTitle;
		[SerializeField]
		private UiTextColorExchanger uiTextClolor;
		private GameObject questDifficultyIconObj;
		[CompilerGenerated]
		private bool _isCloseCompleted_k__BackingField;
	
		// Properties
		public bool isCloseCompleted { [CompilerGenerated] get; [CompilerGenerated] set; }
		public RectTransform landmarkStartTrans { get; set; }
	
		// Constructors
		public QuestMenuListTitle();
	
		// Methods
		private void Start();
		public void SetLandmarkIcon(QuestMainLocationElement qmle);
		public void SetLandmarkIcon(QuestMainLocationElement qmle, Vector3 initialPos);
		public void SetDifficulty(QuestSelectScene.Difficulty difficulty);
		public void SetListTitle(QuestMainLocationElement qmle);
		public virtual void OnOpen();
		private void SetLandmarkIconAlpha(float alpha);
		protected virtual void Open();
		public virtual void OnClose();
		protected virtual void Close();
		public void OnCloseCompleted();
		public void Enable(bool enable);
		private void EnableRootObj(bool enable);
		[CompilerGenerated]
		private void _Open_b__22_0();
		[CompilerGenerated]
		private void _Close_b__24_0();
	}
}
