/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestCloud : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private RectTransform trans;
		[Header]
		[SerializeField]
		private float speed;
		[Header]
		[SerializeField]
		private enumCloudDirection direction;
		[Header]
		[SerializeField]
		private float maxWidth;
		[Header]
		[SerializeField]
		private float _maxHeight;
		[SerializeField]
		private Image cloudImage;
		[SerializeField]
		private Image shadowImage;
		private bool _isFade;
		private Vector3 rightOutPosition;
		private Vector3 leftOutPosition;
		private bool isPlayFlag;
		private const float radius = 0.5f;
	
		// Properties
		public RectTransform Trans { get; set; }
		public float Speed { get; set; }
		public enumCloudDirection Direction { get; set; }
		public float MaxWidth { get; set; }
		public float maxHeight { get; set; }
		public Image CloudImage { get; set; }
		public Image ShadowImage { get; set; }
		public bool isFade { get; set; }
	
		// Nested types
		public enum enumCloudDirection
		{
			left = 0,
			right = 1
		}
	
		// Constructors
		public QuestCloud();
	
		// Methods
		public void PlayCloud(Vector2 mapSize);
		public void StopCloud();
		private void Update();
		public void FadeOut();
		public void Fadein();
		[CompilerGenerated]
		private Color _FadeOut_b__40_0();
		[CompilerGenerated]
		private void _FadeOut_b__40_1(Color color);
		[CompilerGenerated]
		private Color _FadeOut_b__40_2();
		[CompilerGenerated]
		private void _FadeOut_b__40_3(Color color);
		[CompilerGenerated]
		private Color _Fadein_b__41_0();
		[CompilerGenerated]
		private void _Fadein_b__41_1(Color color);
		[CompilerGenerated]
		private Color _Fadein_b__41_2();
		[CompilerGenerated]
		private void _Fadein_b__41_3(Color color);
	}
}
