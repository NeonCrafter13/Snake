using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Segment
    {
        public Vector2d pos;

        private string[] texture = new string[5]{
            "%%%%%%%%%%",
            "%%%%%%%%%%",
            "%%%%%%%%%%",
            "%%%%%%%%%%",
            "%%%%%%%%%%"
        };

        public string[] GetTexture()
        {
            return texture;
        }
    }
}
