using Godot;
using System;

public class BootVideoPlayer : VideoPlayer
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
    public void OnIntroTimer() {
        var timer = GetNode("BootTimer") as Timer;
        timer.Start();
        Play();
        var videoplayer = GetViewport().GetParent().GetNode("CanvasLayer/IntroVideoPlayer") as VideoPlayer;
        videoplayer.Hide();
    }
}
