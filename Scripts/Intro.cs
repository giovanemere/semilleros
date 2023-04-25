using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Intro : MonoBehaviour
{
    public VideoPlayer video;
    RawImage video1;
    private void Awake()
    {
        video = GetComponent<VideoPlayer>();
        video1 = this.GetComponent<RawImage>();
        video1.color = new Vector4(video1.color.r, video1.color.g, video1.color.b, 1);
        video.Play();
        video.loopPointReached += CheckOver;
    }



    public void ReproducirVideo()
    {



    }
    void CheckOver(VideoPlayer vp)
    {
        SceneManager.LoadScene("Finances");
    }



}
