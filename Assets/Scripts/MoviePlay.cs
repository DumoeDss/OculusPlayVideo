using UnityEngine;
using System.Collections;

public class MoviePlay : MonoBehaviour {
    public MovieTexture movieTexture;
	void Start ()
    {
        //设置贴图
        GetComponent<Renderer>().material.mainTexture = movieTexture;
        //设置电影纹理播放模式为循环    
        movieTexture.loop = true;
        //添加AudioSource
        AudioSource mainCameraAudioSource = Camera.main.GetComponent(typeof(AudioSource)) as AudioSource;
        //获取视频的音频文件并为AudioSource的clip属性赋值  
        mainCameraAudioSource.clip = movieTexture.audioClip; 
        //开始播放  
        movieTexture.Play();
        mainCameraAudioSource.Play();  
	}
}
