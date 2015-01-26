﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WhatDoWeDoNow
{
    public class LevelCollideWithGuy : Level
    {
        public LevelCollideWithGuy() : base()
        {

        }

        public override void Update(Microsoft.Xna.Framework.GameTime gameTime)
        {
            //check if the player arrived at the guy // collided it
            if (TheGame.Instance.getPlayer().getCollisionRectangle().Intersects(TheGame.Instance.guy.getHeadCollisionRectangle()))
            {
                markAsComplete();
            }
        }
    }
}
