
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace r_dailyprogrammer
{
    class KeyTable
    {
        public static string cRange = "#_23456789abcdefghijklmnopqrstuvwxyz";
        public char[,] Table { get; set; }

        public void Populate (string key)
        {
            Table = new char[6, 6];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Table[i, j] = key[(i * 6 + j)];
                }
            }
        }

        public void Permute(char[,] cKey, Marker pText, Marker cText, Marker cMarker)
        {
            char pTextTemp = cKey[pText.PosY, 5];
            int markerVecX = cRange.IndexOf(cText.Text) % 6;
            int markerVecY = cRange.IndexOf(cText.Text) / 6;

            for (int i = 5; i > 0; i--)
            {
                cKey[pText.PosY, i] = cKey[pText.PosY, i - 1];
            }
            cKey[pText.PosY, 0] = pTextTemp;

            cMarker.Update();
            cText.Update();

            char cTextTemp = cKey[5, cText.PosX];

            for (int i = 5; i > 0; i--)
            {
                cKey[i, cText.PosX] = cKey[i - 1, cText.PosX];
            }
            cKey[0, cText.PosX] = cTextTemp;

            cMarker.Update();
            cText.Update();

            cMarker.MovePos(markerVecX, markerVecY);
        }
    }
}
*/