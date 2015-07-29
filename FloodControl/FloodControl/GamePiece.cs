using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

namespace Flood_Control
{
    public class GamePiece
    {
        // Constructors (1 Overload)
        public GamePiece(string type, string suffix)
        {
            pieceType = type;
            pieceSuffix = suffix;
        }
        public GamePiece(string type)
        {
            pieceType = type;
            pieceSuffix = "";
        }

        public static string[] PieceTypes = 
        {
            "Left,Right",
            "Top,Bottom",
            "Left,Top",
            "Top,Right",
            "Right,Bottom",
            "Bottom,Left",
            "Empty"
        };

        // Constants
        public const int pieceHeight = 40, pieceWidth = 40;
        public const int MaxPlayablePieceIndex = 5, EmptyPieceIndex = 6;
        private const int textureOffsetX = 1, textureOffsetY = 1;
        private const int texturePaddingX = 1, texturePaddingY = 1;

        // Private Properties
        private string pieceType = "", pieceSuffix = "";

        // Public Properties
        public string PieceType
        {
            get { return pieceType; }
        }
        public string Suffix
        {
            get { return pieceSuffix; }
        }

        // Public Methods
        public void SetPiece(string type, string suffix)
        {
            pieceType = type;
            pieceSuffix = suffix;
        }
        public void SetPiece(string type)
        {
            SetPiece(type, "");
        }
        public void AddSuffix(string suffix)
        {
            if (!pieceSuffix.Contains(suffix))
            {
                pieceSuffix += suffix;
            }
        }
        public void RemoveSuffix(string suffix)
        {
            pieceSuffix = pieceSuffix.Replace(suffix, "");
        }
        public void RotatePiece(bool clockwise)
        {
            switch (pieceType)
            {
                case "Left,Right":
                    pieceType = "Top,Bottom";
                    break;
                case "Top,Bottom":
                    pieceType = "Left,Right";
                    break;
                case "Left,Top":
                    if (clockwise)
                        pieceType = "Top,Right";
                    else
                        pieceType = "Bottom,Left";
                    break;
                case "Top,Right":
                    if (clockwise)
                        pieceType = "Right,Bottom";
                    else
                        pieceType = "Left,Top";
                    break;
                case "Right,Bottom":
                    if (clockwise)
                        pieceType = "Bottom,Left";
                    else
                        pieceType = "Top,Right";
                    break;
                case "Bottom,Left":
                    if (clockwise)
                        pieceType = "Left,Top";
                    else
                        pieceType = "Right,Bottom";
                    break;
                case "Empty":
                    break;

            }
        }

        public string[] GetOtherEnds(string startingEnd)
        {
            List<string> opposites = new List<string>();

            foreach (string end in pieceType.Split(','))
            {
                if (end != startingEnd)
                {
                    opposites.Add(end);
                }
            }
            return opposites.ToArray();
        }

        public bool HasConnector(string direction)
        {
            return pieceType.Contains(direction);
        }

        public Rectangle GetSourceRect()
        {
            int x = textureOffsetX;
            int y = textureOffsetY;

            if (pieceSuffix.Contains("W"))
            {
                x += pieceWidth + texturePaddingX;
            }
            y += (Array.IndexOf(PieceTypes, pieceType) * (pieceHeight + texturePaddingY));

            return new Rectangle(x, y, pieceWidth, pieceHeight);

        }
    }
}
