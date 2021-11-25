using System;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class UVAnimation : FastUpdateMonoBehaviour
	{
		[Serializable]
		public struct FrameWaitInfo
		{
			public int frame;

			public float waitTime;
		}

		[Serializable]
		public struct LoopInfo
		{
			public bool loop;

			public int startFrame;

			public int endFrame;

			public int loopNum;
		}

		[Serializable]
		public struct InterruptionInfo
		{
			[SerializeField]
			[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082\u0092ä\u00b8­æ\u0096­ã\u0081\u0099ã\u0082\u008bã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ï¼\u00880ã\u0081ªã\u0082\u0089ç\u0084¡ã\u0081\u0097ï¼\u0089")]
			public int interruptionFrame;

			[SerializeField]
			[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081®ä\u00b8­æ\u0096­æ\u0099\u0082é\u0096\u0093(ç§\u0092)")]
			public float delay;

			[SerializeField]
			[Header("ä\u00b8­æ\u0096­æ\u0099\u0082é\u0096\u0093ã\u0082\u0092ã\u0083©ã\u0083³ã\u0083\u0080ã\u0083\u00a0ã\u0081«è¿½å\u008a\u00a0ã\u0081\u0099ã\u0082\u008b(ç§\u0092)")]
			public float delayRandom;

			[NonSerialized]
			public float totalDelay;
		}

		[SerializeField]
		[Header("W, H: ä\u00b8\u0080ã\u0081¤ã\u0082¤ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0081®size â\u0080»X, Y ã\u0081\u00afå\u0085¥å\u008a\u009bä\u00b8\u008dè¦\u0081ï¼\u0088å\u0087¦ç\u0090\u0086å\u0081\u00b4ã\u0081§è\u0087ªå\u008b\u0095æ\u009b\u00b4æ\u0096°ï¼\u0089")]
		public Rect rect;

		[SerializeField]
		[Header("Xï¼\u009aå¹\u0085 Y:é«\u0098ã\u0081\u0095æ\u0096¹å\u0090\u0091ã\u0081®ã\u0083\u009eã\u0083¼ã\u0082\u00b8ã\u0083³")]
		private Vector2 marginSize;

		[SerializeField]
		[Header("ç\u0094»å\u0083\u008fã\u0081®æ\u0095°")]
		private int imageCount;

		[SerializeField]
		[Header("ã\u0083\u0086ã\u0082\u00afã\u0082¹ã\u0083\u0081ã\u0083£ã\u0081®Tilingã\u0081«è\u00a8­å®\u009aå\u0080¤ã\u0082\u0092å\u008f\u008dæ\u0098\u00a0ã\u0081\u0099ã\u0082\u008bã\u0081\u008bï¼\u009f")]
		private bool modifyTextureTiling;

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081®é\u0080\u009fåº¦, 1ã\u0081\u00afæ­£å\u00b8\u00b8é\u0080\u009fåº¦")]
		private float speed;

		private float speedInverse;

		[SerializeField]
		[Header("æ\u008c\u0087å®\u009aã\u0081\u0097ã\u0081\u009fã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0å¾\u008cã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093(ç§\u0092)")]
		private FrameWaitInfo[] frameWaitInfoArray;

		[SerializeField]
		[Header("æ\u008c\u0087å®\u009aã\u0081\u0097ã\u0081\u009fã\u0083\u0095ã\u0083¬ã\u0083¼ã\u0083\u00a0ç\u00af\u0084å\u009b²ã\u0081®ã\u0083«ã\u0083¼ã\u0083\u0097è\u00a8­å®\u009a")]
		private LoopInfo loopInfo;

		[SerializeField]
		[Header("ä\u00b8\u0080å\u009b\u009eã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081\u0097ã\u0081\u009få¾\u008cã\u0081®å»¶æ\u009c\u009fæ\u0099\u0082é\u0096\u0093(ç§\u0092)")]
		private float delay;

		[SerializeField]
		[Header("é\u0081\u0085å»¶æ\u0099\u0082é\u0096\u0093ã\u0082\u0092ã\u0083©ã\u0083³ã\u0083\u0080ã\u0083\u00a0ã\u0081«è¿½å\u008a\u00a0ã\u0081\u0099ã\u0082\u008b(ç§\u0092)")]
		private float delayRandom;

		private float totalDelay;

		[SerializeField]
		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ä\u00b8­æ\u0096­æ\u0083\u0085å\u00a0±")]
		private InterruptionInfo[] interruptionInfo;

		[SerializeField]
		[Tooltip("Shared Materialã\u0082\u0092ä½¿ã\u0081\u0086å\u00a0\u00b4å\u0090\u0088ã\u0081\u00afã\u0080\u0081\nå\u0085±æ\u009c\u0089ã\u0081\u0099ã\u0082\u008bã\u0083\u009eã\u0083\u0086ã\u0083ªã\u0082¢ã\u0083«ã\u0082\u0092ä½¿ã\u0081£ã\u0081¦ã\u0081\u0084ã\u0082\u008bRendererã\u0082\u0089ã\u0081®\nè¦ªã\u0081®GameObjectã\u0081«ã\u0081\u0093ã\u0081®ã\u0082³ã\u0083³ã\u0083\u009dã\u0083¼ã\u0083\u008dã\u0083³ã\u0083\u0088ã\u0082\u0092ã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0083\u0081ã\u0081\u0097ã\u0081¦ã\u0081\u008fã\u0081\u00a0ã\u0081\u0095ã\u0081\u0084ã\u0080\u0082")]
		private Material _sharedMaterial;

		[SerializeField]
		private bool isCreateAddtionalMeshForUV;

		private MeshRenderer orgMeshRenderer;

		private MeshFilter orgMeshFilter;

		private Mesh orgMesh;

		private Vector2[] addtionalUVs;

		private Mesh addtionalUvStream;

		private float duration;

		private float timeCount;

		private float delayTime;

		private Material _material;

		private int textureWidth;

		private int textureHeight;

		private int frame;

		private Vector2 mainTextureScale;

		private int remainingLoopNum;

		private float loopStartFrameX;

		private float loopStartFrameY;

		private float lastRowHeight;

		private bool hasAlphaTex;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void Scroll()
		{
		}
	}
}
