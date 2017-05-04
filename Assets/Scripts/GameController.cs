using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	private CameraMover camMover;
	public GameObject ship;

	//Audio
	public AudioSource menuMusic;
	public AudioSource shipMusic;
	public AudioSource enemyMusic1;

	public float aimMenuMusicVolume;
	public float musicFadeSpeed;

	void Start()
	{
		camMover = GetComponent<CameraMover>();
	}

	void Update()
	{
		if( menuMusic.volume != aimMenuMusicVolume)
		{
			menuMusic.volume = Mathf.Lerp(menuMusic.volume, aimMenuMusicVolume, musicFadeSpeed * Time.deltaTime);
		}
	}

	public void StartGame()
	{
		camMover.MoveToPosition(new Vector3(0, 0, -10), 5, 1);
		FadeMusic();
		ship.GetComponent<Ctrl>().enabled = true;
	}

	private void FadeMusic()
	{
		shipMusic.Play();
		enemyMusic1.Play ();
		aimMenuMusicVolume = 0;
	}
}