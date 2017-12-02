using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {

	public enum Difficulty 
	{
		Beginner = 1,
		Medium,
		Hard
	}

	private const string DIFFICULT_LEVEL = "DIFFICULT_LEVEL";
	private const string MUSIC_VOLUME = "MUSIC_VOLUME";
	private const string SOUND_VOLUME = "SOUND_VOLUME";

	// Use this for initialization
	void Start () {
		
	}

	public void setDiffultLevel(Difficulty level)
	{
		PlayerPrefs.SetInt (DIFFICULT_LEVEL, (int)level);
	}

	public int getDifficultLevel()
	{
		if (PlayerPrefs.HasKey (DIFFICULT_LEVEL))
		{
			return PlayerPrefs.GetInt (DIFFICULT_LEVEL);
		}
		return 0;
	}

	public void setMusicLevel(float level)
	{
		PlayerPrefs.SetFloat (MUSIC_VOLUME, level);
	}

	public float getMusicLevel()
	{
		if (PlayerPrefs.HasKey (MUSIC_VOLUME)) 
		{
			return PlayerPrefs.GetFloat(MUSIC_VOLUME);
		}
		return 0;
	}

	public void setSoundLevel(float level)
	{
		PlayerPrefs.SetFloat (SOUND_VOLUME);
	}

	public float getSoundLevel()
	{
		if (PlayerPrefs.HasKey (SOUND_VOLUME)) 
		{
			return PlayerPrefs.GetFloat (SOUND_VOLUME);
		}
		return 0;
	}
}
