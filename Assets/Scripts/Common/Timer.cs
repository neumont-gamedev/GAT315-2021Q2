using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Timer
{
    // fps
    public static float dt;
    public static float fps;
    // fps frame count
    public static int frame = 0;
    public static int frameMax = 100;
    public static float fpsTime = 0;
    // fps smoothing
    public static float fpsAverage = 0;
    public static float smoothing = 0.975f;

    public static void Update()
	{
        dt = Time.deltaTime;

        // fps (current)
        //fps = (1.0f / Time.deltaTime);
        //fpsAverage = (fpsAverage * smoothing) + (fps * (1.0f - smoothing));

        // fps (frame count)
        frame++;
        fpsTime = fpsTime + dt;
        if (frame == frameMax)
        {
            fps = frameMax / fpsTime;
            frame = 0;
            fpsTime = 0;
        }
    }
}
