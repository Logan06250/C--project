﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterChefInfo
{
    /// <summary>
    /// Classe des carrés 
    /// </summary>
    class Square
    {
        public List<Line> lines { get; set; }
        public List<Waiter> waiters { get; set; }
        public SquareSupervisor squareSupervisor { get; set; }

        public int posX;

        public Square(int posX)
        {
            this.posX = posX;
            lines = new List<Line> { };
            waiters = new List<Waiter> { };

            lines.Add(new Line(ConstantPosition.pixelSizeOfBlock * posX, ConstantPosition.pixelSizeOfBlock * 6));
            lines.Add(new Line(ConstantPosition.pixelSizeOfBlock * posX, ConstantPosition.pixelSizeOfBlock * 10));

            if (posX < 36){
                squareSupervisor = new SquareSupervisor(1);
                waiters.Add(new Waiter(1));
                waiters.Add(new Waiter(2));
            }
            else{
                squareSupervisor = new SquareSupervisor(2);
                waiters.Add(new Waiter(3));
                waiters.Add(new Waiter(4));
            }
            
        }
    }
}
