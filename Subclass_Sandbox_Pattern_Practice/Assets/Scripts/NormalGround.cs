using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalGround : Grounds
{
    string clip;
    float speed;
    string particle;
    public NormalGround(string clip, float speed, string particle)
    {
        this.clip = clip;
        this.speed = speed;
        this.particle = particle;
    }
    public override void Activate()
    {
        PlaySound(clip);
        Move(speed);
        SpawnParticles(particle);
    }
}
