﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    class Line
    {
        /// <summary>
        /// Classe des rangs et contient les tables
        /// </summary>
        public List<Table> tables { get; set; }

        public int posX;
        public int posY;

        public Line(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;

            tables = new List<Table> { };

            if ((posX == ConstantPosition.pixelSizeOfBlock * 15) && (posY == ConstantPosition.pixelSizeOfBlock * 6))
            {

                tables.Add(new Table(posX, posY, 4));
                tables.Add(new Table(posX + 5, posY, 8));
                tables.Add(new Table(posX + 10, posY, 2));
                tables.Add(new Table(posX + 15, posY, 6));
                tables.Add(new Table(posX, posY, 4));
                tables.Add(new Table(posX + 5, posY, 2));
                tables.Add(new Table(posX + 10, posY, 6));
                tables.Add(new Table(posX + 15, posY, 4));
            }

            if ((posX == ConstantPosition.pixelSizeOfBlock * 15) && (posY == ConstantPosition.pixelSizeOfBlock * 10))
            {
                tables.Add(new Table(posX, posY, 8));
                tables.Add(new Table(posX + 5, posY, 2));
                tables.Add(new Table(posX + 10, posY, 10));
                tables.Add(new Table(posX + 15, posY, 4));
                tables.Add(new Table(posX, posY + 6, 6));
                tables.Add(new Table(posX + 5, posY + 6, 4));
                tables.Add(new Table(posX + 10, posY + 6, 2));
                tables.Add(new Table(posX + 15, posY + 6, 2));
            }

            if ((posX == ConstantPosition.pixelSizeOfBlock * 38) && (posY == ConstantPosition.pixelSizeOfBlock * 6))
            {

                tables.Add(new Table(posX, posY, 2));
                tables.Add(new Table(posX + 5, posY, 8));
                tables.Add(new Table(posX + 10, posY, 4));
                tables.Add(new Table(posX + 15, posY, 2));
                tables.Add(new Table(posX, posY, 6));
                tables.Add(new Table(posX + 5, posY, 4));
                tables.Add(new Table(posX + 10, posY, 2));
                tables.Add(new Table(posX + 15, posY, 4));
            }

            if ((posX == ConstantPosition.pixelSizeOfBlock * 38) && (posY == ConstantPosition.pixelSizeOfBlock * 10))
            {
                tables.Add(new Table(posX, posY, 10));
                tables.Add(new Table(posX + 5, posY, 2));
                tables.Add(new Table(posX + 10, posY, 8));
                tables.Add(new Table(posX + 15, posY, 8));
                tables.Add(new Table(posX, posY + 6, 2));
                tables.Add(new Table(posX + 5, posY + 6, 4));
                tables.Add(new Table(posX + 10, posY + 6, 6));
                tables.Add(new Table(posX + 15, posY + 6, 4));
            }
        }
    }
}
