using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    void Start()
    {
        MusicPlayer musicPlayer = new MusicPlayer(new Play());
        musicPlayer.Request();
        musicPlayer.Request();
    }
}
public class MusicPlayer
{
    private IState state;

    public MusicPlayer(IState newstate)
    {
        state = newstate;
    }

    public void Request()
    {
        state.Handle(this);
    }

    public IState State
    {
        get { return state; }
        set { state = value; }
    }
}


public interface IState
{
    void Handle(MusicPlayer musicPlayer);
}


public class Play : IState
{
    public void Handle(MusicPlayer musicPlayer)
    {
        Debug.Log("Playing...");
        musicPlayer.State = new Stop();
    }
}

public class Stop : IState
{
    public void Handle(MusicPlayer musicPlayer)
    {
        Debug.Log("Stopped!");
        musicPlayer.State = new Play();
    }
} 