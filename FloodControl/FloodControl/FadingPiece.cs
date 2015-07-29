using Flood_Control;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FloodControl
{
    public class FadingPiece :GamePiece
    {
        public float alphaLevel = 1.0f;
        public static float alphaChangeRate = 0.02f;

        public FadingPiece(string pieceType, string suffix)
            : base(pieceType)
        {
        }

        public void UpdatePiece()
        {
            alphaLevel = MathHelper.Max(0, alphaLevel - alphaChangeRate);
        }
    }
}
