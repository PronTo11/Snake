using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        int x;
        int y;
        public char sym;

        public Point ()
        { }

        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point tail)
        {
            x = tail.x;
            y = tail.y;
            sym = tail.sym;
        }

        public void Move(int offset,Direction direction)
        {
            if (direction == Direction.Right)
                x += offset;
            else if (direction == Direction.Left)
                x -= offset;
            else if (direction == Direction.Down)
                y += offset;
            else if (direction == Direction.Up)
                y -= offset;
        }

        public void Drow()
        {
            Console.SetCursorPosition(x,y);
            Console.Write(sym);
        }

        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }

        public override string ToString()
        {
            return $"{x}, {y}, {sym}";
        }

        public void Clear()
        {
            sym = ' ';
            Drow();
        }
    }
}
