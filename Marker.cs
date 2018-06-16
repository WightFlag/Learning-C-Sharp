
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace r_dailyprogrammer
{
    class Marker
    {
        public char Text { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public int[] GetIndex(char[,] cKey, char pText)
        {
            int[] index = new int[2];

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (pText == cKey[i, j])
                    {
                        index[0] = i;
                        index[1] = j;
                        return index;
                    }
                }
            }
            return index;
        }

        public void MoveNeg(int vecX, int vecY)
        {
            this.PosX = this.PosX - vecX < 0 ? this.PosX - vecX + 6 : this.PosX - vecX;
            this.PosY = this.PosY - vecY < 0 ? this.PosY - vecY + 6 : this.PosY - vecY;
            this.Text = Program.cKey.Table[this.PosY, PosX];
        }

        public void MovePos(int vecX, int vecY)
        {
            this.PosX = (this.PosX + vecX > 5) ? this.PosX + vecX - 6 : this.PosX + vecX;
            this.PosY = this.PosY + vecY > 5 ? this.PosY + vecY - 6 : this.PosY + vecY;
            this.Text = Program.cKey.Table[this.PosY, PosX];
        }

        public void Update()
        {
            this.PosX = GetIndex(Program.cKey.Table, this.Text)[1];
            this.PosY = GetIndex(Program.cKey.Table, this.Text)[0];
        }
        public void Update(Marker marker)
        {
            this.PosX = GetIndex(Program.cKey.Table, marker.Text)[1];
            this.PosY = GetIndex(Program.cKey.Table, marker.Text)[0];
        }
    }
}
*/