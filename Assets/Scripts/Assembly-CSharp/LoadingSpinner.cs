using UnityEngine;
using UnityEngine.UI;

public class LoadingSpinner : MonoBehaviour
{
	[SerializeField]
	private Image image;
	[SerializeField]
	private float displayDelay;
	[SerializeField]
	private float fadeDuration;
	[SerializeField]
	private float fadeAmount;
	[SerializeField]
	private float fadeVariance;
	[SerializeField]
	private float fadePulseDuration;
	[SerializeField]
	private Sprite[] sprites;
	[SerializeField]
	private float frameRate;
}
